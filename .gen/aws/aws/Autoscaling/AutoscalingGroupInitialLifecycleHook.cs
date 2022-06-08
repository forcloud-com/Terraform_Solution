using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingGroupInitialLifecycleHook")]
    public class AutoscalingGroupInitialLifecycleHook : aws.Autoscaling.IAutoscalingGroupInitialLifecycleHook
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#lifecycle_transition AutoscalingGroup#lifecycle_transition}.</summary>
        [JsiiProperty(name: "lifecycleTransition", typeJson: "{\"primitive\":\"string\"}")]
        public string LifecycleTransition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#name AutoscalingGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#default_result AutoscalingGroup#default_result}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultResult", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultResult
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#heartbeat_timeout AutoscalingGroup#heartbeat_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "heartbeatTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HeartbeatTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#notification_metadata AutoscalingGroup#notification_metadata}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationMetadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotificationMetadata
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#notification_target_arn AutoscalingGroup#notification_target_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationTargetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotificationTargetArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#role_arn AutoscalingGroup#role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoleArn
        {
            get;
            set;
        }
    }
}
