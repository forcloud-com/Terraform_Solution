using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eventbridge.CloudwatchEventTargetBatchTarget")]
    public class CloudwatchEventTargetBatchTarget : aws.Eventbridge.ICloudwatchEventTargetBatchTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#job_definition CloudwatchEventTarget#job_definition}.</summary>
        [JsiiProperty(name: "jobDefinition", typeJson: "{\"primitive\":\"string\"}")]
        public string JobDefinition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#job_name CloudwatchEventTarget#job_name}.</summary>
        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
        public string JobName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#array_size CloudwatchEventTarget#array_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "arraySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ArraySize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#job_attempts CloudwatchEventTarget#job_attempts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jobAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? JobAttempts
        {
            get;
            set;
        }
    }
}
