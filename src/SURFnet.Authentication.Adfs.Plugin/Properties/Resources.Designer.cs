﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SURFnet.Authentication.Adfs.Plugin.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SURFnet.Authentication.Adfs.Plugin.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;div&gt;Er is een onherstelbare fout opgetreden. Probeer het opnieuw.&lt;/div&gt;
        ///&lt;div id=&quot;intro&quot; class=&quot;groupMargin&quot;&gt;
        ///    &lt;p id=&quot;supportEmail&quot;&gt;Support information&lt;/p&gt;
        ///&lt;/div&gt;
        ///.
        /// </summary>
        internal static string AuthFailedForm {
            get {
                return ResourceManager.GetString("AuthFailedForm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;div id=&quot;loginArea&quot;&gt;
        ///    &lt;form method=&quot;post&quot; name=&quot;loginform&quot; id=&quot;loginForm&quot; action=&quot;{formUrl}&quot;&gt;
        ///        &lt;input id=&quot;AuthMethod&quot; type=&quot;hidden&quot; name=&quot;AuthMethod&quot; value=&quot;%AuthMethod%&quot; /&gt;
        ///        &lt;input id=&quot;Context&quot; type=&quot;text&quot; name=&quot;Context&quot; value=&quot;%Context%&quot; /&gt;
        ///        &lt;input id=&quot;orgQueryString&quot; type=&quot;hidden&quot; name=&quot;orgQueryString&quot; value=&quot;{orgQueryString}&quot; /&gt;
        ///        &lt;input id=&quot;submitButton&quot; type=&quot;submit&quot; value=&quot;Submit&quot;/&gt;
        ///    &lt;/form&gt;
        ///&lt;/div&gt;
        ///&lt;div id=&quot;intro&quot; class=&quot;groupMargin&quot;&gt;
        ///    &lt;p id=&quot;supportEmail&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AuthForm {
            get {
                return ResourceManager.GetString("AuthForm", resourceCulture);
            }
        }
    }
}
