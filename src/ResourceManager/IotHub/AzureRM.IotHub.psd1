#
# Module manifest for module 'PSGet_AzureRM.IotHub'
#
# Generated by: Microsoft Corporation
#
# Generated on: 12/13/2016
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '1.0.1'

# Supported PSEditions
# CompatiblePSEditions = @()

# ID used to uniquely identify this module
GUID = '51a3a993-fe39-4f8f-a437-2cb751584af5'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - IotHub service cmdlets for Azure Resource Manager'

# Minimum version of the Windows PowerShell engine required by this module
PowerShellVersion = '3.0'

# Name of the Windows PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the Windows PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.0'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
CLRVersion = '4.0'

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'AzureRM.Profile'; ModuleVersion = '2.4.0'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = '.\Microsoft.Azure.Commands.IotHub.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('.\Microsoft.Azure.Commands.IotHub.dll')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Add-AzureRmIotHubKey', 'Get-AzureRmIotHubEventHubConsumerGroup', 
               'Get-AzureRmIotHubConnectionString', 'Get-AzureRmIotHubJob', 
               'Get-AzureRmIotHubKey', 'Get-AzureRmIotHubQuotaMetric', 
               'Get-AzureRmIotHub', 'Get-AzureRmIotHubRegistryStatistic', 
               'Get-AzureRmIotHubValidSku', 
               'Add-AzureRmIotHubEventHubConsumerGroup', 'New-AzureRmIotHub', 
               'New-AzureRmIotHubExportDevices', 'New-AzureRmIotHubImportDevices', 
               'Remove-AzureRmIotHub', 'Remove-AzureRmIotHubEventHubConsumerGroup', 
               'Remove-AzureRmIotHubKey', 'Set-AzureRmIotHub'

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = 'Get-AzureRmIotHubEHCG', 'Add-AzureRmIotHubEHCG', 
               'Remove-AzureRmIotHubEHCG'

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ResourceManager','ARM','IoT','IoTHub'

        # A URL to the license for this module.
        LicenseUri = 'https://raw.githubusercontent.com/Azure/azure-powershell/dev/LICENSE.txt'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '* Adds commandlets for the Azure IoT Hub 
    - Add-AzureRmIotHubEventHubConsumerGroup
        - Adds an Event Hub consumer group for an existing Azure IoT hub.
    - Add-AzureRmIotHubKey
        - Adds a new key to an existing Azure IoT hub.
    - Get-AzureRmIotHub
        - Gets the properties of an exisiting Azure IoT hub.
    - Get-AzureRmIotHubConnectionString
        - Gets the connection strings of an existing Azure IoT hub.
    - Get-AzureRmIotHubEventHubConsumerGroup
        - Gets the list of event hub consumer groups for the specified eventhub endpoint.
    - Get-AzureRmIotHubJob
        - Gets the properties of a set of Azure IoT hubs in a subscription or resource group.
    - Get-AzureRmIotHubKey
        - Gets the information related to a list of keys of an Azure IoT hub.
    - Get-AzureRmIotHubQuotaMetric
        - Gets the quota metrics for an Azure IoT hub.
    - Get-AzureRmIotHubRegistryStatistic
        - Gets the registry statistics for an Azure IoT hub.
    - Get-AzureRmIotHubValidSku
        - Gets the list of valid Skus to which an existing Azure IoT hub can transition to.
    - New-AzureRmIotHub
        - Creates a new Azure IoT hub.
    - New-AzureRmIotHubExportDevices
        - Starts a new job for exporting the devices of an Azure IoT hub.
    - New-AzureRmIotHubImportDevices
        - Starts a new job for importing the devices of an Azure IoT hub.
    - Remove-AzureRmIotHub
        - Removes an Azure IoT hub.
    - Remove-AzureRmIotHubEventHubConsumerGroup
        - Removes a consumer group for the specified event hub endpoint of a give Azure IoT hub.
    - Remove-AzureRmIotHubKey
        - Removes a key from an Azure IoT hub.
    - Set-AzureRmIotHub
        - Updates the properties of an Azure IoT hub.
'

        # External dependent modules of this module
        # ExternalModuleDependencies = ''

    } # End of PSData hashtable
    
 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

