using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    /// <summary>AWS Config.</summary>
    [JsiiInterface(nativeType: typeof(IConfigOrganizationCustomRuleConfig), fullyQualifiedName: "aws.config.ConfigOrganizationCustomRuleConfig")]
    public interface IConfigOrganizationCustomRuleConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#lambda_function_arn ConfigOrganizationCustomRule#lambda_function_arn}.</summary>
        [JsiiProperty(name: "lambdaFunctionArn", typeJson: "{\"primitive\":\"string\"}")]
        string LambdaFunctionArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#name ConfigOrganizationCustomRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#trigger_types ConfigOrganizationCustomRule#trigger_types}.</summary>
        [JsiiProperty(name: "triggerTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] TriggerTypes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#description ConfigOrganizationCustomRule#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#excluded_accounts ConfigOrganizationCustomRule#excluded_accounts}.</summary>
        [JsiiProperty(name: "excludedAccounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedAccounts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#input_parameters ConfigOrganizationCustomRule#input_parameters}.</summary>
        [JsiiProperty(name: "inputParameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#maximum_execution_frequency ConfigOrganizationCustomRule#maximum_execution_frequency}.</summary>
        [JsiiProperty(name: "maximumExecutionFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumExecutionFrequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#resource_id_scope ConfigOrganizationCustomRule#resource_id_scope}.</summary>
        [JsiiProperty(name: "resourceIdScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceIdScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#resource_types_scope ConfigOrganizationCustomRule#resource_types_scope}.</summary>
        [JsiiProperty(name: "resourceTypesScope", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ResourceTypesScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#tag_key_scope ConfigOrganizationCustomRule#tag_key_scope}.</summary>
        [JsiiProperty(name: "tagKeyScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TagKeyScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#tag_value_scope ConfigOrganizationCustomRule#tag_value_scope}.</summary>
        [JsiiProperty(name: "tagValueScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TagValueScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#timeouts ConfigOrganizationCustomRule#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.config.ConfigOrganizationCustomRuleTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Config.IConfigOrganizationCustomRuleTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Config.</summary>
        [JsiiTypeProxy(nativeType: typeof(IConfigOrganizationCustomRuleConfig), fullyQualifiedName: "aws.config.ConfigOrganizationCustomRuleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Config.IConfigOrganizationCustomRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#lambda_function_arn ConfigOrganizationCustomRule#lambda_function_arn}.</summary>
            [JsiiProperty(name: "lambdaFunctionArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LambdaFunctionArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#name ConfigOrganizationCustomRule#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#trigger_types ConfigOrganizationCustomRule#trigger_types}.</summary>
            [JsiiProperty(name: "triggerTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] TriggerTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#description ConfigOrganizationCustomRule#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#excluded_accounts ConfigOrganizationCustomRule#excluded_accounts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedAccounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedAccounts
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#input_parameters ConfigOrganizationCustomRule#input_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputParameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputParameters
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#maximum_execution_frequency ConfigOrganizationCustomRule#maximum_execution_frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumExecutionFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumExecutionFrequency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#resource_id_scope ConfigOrganizationCustomRule#resource_id_scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceIdScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceIdScope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#resource_types_scope ConfigOrganizationCustomRule#resource_types_scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypesScope", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ResourceTypesScope
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#tag_key_scope ConfigOrganizationCustomRule#tag_key_scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagKeyScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TagKeyScope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#tag_value_scope ConfigOrganizationCustomRule#tag_value_scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagValueScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TagValueScope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#timeouts ConfigOrganizationCustomRule#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.config.ConfigOrganizationCustomRuleTimeouts\"}", isOptional: true)]
            public aws.Config.IConfigOrganizationCustomRuleTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Config.IConfigOrganizationCustomRuleTimeouts?>();
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
