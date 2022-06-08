using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eventbridge.CloudwatchEventTargetInputTransformer")]
    public class CloudwatchEventTargetInputTransformer : aws.Eventbridge.ICloudwatchEventTargetInputTransformer
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#input_template CloudwatchEventTarget#input_template}.</summary>
        [JsiiProperty(name: "inputTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public string InputTemplate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#input_paths CloudwatchEventTarget#input_paths}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? InputPaths
        {
            get;
            set;
        }
    }
}
