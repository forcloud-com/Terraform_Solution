using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpoint
{
    [JsiiByValue(fqn: "aws.pinpoint.PinpointAppQuietTime")]
    public class PinpointAppQuietTime : aws.Pinpoint.IPinpointAppQuietTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#end PinpointApp#end}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? End
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#start PinpointApp#start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Start
        {
            get;
            set;
        }
    }
}
