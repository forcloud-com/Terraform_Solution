using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    [JsiiInterface(nativeType: typeof(ICodepipelineWebhookAuthenticationConfiguration), fullyQualifiedName: "aws.codepipeline.CodepipelineWebhookAuthenticationConfiguration")]
    public interface ICodepipelineWebhookAuthenticationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#allowed_ip_range CodepipelineWebhook#allowed_ip_range}.</summary>
        [JsiiProperty(name: "allowedIpRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllowedIpRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#secret_token CodepipelineWebhook#secret_token}.</summary>
        [JsiiProperty(name: "secretToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineWebhookAuthenticationConfiguration), fullyQualifiedName: "aws.codepipeline.CodepipelineWebhookAuthenticationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineWebhookAuthenticationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#allowed_ip_range CodepipelineWebhook#allowed_ip_range}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedIpRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllowedIpRange
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#secret_token CodepipelineWebhook#secret_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretToken
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
