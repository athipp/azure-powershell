[CmdletBinding()]
Param
(
    [Parameter()]
    [string]$BuildConfig ="Debug"
)

$output = Join-Path (Get-Item $PSScriptRoot).Parent.FullName "src\Package\$BuildConfig"
Write-Verbose "The output folder is set to $output"
$resourceManagerPath = Join-Path $output "ResourceManager\AzureResourceManager"
$outputStack = Join-Path (Get-Item $PSScriptRoot).Parent.FullName "src\Stack\$BuildConfig"
$stackPath = Join-Path $outputStack "ResourceManager\AzureResourceManager"

$outputPaths = @($output)
if(Test-Path $outputStack)
{
    $outputPaths += $outputStack
}
foreach ($path in $outputPaths)
{
    Write-Verbose "Removing generated NuGet folders from $path"
    $resourcesFolders = @("de", "es", "fr", "it", "ja", "ko", "ru", "zh-Hans", "zh-Hant", "cs", "pl", "pt-BR", "tr")
    Get-ChildItem -Include $resourcesFolders -Recurse -Force -Path $path | Remove-Item -Force -Recurse -ErrorAction SilentlyContinue

    Write-Verbose "Removing autogenerated XML help files, code analysis, config files, and symbols."
    $exclude = @("*.dll-Help.xml", "Scaffold.xml", "RoleSettings.xml", "WebRole.xml", "WorkerRole.xml")
    $include = @("*.xml", "*.lastcodeanalysissucceeded", "*.dll.config", "*.pdb")
    Get-ChildItem -Include $include -Exclude $exclude -Recurse -Path $path | Remove-Item -Force -Recurse
    Get-ChildItem -Recurse -Path $path -Include *.dll-Help.psd1 | Remove-Item -Force

    Write-Verbose "Removing markdown help files and folders"
    Get-ChildItem -Recurse -Path $path -Include *.md | Remove-Item -Force -Confirm:$false
    Get-ChildItem -Directory -Include help -Recurse -Path $path | Remove-Item -Force -Confirm:$false -ErrorAction "Ignore"

    Write-Verbose "Removing unneeded web deployment dependencies"
    $webdependencies = @("Microsoft.Web.Hosting.dll", "Microsoft.Web.Delegation.dll", "Microsoft.Web.Administration.dll", "Microsoft.Web.Deployment.Tracing.dll")
    Get-ChildItem -Include $webdependencies -Recurse -Path $path | Remove-Item -Force
}

$resourceManagerPaths = @($resourceManagerPath)
if (Test-Path $stackPath)
{
    $resourceManagerPaths += $stackPath
}

foreach($RMPath in $resourceManagerPaths)
{
    $resourceManagerFolders = Get-ChildItem -Path $RMPath -Directory
    foreach ($RMFolder in $resourceManagerFolders)
    {
        $psd1 = Get-ChildItem -Path $RMFolder.FullName -Filter "$($RMFolder.Name).psd1"
        if ($null -eq $psd1)
        {
            Write-Host "Could not find .psd1 file in folder $RMFolder"
            continue
        }

        Import-LocalizedData -BindingVariable ModuleMetadata -BaseDirectory $psd1.DirectoryName -FileName $psd1.Name

        $acceptedDlls = @()

        # NestedModule Assemblies may have a folder path, just getting the dll name alone
        foreach($cmdAssembly in $ModuleMetadata.NestedModules)
        {
            $acceptedDlls += $cmdAssembly.Split("\")[-1]
        }

        # RequiredAssmeblies may have a folder path, just getting the dll name alone
        foreach($assembly in $ModuleMetadata.RequiredAssemblies)
        {
            $acceptedDlls += $assembly.Split("\")[-1]
        }

        Write-Verbose "Removing redundant dlls in $($RMFolder.Name)"
        $removedDlls = Get-ChildItem -Path $RMFolder.FullName -Filter "*.dll" -Recurse | where { $acceptedDlls -notcontains $_.Name -and !$_.FullName.Contains("Assemblies") }
        $removedDlls | % { Write-Verbose "Removing $($_.Name)"; Remove-Item $_.FullName -Force }

        Write-Verbose "Removing scripts and psd1 in $($RMFolder.FullName)"

        $removedPsd1 = Get-ChildItem -Path "$($RMFolder.FullName)" -Include "*.psd1" -Exclude "PsSwaggerUtility*.psd1" -Recurse | where { $_.FullName -ne "$($RMFolder.FullName)$([IO.Path]::DirectorySeparatorChar)$($RMFolder.Name).psd1" }
        $removedPsd1 | % { Write-Verbose "Removing $($_.FullName)"; Remove-Item $_.FullName -Force }
    }
}
