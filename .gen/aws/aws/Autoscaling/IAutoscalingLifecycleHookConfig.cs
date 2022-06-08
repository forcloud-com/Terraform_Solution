using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    /// <summary>AWS Auto Scaling.</summary>
    [JsiiInterface(nativeType: typeof(IAutoscalingLifecycleHookConfig), fullyQualifiedName: "aws.autoscaling.AutoscalingLifecycleHookConfig")]
    public interface IAutoscalingLifecycleHookConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#autoscaling_group_name AutoscalingLifecycleHook#autoscaling_group_name}.</summary>
        [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string AutoscalingGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#lifecycle_transition AutoscalingLifecycleHook#lifecycle_transition}.</summary>
        [JsiiProperty(name: "lifecycleTransition", typeJson: "{\"primitive\":\"string\"}")]
        string LifecycleTransition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#name AutoscalingLifecycleHook#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#default_result AutoscalingLifecycleHook#default_result}.</summary>
        [JsiiProperty(name: "defaultResult", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultResult
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#heartbeat_timeout AutoscalingLifecycleHook#heartbeat_timeout}.</summary>
        [JsiiProperty(name: "heartbeatTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HeartbeatTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#notification_metadata AutoscalingLifecycleHook#notification_metadata}.</summary>
        [JsiiProperty(name: "notificationMetadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotificationMetadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#notification_target_arn AutoscalingLifecycleHook#notification_target_arn}.</summary>
        [JsiiProperty(name: "notificationTargetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotificationTargetArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#role_arn AutoscalingLifecycleHook#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Auto Scaling.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAutoscalingLifecycleHookConfig), fullyQualifiedName: "aws.autoscaling.AutoscalingLifecycleHookConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscaling.IAutoscalingLifecycleHookConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#autoscaling_group_name AutoscalingLifecycleHook#autoscaling_group_name}.</summary>
            [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string AutoscalingGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#lifecycle_transition AutoscalingLifecycleHook#lifecycle_transition}.</summary>
            [JsiiProperty(name: "lifecycleTransition", typeJson: "{\"primitive\":\"string\"}")]
            public string LifecycleTransition
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#name AutoscalingLifecycleHook#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#default_result AutoscalingLifecycleHook#default_result}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultResult", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultResult
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#heartbeat_timeout AutoscalingLifecycleHook#heartbeat_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "heartbeatTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HeartbeatTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#notification_metadata AutoscalingLifecycleHook#notification_metadata}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notificationMetadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotificationMetadata
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#notification_target_arn AutoscalingLifecycleHook#notification_target_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notificationTargetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotificationTargetArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_lifecycle_hook#role_arn AutoscalingLifecycleHook#role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleArn
            {
                get => GetInstanceProperty<string?>();
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
