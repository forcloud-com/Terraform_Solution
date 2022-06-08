using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    #pragma warning disable CS8618

    /// <summary>AWS Config.</summary>
    [JsiiByValue(fqn: "aws.config.ConfigOrganizationCustomRuleConfig")]
    public class ConfigOrganizationCustomRuleConfig : aws.Config.IConfigOrganizationCustomRuleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#lambda_function_arn ConfigOrganizationCustomRule#lambda_function_arn}.</summary>
        [JsiiProperty(name: "lambdaFunctionArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LambdaFunctionArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#name ConfigOrganizationCustomRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#trigger_types ConfigOrganizationCustomRule#trigger_types}.</summary>
        [JsiiProperty(name: "triggerTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] TriggerTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#description ConfigOrganizationCustomRule#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#excluded_accounts ConfigOrganizationCustomRule#excluded_accounts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedAccounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedAccounts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#input_parameters ConfigOrganizationCustomRule#input_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputParameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#maximum_execution_frequency ConfigOrganizationCustomRule#maximum_execution_frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumExecutionFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaximumExecutionFrequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#resource_id_scope ConfigOrganizationCustomRule#resource_id_scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceIdScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceIdScope
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#resource_types_scope ConfigOrganizationCustomRule#resource_types_scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTypesScope", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceTypesScope
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#tag_key_scope ConfigOrganizationCustomRule#tag_key_scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagKeyScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TagKeyScope
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#tag_value_scope ConfigOrganizationCustomRule#tag_value_scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagValueScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TagValueScope
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_custom_rule#timeouts ConfigOrganizationCustomRule#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.config.ConfigOrganizationCustomRuleTimeouts\"}", isOptional: true)]
        public aws.Config.IConfigOrganizationCustomRuleTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
