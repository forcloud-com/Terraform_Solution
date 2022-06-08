using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    /// <summary>AWS AppAutoScaling.</summary>
    [JsiiInterface(nativeType: typeof(IAppautoscalingScheduledActionConfig), fullyQualifiedName: "aws.appautoscaling.AppautoscalingScheduledActionConfig")]
    public interface IAppautoscalingScheduledActionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#name AppautoscalingScheduledAction#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#resource_id AppautoscalingScheduledAction#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#service_namespace AppautoscalingScheduledAction#service_namespace}.</summary>
        [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceNamespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#end_time AppautoscalingScheduledAction#end_time}.</summary>
        [JsiiProperty(name: "endTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#scalable_dimension AppautoscalingScheduledAction#scalable_dimension}.</summary>
        [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScalableDimension
        {
            get
            {
                return null;
            }
        }

        /// <summary>scalable_target_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#scalable_target_action AppautoscalingScheduledAction#scalable_target_action}
        /// </remarks>
        [JsiiProperty(name: "scalableTargetAction", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingScheduledActionScalableTargetAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appautoscaling.IAppautoscalingScheduledActionScalableTargetAction? ScalableTargetAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#schedule AppautoscalingScheduledAction#schedule}.</summary>
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Schedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#start_time AppautoscalingScheduledAction#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS AppAutoScaling.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingScheduledActionConfig), fullyQualifiedName: "aws.appautoscaling.AppautoscalingScheduledActionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Appautoscaling.IAppautoscalingScheduledActionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#name AppautoscalingScheduledAction#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#resource_id AppautoscalingScheduledAction#resource_id}.</summary>
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#service_namespace AppautoscalingScheduledAction#service_namespace}.</summary>
            [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceNamespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#end_time AppautoscalingScheduledAction#end_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#scalable_dimension AppautoscalingScheduledAction#scalable_dimension}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScalableDimension
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>scalable_target_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#scalable_target_action AppautoscalingScheduledAction#scalable_target_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scalableTargetAction", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingScheduledActionScalableTargetAction\"}", isOptional: true)]
            public aws.Appautoscaling.IAppautoscalingScheduledActionScalableTargetAction? ScalableTargetAction
            {
                get => GetInstanceProperty<aws.Appautoscaling.IAppautoscalingScheduledActionScalableTargetAction?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#schedule AppautoscalingScheduledAction#schedule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Schedule
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#start_time AppautoscalingScheduledAction#start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartTime
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
