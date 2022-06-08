using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuild.CodebuildWebhookFilterGroupFilter")]
    public class CodebuildWebhookFilterGroupFilter : aws.Codebuild.ICodebuildWebhookFilterGroupFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#pattern CodebuildWebhook#pattern}.</summary>
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
        public string Pattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#type CodebuildWebhook#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#exclude_matched_pattern CodebuildWebhook#exclude_matched_pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeMatchedPattern", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ExcludeMatchedPattern
        {
            get;
            set;
        }
    }
}
