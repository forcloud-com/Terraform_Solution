using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudwatch
{
    #pragma warning disable CS8618

    /// <summary>AWS CloudWatch.</summary>
    [JsiiByValue(fqn: "aws.cloudwatch.CloudwatchLogSubscriptionFilterConfig")]
    public class CloudwatchLogSubscriptionFilterConfig : aws.Cloudwatch.ICloudwatchLogSubscriptionFilterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_subscription_filter#destination_arn CloudwatchLogSubscriptionFilter#destination_arn}.</summary>
        [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_subscription_filter#filter_pattern CloudwatchLogSubscriptionFilter#filter_pattern}.</summary>
        [JsiiProperty(name: "filterPattern", typeJson: "{\"primitive\":\"string\"}")]
        public string FilterPattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_subscription_filter#log_group_name CloudwatchLogSubscriptionFilter#log_group_name}.</summary>
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_subscription_filter#name CloudwatchLogSubscriptionFilter#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_subscription_filter#distribution CloudwatchLogSubscriptionFilter#distribution}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "distribution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Distribution
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_subscription_filter#role_arn CloudwatchLogSubscriptionFilter#role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoleArn
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
