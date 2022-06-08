using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    /// <summary>AWS Auto Scaling.</summary>
    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingAttachmentConfig")]
    public class AutoscalingAttachmentConfig : aws.Autoscaling.IAutoscalingAttachmentConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_attachment#autoscaling_group_name AutoscalingAttachment#autoscaling_group_name}.</summary>
        [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string AutoscalingGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_attachment#alb_target_group_arn AutoscalingAttachment#alb_target_group_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "albTargetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AlbTargetGroupArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_attachment#elb AutoscalingAttachment#elb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Elb
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
