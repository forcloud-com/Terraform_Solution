using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiInterface(nativeType: typeof(ICodebuildWebhookFilterGroupFilter), fullyQualifiedName: "aws.codebuild.CodebuildWebhookFilterGroupFilter")]
    public interface ICodebuildWebhookFilterGroupFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#pattern CodebuildWebhook#pattern}.</summary>
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
        string Pattern
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#type CodebuildWebhook#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#exclude_matched_pattern CodebuildWebhook#exclude_matched_pattern}.</summary>
        [JsiiProperty(name: "excludeMatchedPattern", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludeMatchedPattern
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildWebhookFilterGroupFilter), fullyQualifiedName: "aws.codebuild.CodebuildWebhookFilterGroupFilter")]
        internal sealed class _Proxy : DeputyBase, aws.Codebuild.ICodebuildWebhookFilterGroupFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#pattern CodebuildWebhook#pattern}.</summary>
            [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
            public string Pattern
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#type CodebuildWebhook#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#exclude_matched_pattern CodebuildWebhook#exclude_matched_pattern}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludeMatchedPattern", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ExcludeMatchedPattern
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
