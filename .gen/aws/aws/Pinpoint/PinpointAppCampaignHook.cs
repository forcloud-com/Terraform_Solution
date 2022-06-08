using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpoint
{
    [JsiiByValue(fqn: "aws.pinpoint.PinpointAppCampaignHook")]
    public class PinpointAppCampaignHook : aws.Pinpoint.IPinpointAppCampaignHook
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#lambda_function_name PinpointApp#lambda_function_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LambdaFunctionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#mode PinpointApp#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#web_url PinpointApp#web_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "webUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WebUrl
        {
            get;
            set;
        }
    }
}
