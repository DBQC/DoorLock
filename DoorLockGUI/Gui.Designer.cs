﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoorLockGUI {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Gui : global::System.Configuration.ApplicationSettingsBase {
        
        private static Gui defaultInstance = ((Gui)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Gui())));
        
        public static Gui Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30000")]
        public int LockOutTime {
            get {
                return ((int)(this["LockOutTime"]));
            }
            set {
                this["LockOutTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int CodeAttempts {
            get {
                return ((int)(this["CodeAttempts"]));
            }
            set {
                this["CodeAttempts"] = value;
            }
        }
    }
}
