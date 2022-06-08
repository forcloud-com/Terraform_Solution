using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    #pragma warning disable CS8618

    /// <summary>AWS CodePipeline.</summary>
    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineWebhookConfig")]
    public class CodepipelineWebhookConfig : aws.Codepipeline.ICodepipelineWebhookConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#authentication CodepipelineWebhook#authentication}.</summary>
        [JsiiProperty(name: "authentication", typeJson: "{\"primitive\":\"string\"}")]
        public string Authentication
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#filter CodepipelineWebhook#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineWebhookFilter\"},\"kind\":\"array\"}}]}}")]
        public object Filter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#name CodepipelineWebhook#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#target_action CodepipelineWebhook#target_action}.</summary>
        [JsiiProperty(name: "targetAction", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#target_pipeline CodepipelineWebhook#target_pipeline}.</summary>
        [JsiiProperty(name: "targetPipeline", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetPipeline
        {
            get;
            set;
        }

        /// <summary>authentication_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#authentication_configuration CodepipelineWebhook#authentication_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineWebhookAuthenticationConfiguration\"}", isOptional: true)]
        public aws.Codepipeline.ICodepipelineWebhookAuthenticationConfiguration? AuthenticationConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#tags CodepipelineWebhook#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
