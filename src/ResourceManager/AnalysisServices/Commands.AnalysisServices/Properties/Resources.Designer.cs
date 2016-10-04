﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.AnalysisServices.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.AnalysisServices.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis Services server with name &apos;{0}&apos; already exists..
        /// </summary>
        internal static string AnalysisServerExists {
            get {
                return ResourceManager.GetString("AnalysisServerExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;default &quot;.
        /// </summary>
        internal static string DefaultAclWord {
            get {
                return ResourceManager.GetString("DefaultAclWord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find server: &apos;{0}&apos; in any resource group in the currently selected subscription: {1}. Please ensure this server exists and that the current user has access to it..
        /// </summary>
        internal static string FailedToDiscoverResourceGroup {
            get {
                return ResourceManager.GetString("FailedToDiscoverResourceGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AnalysisServices server operation failed with the following error code: {0} and message: {1}.
        /// </summary>
        internal static string LongRunningOperationFailed {
            get {
                return ResourceManager.GetString("LongRunningOperationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Analsysis Services server: &apos;{0}&apos; ....
        /// </summary>
        internal static string RemoveAnalsysisServicesServer {
            get {
                return ResourceManager.GetString("RemoveAnalsysisServicesServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove Analysis Services server: &apos;{0}&apos;?.
        /// </summary>
        internal static string RemovingAnalsysisServicesServer {
            get {
                return ResourceManager.GetString("RemovingAnalsysisServicesServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The script file at path &apos;{0}&apos; does not exist or the current user does not have permission to it. Please ensure the path exists and is accessible..
        /// </summary>
        internal static string ScriptFilePathDoesNotExist {
            get {
                return ResourceManager.GetString("ScriptFilePathDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot perform the requested operation because the specified server &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string ServerDoesNotExist {
            get {
                return ResourceManager.GetString("ServerDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation is being cancelled, please wait....
        /// </summary>
        internal static string TaskCancelledMessage {
            get {
                return ResourceManager.GetString("TaskCancelledMessage", resourceCulture);
            }
        }
    }
}