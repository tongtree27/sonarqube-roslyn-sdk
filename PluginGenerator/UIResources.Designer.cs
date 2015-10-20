﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PluginGenerator {
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
    internal class UIResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UIResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PluginGenerator.UIResources", typeof(UIResources).Assembly);
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
        ///   Looks up a localized string similar to Expecting one argument (the name of the plugin definition file).
        /// </summary>
        internal static string Cmd_Error_IncorrectArguments {
            get {
                return ResourceManager.GetString("Cmd_Error_IncorrectArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required plugin definition property is missing: {0}.
        /// </summary>
        internal static string Error_MissingProperty {
            get {
                return ResourceManager.GetString("Error_MissingProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A file with this name already exists: {0}.
        /// </summary>
        internal static string Gen_Error_JarFileExists {
            get {
                return ResourceManager.GetString("Gen_Error_JarFileExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This file has already been added to the jar: {0}.
        /// </summary>
        internal static string JarB_Error_FileAlreadySpecified {
            get {
                return ResourceManager.GetString("JarB_Error_FileAlreadySpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ths specified file to be included in the jar does not exist: {0}.
        /// </summary>
        internal static string JarB_Error_FileNotFound {
            get {
                return ResourceManager.GetString("JarB_Error_FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This jar output location has already been used: {0}. File: {1}.
        /// </summary>
        internal static string JarB_Error_RelativeJarPathAlreadySpecified {
            get {
                return ResourceManager.GetString("JarB_Error_RelativeJarPathAlreadySpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to build jar file.
        /// </summary>
        internal static string JarB_JarBuildingFailed {
            get {
                return ResourceManager.GetString("JarB_JarBuildingFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully built jar file: {0}.
        /// </summary>
        internal static string JarB_JarBuiltSuccessfully {
            get {
                return ResourceManager.GetString("JarB_JarBuiltSuccessfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The JDK is not installed or is not discoverable on this machine.
        /// </summary>
        internal static string JarB_JDK_NotInstalled {
            get {
                return ResourceManager.GetString("JarB_JDK_NotInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Java source code compilation failed.
        /// </summary>
        internal static string JComp_SourceCompilationFailed {
            get {
                return ResourceManager.GetString("JComp_SourceCompilationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully compiled Java source code.
        /// </summary>
        internal static string JComp_SourceCompilationSucceeded {
            get {
                return ResourceManager.GetString("JComp_SourceCompilationSucceeded", resourceCulture);
            }
        }
    }
}