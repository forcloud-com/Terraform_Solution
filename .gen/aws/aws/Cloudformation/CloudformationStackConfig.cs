using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudformation
{
    #pragma warning disable CS8618

    /// <summary>AWS CloudFormation.</summary>
    [JsiiByValue(fqn: "aws.cloudformation.CloudformationStackConfig")]
    public class CloudformationStackConfig : aws.Cloudformation.ICloudformationStackConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack#name CloudformationStack#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack#capabilities CloudformationStack#capabilities}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capabilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Capabilities
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack#disable_rollback CloudformationStack#disable_rollback}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableRollback", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DisableRollback
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack#iam_role_arn CloudformationStack#iam_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IamRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack#notification_arns CloudformationStack#notification_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotificationArns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack#on_failure CloudformationStack#on_failure}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onFailure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnFailure
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack#parameters CloudformationStack#parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack#policy_body CloudformationStack#policy_body}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PolicyBody
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack#policy_url CloudformationStack#policy_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PolicyUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack#tags CloudformationStack#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack#template_body CloudformationStack#template_body}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "templateBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TemplateBody
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack#template_url CloudformationStack#template_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "templateUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TemplateUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack#timeout_in_minutes CloudformationStack#timeout_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutInMinutes
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack#timeouts CloudformationStack#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.cloudformation.CloudformationStackTimeouts\"}", isOptional: true)]
        public aws.Cloudformation.ICloudformationStackTimeouts? Timeouts
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
