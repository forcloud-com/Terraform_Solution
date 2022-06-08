using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eventbridge.CloudwatchEventTargetEcsTarget")]
    public class CloudwatchEventTargetEcsTarget : aws.Eventbridge.ICloudwatchEventTargetEcsTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#task_definition_arn CloudwatchEventTarget#task_definition_arn}.</summary>
        [JsiiProperty(name: "taskDefinitionArn", typeJson: "{\"primitive\":\"string\"}")]
        public string TaskDefinitionArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#group CloudwatchEventTarget#group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Group
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#launch_type CloudwatchEventTarget#launch_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LaunchType
        {
            get;
            set;
        }

        /// <summary>network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#network_configuration CloudwatchEventTarget#network_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTargetNetworkConfiguration\"}", isOptional: true)]
        public aws.Eventbridge.ICloudwatchEventTargetEcsTargetNetworkConfiguration? NetworkConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#platform_version CloudwatchEventTarget#platform_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlatformVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#task_count CloudwatchEventTarget#task_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TaskCount
        {
            get;
            set;
        }
    }
}
