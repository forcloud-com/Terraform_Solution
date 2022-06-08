using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    /// <summary>AWS Auto Scaling.</summary>
    [JsiiInterface(nativeType: typeof(IAutoscalingAttachmentConfig), fullyQualifiedName: "aws.autoscaling.AutoscalingAttachmentConfig")]
    public interface IAutoscalingAttachmentConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_attachment#autoscaling_group_name AutoscalingAttachment#autoscaling_group_name}.</summary>
        [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string AutoscalingGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_attachment#alb_target_group_arn AutoscalingAttachment#alb_target_group_arn}.</summary>
        [JsiiProperty(name: "albTargetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AlbTargetGroupArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_attachment#elb AutoscalingAttachment#elb}.</summary>
        [JsiiProperty(name: "elb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Elb
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Auto Scaling.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAutoscalingAttachmentConfig), fullyQualifiedName: "aws.autoscaling.AutoscalingAttachmentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscaling.IAutoscalingAttachmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_attachment#autoscaling_group_name AutoscalingAttachment#autoscaling_group_name}.</summary>
            [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string AutoscalingGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_attachment#alb_target_group_arn AutoscalingAttachment#alb_target_group_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "albTargetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AlbTargetGroupArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_attachment#elb AutoscalingAttachment#elb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Elb
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
