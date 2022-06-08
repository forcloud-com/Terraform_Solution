using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetEcsTarget), fullyQualifiedName: "aws.eventbridge.CloudwatchEventTargetEcsTarget")]
    public interface ICloudwatchEventTargetEcsTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#task_definition_arn CloudwatchEventTarget#task_definition_arn}.</summary>
        [JsiiProperty(name: "taskDefinitionArn", typeJson: "{\"primitive\":\"string\"}")]
        string TaskDefinitionArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#group CloudwatchEventTarget#group}.</summary>
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Group
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#launch_type CloudwatchEventTarget#launch_type}.</summary>
        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LaunchType
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#network_configuration CloudwatchEventTarget#network_configuration}
        /// </remarks>
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTargetNetworkConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventTargetEcsTargetNetworkConfiguration? NetworkConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#platform_version CloudwatchEventTarget#platform_version}.</summary>
        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlatformVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#task_count CloudwatchEventTarget#task_count}.</summary>
        [JsiiProperty(name: "taskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TaskCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetEcsTarget), fullyQualifiedName: "aws.eventbridge.CloudwatchEventTargetEcsTarget")]
        internal sealed class _Proxy : DeputyBase, aws.Eventbridge.ICloudwatchEventTargetEcsTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#task_definition_arn CloudwatchEventTarget#task_definition_arn}.</summary>
            [JsiiProperty(name: "taskDefinitionArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TaskDefinitionArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#group CloudwatchEventTarget#group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Group
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#launch_type CloudwatchEventTarget#launch_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LaunchType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#network_configuration CloudwatchEventTarget#network_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTargetNetworkConfiguration\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventTargetEcsTargetNetworkConfiguration? NetworkConfiguration
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetEcsTargetNetworkConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#platform_version CloudwatchEventTarget#platform_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlatformVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#task_count CloudwatchEventTarget#task_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TaskCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
