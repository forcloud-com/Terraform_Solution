using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    /// <summary>AWS CodePipeline.</summary>
    [JsiiInterface(nativeType: typeof(ICodepipelineWebhookConfig), fullyQualifiedName: "aws.codepipeline.CodepipelineWebhookConfig")]
    public interface ICodepipelineWebhookConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#authentication CodepipelineWebhook#authentication}.</summary>
        [JsiiProperty(name: "authentication", typeJson: "{\"primitive\":\"string\"}")]
        string Authentication
        {
            get;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#filter CodepipelineWebhook#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineWebhookFilter\"},\"kind\":\"array\"}}]}}")]
        object Filter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#name CodepipelineWebhook#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#target_action CodepipelineWebhook#target_action}.</summary>
        [JsiiProperty(name: "targetAction", typeJson: "{\"primitive\":\"string\"}")]
        string TargetAction
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#target_pipeline CodepipelineWebhook#target_pipeline}.</summary>
        [JsiiProperty(name: "targetPipeline", typeJson: "{\"primitive\":\"string\"}")]
        string TargetPipeline
        {
            get;
        }

        /// <summary>authentication_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#authentication_configuration CodepipelineWebhook#authentication_configuration}
        /// </remarks>
        [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineWebhookAuthenticationConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codepipeline.ICodepipelineWebhookAuthenticationConfiguration? AuthenticationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#tags CodepipelineWebhook#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS CodePipeline.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICodepipelineWebhookConfig), fullyQualifiedName: "aws.codepipeline.CodepipelineWebhookConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Codepipeline.ICodepipelineWebhookConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#authentication CodepipelineWebhook#authentication}.</summary>
            [JsiiProperty(name: "authentication", typeJson: "{\"primitive\":\"string\"}")]
            public string Authentication
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#filter CodepipelineWebhook#filter}
            /// </remarks>
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineWebhookFilter\"},\"kind\":\"array\"}}]}}")]
            public object Filter
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#name CodepipelineWebhook#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#target_action CodepipelineWebhook#target_action}.</summary>
            [JsiiProperty(name: "targetAction", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetAction
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#target_pipeline CodepipelineWebhook#target_pipeline}.</summary>
            [JsiiProperty(name: "targetPipeline", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetPipeline
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authentication_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#authentication_configuration CodepipelineWebhook#authentication_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineWebhookAuthenticationConfiguration\"}", isOptional: true)]
            public aws.Codepipeline.ICodepipelineWebhookAuthenticationConfiguration? AuthenticationConfiguration
            {
                get => GetInstanceProperty<aws.Codepipeline.ICodepipelineWebhookAuthenticationConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook#tags CodepipelineWebhook#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
