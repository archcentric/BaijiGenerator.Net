﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CTripOSS.Baiji.Generator.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CTripOSS.Baiji.Generator.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to service(context, tweaks, global) ::= &lt;&lt;
        ///&lt;! ================================================================================== !&gt;
        ///&lt;! =                                                                                = !&gt;
        ///&lt;! = service definition                                                             = !&gt;
        ///&lt;! =                                                                                = !&gt;
        ///&lt;! = called from the generator to render a new service csharp source file.          = !&gt;
        ///&lt;! =                  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string csharp_common_st {
            get {
                return ResourceManager.GetString("csharp_common_st", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to _structbody(context) ::= &lt;&lt;
        ///&lt;_constructor(context)&gt;
        ///
        ///&lt;context.Fields : { field |&lt;_field(field)&gt;}; separator=&quot;\n&quot;&gt;
        ///&gt;&gt;
        ///
        ///_field(field) ::= &lt;&lt;
        ///&lt;if (tweaks.GEN_COMMENTS &amp;&amp; field.DocStringLines)&gt;
        ///&lt;_docString(field.DocStringLines)&gt;
        ///&lt;endif&gt;
        ///&lt;if (tweaks.GEN_PROTOBUF_ATTRIBUTE)&gt;
        ///[ProtoMember(&lt;field.Id&gt;)]
        ///&lt;endif&gt;
        ///public &lt;field.GenType.TypeName&gt; &lt;field.PropertyName&gt; { get; set; }
        ///
        ///&gt;&gt;
        ///
        ///_constructor(element) ::= &lt;&lt;
        ///&lt;if(element.Fields)&gt;
        ///public &lt;element.Name&gt;&lt;_params(element.Fields)&gt;
        ///{
        ///    &lt;element.Fie [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string csharp_ctor_st {
            get {
                return ResourceManager.GetString("csharp_ctor_st", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to _structbody(context) ::= &lt;&lt;
        ///&lt;_constructor(context)&gt;
        ///
        ///&lt;context.Fields : { field |&lt;_field(field)&gt;}; separator=&quot;\n&quot;&gt;
        ///&gt;&gt;
        ///
        ///_field(field) ::= &lt;&lt;
        ///&lt;if (tweaks.GEN_COMMENTS &amp;&amp; field.DocStringLines)&gt;
        ///&lt;_docString(field.DocStringLines)&gt;
        ///&lt;endif&gt;
        ///&lt;if (tweaks.GEN_PROTOBUF_ATTRIBUTE)&gt;
        ///[ProtoMember(&lt;field.Id&gt;)]
        ///&lt;endif&gt;
        ///public &lt;field.GenType.TypeName&gt; &lt;field.PropertyName&gt; { get; private set; }
        ///&gt;&gt;
        ///
        ///_constructor(element) ::= &lt;&lt;
        ///public &lt;element.Name&gt;&lt;_params(element.Fields)&gt; {
        ///    &lt;element.Fields: {field|&lt;_cto [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string csharp_immutable_st {
            get {
                return ResourceManager.GetString("csharp_immutable_st", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to _structbody(context) ::= &lt;&lt;
        ///&lt;_constructor(context)&gt;
        ///
        ///&lt;context.Fields : { field |&lt;_field(field)&gt;}; separator=&quot;\n&quot;&gt;
        ///&gt;&gt;
        ///
        ///_field(field) ::= &lt;&lt;
        ///&lt;if (tweaks.GEN_COMMENTS &amp;&amp; field.DocStringLines)&gt;
        ///&lt;_docString(field.DocStringLines)&gt;
        ///&lt;endif&gt;
        ///&lt;if (tweaks.GEN_PROTOBUF_ATTRIBUTE)&gt;
        ///[ProtoMember(&lt;field.Id&gt;)]
        ///&lt;endif&gt;
        ///public &lt;field.GenType.TypeName&gt; &lt;field.PropertyName&gt; { get; set; }
        ///&gt;&gt;
        ///
        ///_constructor(element) ::= &lt;&lt;
        ///public &lt;element.Name&gt;() {
        ///}
        ///&gt;&gt;
        ///
        ///.
        /// </summary>
        internal static string csharp_regular_st {
            get {
                return ResourceManager.GetString("csharp_regular_st", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to service(context, tweaks, global) ::= &lt;&lt;
        ///&lt;! ================================================================================== !&gt;
        ///&lt;! =                                                                                = !&gt;
        ///&lt;! = service definition                                                             = !&gt;
        ///&lt;! =                                                                                = !&gt;
        ///&lt;! = called from the generator to render a new service java source file.            = !&gt;
        ///&lt;! =                  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string java_common_st {
            get {
                return ResourceManager.GetString("java_common_st", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to _structbody(context) ::= &lt;&lt;
        ///&lt;_constructor(context)&gt;
        ///
        ///&lt;context.Fields : { field |&lt;_field(field)&gt;}; separator=&quot;\n\n&quot;&gt;
        ///
        ///&lt;context.Fields : { field |&lt;_field_getter_setter(field)&gt;}; separator=&quot;\n\n&quot;&gt;
        ///&gt;&gt;
        ///
        ///_field(field) ::= &lt;&lt;
        ///&lt;if (tweaks.GEN_COMMENTS &amp;&amp; field.DocStringLines)&gt;
        ///&lt;_docString(field.DocStringLines)&gt;
        ///&lt;endif&gt;
        ///&lt;if (tweaks.GEN_PUBLIC_FIELDS)&gt;public&lt;else&gt;private&lt;endif&gt; &lt;field.GenType.TypeName&gt; &lt;field.CodeName&gt;;
        ///&gt;&gt;
        ///
        ///_field_getter_setter(field) ::= &lt;&lt;
        ///&lt;if (tweaks.GEN_COMMENTS &amp;&amp; field.DocString [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string java_ctor_st {
            get {
                return ResourceManager.GetString("java_ctor_st", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to _structbody(context) ::= &lt;&lt;
        ///&lt;_constructor(context)&gt;
        ///
        ///&lt;context.Fields : { field |&lt;_field(field)&gt;}; separator=&quot;\n\n&quot;&gt;
        ///
        ///&lt;context.Fields : { field |&lt;_field_getter(field)&gt;}; separator=&quot;\n\n&quot;&gt;
        ///&gt;&gt;
        ///
        ///_field(field) ::= &lt;&lt;
        ///&lt;if (tweaks.GEN_COMMENTS &amp;&amp; field.DocStringLines)&gt;
        ///&lt;_docString(field.DocStringLines)&gt;
        ///&lt;endif&gt;
        ///&lt;if (tweaks.GEN_PUBLIC_FIELDS)&gt;public&lt;else&gt;private&lt;endif&gt; final &lt;field.GenType.TypeName&gt; &lt;field.CodeName&gt;;
        ///&gt;&gt;
        ///
        ///_field_getter(field) ::= &lt;&lt;
        ///&lt;if (tweaks.GEN_COMMENTS &amp;&amp; field.DocStringLines)&gt;        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string java_immutable_st {
            get {
                return ResourceManager.GetString("java_immutable_st", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to _structbody(context) ::= &lt;&lt;
        ///&lt;_constructor(context)&gt;
        ///
        ///&lt;context.Fields : { field |&lt;_field(field)&gt;}; separator=&quot;\n\n&quot;&gt;
        ///
        ///&lt;context.Fields : { field |&lt;_field_getter_setter(field)&gt;}; separator=&quot;\n\n&quot;&gt;
        ///&gt;&gt;
        ///
        ///_field(field) ::= &lt;&lt;
        ///&lt;if (tweaks.GEN_COMMENTS &amp;&amp; field.DocStringLines)&gt;
        ///&lt;_docString(field.DocStringLines)&gt;
        ///&lt;endif&gt;
        ///&lt;if (tweaks.GEN_PUBLIC_FIELDS)&gt;public&lt;else&gt;private&lt;endif&gt; &lt;field.GenType.TypeName&gt; &lt;field.CodeName&gt;;
        ///&gt;&gt;
        ///
        ///_field_getter_setter(field) ::= &lt;&lt;
        ///&lt;if (tweaks.GEN_COMMENTS &amp;&amp; field.DocString [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string java_regular_st {
            get {
                return ResourceManager.GetString("java_regular_st", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to _clientMethod(method) ::= &lt;&lt;
        ///&lt;if (tweaks.GEN_COMMENTS &amp;&amp; method.DocStringLines)&gt;
        ///&lt;_docString(method.DocStringLines)&gt;
        ///&lt;endif&gt;
        ///public &lt;method.ReturnType&gt; &lt;method.CodeName&gt;(&lt;if(method.ArgumentType)&gt;&lt;method.ArgumentType&gt; &lt;method.ArgumentName&gt;&lt;endif&gt;)
        ///                                throws Exception {
        ///    return super.invoke(&quot;&lt;method.CodeName&gt;&quot;&lt;if (method.ArgumentType)&gt;, &lt;method.ArgumentName&gt;&lt;endif&gt;, &lt;method.ReturnType&gt;.class);
        ///}
        ///&gt;&gt;
        ///
        ///struct(context, tweaks, global) ::= &lt;&lt;
        ///&lt;! ========================== [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string objectivec_common_st {
            get {
                return ResourceManager.GetString("objectivec_common_st", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to _structbody(context) ::= &lt;&lt;
        ///&lt;_constructor(context)&gt;
        ///
        ///&lt;context.Fields : { field |&lt;_field(field)&gt;}; separator=&quot;\n\n&quot;&gt;
        ///
        ///&lt;context.Fields : { field |&lt;_field_getter_setter(field)&gt;}; separator=&quot;\n\n&quot;&gt;
        ///&gt;&gt;
        ///
        ///_field(field) ::= &lt;&lt;
        ///&lt;if (tweaks.GEN_COMMENTS &amp;&amp; field.DocStringLines)&gt;
        ///&lt;_docString(field.DocStringLines)&gt;
        ///&lt;endif&gt;
        ///&lt;if (tweaks.GEN_PUBLIC_FIELDS)&gt;public&lt;else&gt;private&lt;endif&gt; &lt;field.GenType.TypeName&gt; &lt;field.CodeName&gt;;
        ///&gt;&gt;
        ///
        ///_field_getter_setter(field) ::= &lt;&lt;
        ///&lt;if (tweaks.GEN_COMMENTS &amp;&amp; field.DocString [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string objectivec_regular_st {
            get {
                return ResourceManager.GetString("objectivec_regular_st", resourceCulture);
            }
        }
    }
}
