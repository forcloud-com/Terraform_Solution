using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    /// <summary>AWS WAF.</summary>
    [JsiiInterface(nativeType: typeof(IWafWebAclConfig), fullyQualifiedName: "aws.waf.WafWebAclConfig")]
    public interface IWafWebAclConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>default_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#default_action WafWebAcl#default_action}
        /// </remarks>
        [JsiiProperty(name: "defaultAction", typeJson: "{\"fqn\":\"aws.waf.WafWebAclDefaultAction\"}")]
        aws.Waf.IWafWebAclDefaultAction DefaultAction
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#metric_name WafWebAcl#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        string MetricName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#name WafWebAcl#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>logging_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#logging_configuration WafWebAcl#logging_configuration}
        /// </remarks>
        [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"fqn\":\"aws.waf.WafWebAclLoggingConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Waf.IWafWebAclLoggingConfiguration? LoggingConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#rules WafWebAcl#rules}
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.waf.WafWebAclRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Rules
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#tags WafWebAcl#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS WAF.</summary>
        [JsiiTypeProxy(nativeType: typeof(IWafWebAclConfig), fullyQualifiedName: "aws.waf.WafWebAclConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Waf.IWafWebAclConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#default_action WafWebAcl#default_action}
            /// </remarks>
            [JsiiProperty(name: "defaultAction", typeJson: "{\"fqn\":\"aws.waf.WafWebAclDefaultAction\"}")]
            public aws.Waf.IWafWebAclDefaultAction DefaultAction
            {
                get => GetInstanceProperty<aws.Waf.IWafWebAclDefaultAction>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#metric_name WafWebAcl#metric_name}.</summary>
            [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#name WafWebAcl#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>logging_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#logging_configuration WafWebAcl#logging_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"fqn\":\"aws.waf.WafWebAclLoggingConfiguration\"}", isOptional: true)]
            public aws.Waf.IWafWebAclLoggingConfiguration? LoggingConfiguration
            {
                get => GetInstanceProperty<aws.Waf.IWafWebAclLoggingConfiguration?>();
            }

            /// <summary>rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#rules WafWebAcl#rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.waf.WafWebAclRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Rules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#tags WafWebAcl#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
