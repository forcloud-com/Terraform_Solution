using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    /// <summary>AWS Config.</summary>
    [JsiiInterface(nativeType: typeof(IConfigConfigRuleConfig), fullyQualifiedName: "aws.config.ConfigConfigRuleConfig")]
    public interface IConfigConfigRuleConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#name ConfigConfigRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#source ConfigConfigRule#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"aws.config.ConfigConfigRuleSource\"}")]
        aws.Config.IConfigConfigRuleSource Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#description ConfigConfigRule#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#input_parameters ConfigConfigRule#input_parameters}.</summary>
        [JsiiProperty(name: "inputParameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#maximum_execution_frequency ConfigConfigRule#maximum_execution_frequency}.</summary>
        [JsiiProperty(name: "maximumExecutionFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumExecutionFrequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#scope ConfigConfigRule#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"aws.config.ConfigConfigRuleScope\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Config.IConfigConfigRuleScope? Scope
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#tags ConfigConfigRule#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Config.</summary>
        [JsiiTypeProxy(nativeType: typeof(IConfigConfigRuleConfig), fullyQualifiedName: "aws.config.ConfigConfigRuleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Config.IConfigConfigRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#name ConfigConfigRule#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#source ConfigConfigRule#source}
            /// </remarks>
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"aws.config.ConfigConfigRuleSource\"}")]
            public aws.Config.IConfigConfigRuleSource Source
            {
                get => GetInstanceProperty<aws.Config.IConfigConfigRuleSource>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#description ConfigConfigRule#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#input_parameters ConfigConfigRule#input_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputParameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputParameters
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#maximum_execution_frequency ConfigConfigRule#maximum_execution_frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumExecutionFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumExecutionFrequency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>scope block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#scope ConfigConfigRule#scope}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"aws.config.ConfigConfigRuleScope\"}", isOptional: true)]
            public aws.Config.IConfigConfigRuleScope? Scope
            {
                get => GetInstanceProperty<aws.Config.IConfigConfigRuleScope?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#tags ConfigConfigRule#tags}.</summary>
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
