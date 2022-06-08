using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineWebhookFilter")]
    public class CodepipelineWebhookFilter : aws.Codepipeline.ICodepipelineWebhookFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#json_path CodepipelineWebhook#json_path}.</summary>
        [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
        public string JsonPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#match_equals CodepipelineWebhook#match_equals}.</summary>
        [JsiiProperty(name: "matchEquals", typeJson: "{\"primitive\":\"string\"}")]
        public string MatchEquals
        {
            get;
            set;
        }
    }
}
