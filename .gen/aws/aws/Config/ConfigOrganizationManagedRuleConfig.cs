using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    #pragma warning disable CS8618

    /// <summary>AWS Config.</summary>
    [JsiiByValue(fqn: "aws.config.ConfigOrganizationManagedRuleConfig")]
    public class ConfigOrganizationManagedRuleConfig : aws.Config.IConfigOrganizationManagedRuleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_managed_rule#name ConfigOrganizationManagedRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_managed_rule#rule_identifier ConfigOrganizationManagedRule#rule_identifier}.</summary>
        [JsiiProperty(name: "ruleIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_managed_rule#description ConfigOrganizationManagedRule#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_managed_rule#excluded_accounts ConfigOrganizationManagedRule#excluded_accounts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedAccounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedAccounts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_managed_rule#input_parameters ConfigOrganizationManagedRule#input_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputParameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_managed_rule#maximum_execution_frequency ConfigOrganizationManagedRule#maximum_execution_frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumExecutionFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaximumExecutionFrequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_managed_rule#resource_id_scope ConfigOrganizationManagedRule#resource_id_scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceIdScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceIdScope
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_managed_rule#resource_types_scope ConfigOrganizationManagedRule#resource_types_scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTypesScope", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceTypesScope
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_managed_rule#tag_key_scope ConfigOrganizationManagedRule#tag_key_scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagKeyScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TagKeyScope
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_managed_rule#tag_value_scope ConfigOrganizationManagedRule#tag_value_scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagValueScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TagValueScope
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_organization_managed_rule#timeouts ConfigOrganizationManagedRule#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.config.ConfigOrganizationManagedRuleTimeouts\"}", isOptional: true)]
        public aws.Config.IConfigOrganizationManagedRuleTimeouts? Timeouts
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
