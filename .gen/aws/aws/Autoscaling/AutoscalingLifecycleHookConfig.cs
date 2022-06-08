using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    /// <summary>AWS Auto Scaling.</summary>
    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingLifecycleHookConfig")]
    public class AutoscalingLifecycleHookConfig : aws.Autoscaling.IAutoscalingLifecycleHookConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#autoscaling_group_name AutoscalingLifecycleHook#autoscaling_group_name}.</summary>
        [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string AutoscalingGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#lifecycle_transition AutoscalingLifecycleHook#lifecycle_transition}.</summary>
        [JsiiProperty(name: "lifecycleTransition", typeJson: "{\"primitive\":\"string\"}")]
        public string LifecycleTransition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#name AutoscalingLifecycleHook#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#default_result AutoscalingLifecycleHook#default_result}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultResult", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultResult
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#heartbeat_timeout AutoscalingLifecycleHook#heartbeat_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "heartbeatTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HeartbeatTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#notification_metadata AutoscalingLifecycleHook#notification_metadata}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationMetadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotificationMetadata
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#notification_target_arn AutoscalingLifecycleHook#notification_target_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationTargetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotificationTargetArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#role_arn AutoscalingLifecycleHook#role_arn}.</summary>
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
