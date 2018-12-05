//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
#if NETSTANDARD
    [CmdletOutputBreakingChange(typeof(PSUpgradePolicy),
        DeprecatedOutputProperties = new string[] { "AutomaticOSUpgrade", "AutoOSUpgradePolicy" })]
    [CmdletOutputBreakingChange(typeof(PSVirtualMachineScaleSetIdentity),
        DeprecatedOutputProperties = new string[] { "IdentityIds" })]
#endif
    [Cmdlet(VerbsCommon.Add, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssExtension", SupportsShouldProcess = true)]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class AddAzureRmVmssExtensionCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public PSVirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public string Publisher { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public string Type { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipelineByPropertyName = true)]
        public string TypeHandlerVersion { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipelineByPropertyName = true)]
        public bool? AutoUpgradeMinorVersion { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipelineByPropertyName = true)]
        public Object Setting { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipelineByPropertyName = true)]
        public Object ProtectedSetting { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string ForceUpdateTag { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("VirtualMachineScaleSet", "Add"))
            {
                Run();
            }
        }

        private void Run()
        {
            // VirtualMachineProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
            }

            // ExtensionProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile = new VirtualMachineScaleSetExtensionProfile();
            }

            // Extensions
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions = new List<VirtualMachineScaleSetExtension>();
            }

            var vExtensions = new VirtualMachineScaleSetExtension();

            vExtensions.Name = this.MyInvocation.BoundParameters.ContainsKey("Name") ? this.Name : null;
            vExtensions.ForceUpdateTag = this.MyInvocation.BoundParameters.ContainsKey("ForceUpdateTag") ? this.ForceUpdateTag : null;
            vExtensions.Publisher = this.MyInvocation.BoundParameters.ContainsKey("Publisher") ? this.Publisher : null;
            vExtensions.Type = this.MyInvocation.BoundParameters.ContainsKey("Type") ? this.Type : null;
            vExtensions.TypeHandlerVersion = this.MyInvocation.BoundParameters.ContainsKey("TypeHandlerVersion") ? this.TypeHandlerVersion : null;
            vExtensions.AutoUpgradeMinorVersion = this.MyInvocation.BoundParameters.ContainsKey("AutoUpgradeMinorVersion") ? this.AutoUpgradeMinorVersion : (bool?)null;
            vExtensions.Settings = this.MyInvocation.BoundParameters.ContainsKey("Setting") ? this.Setting : null;
            vExtensions.ProtectedSettings = this.MyInvocation.BoundParameters.ContainsKey("ProtectedSetting") ? this.ProtectedSetting : null;
            this.VirtualMachineScaleSet.VirtualMachineProfile.ExtensionProfile.Extensions.Add(vExtensions);
            WriteObject(this.VirtualMachineScaleSet);
        }
    }
}
