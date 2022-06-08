using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook aws_codepipeline_webhook}.</summary>
    [JsiiClass(nativeType: typeof(aws.Codepipeline.CodepipelineWebhook), fullyQualifiedName: "aws.codepipeline.CodepipelineWebhook", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.codepipeline.CodepipelineWebhookConfig\"}}]")]
    public class CodepipelineWebhook : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/codepipeline_webhook aws_codepipeline_webhook} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CodepipelineWebhook(Constructs.Construct scope, string id, aws.Codepipeline.ICodepipelineWebhookConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineWebhook(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineWebhook(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuthenticationConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codepipeline.CodepipelineWebhookAuthenticationConfiguration\"}}]")]
        public virtual void PutAuthenticationConfiguration(aws.Codepipeline.ICodepipelineWebhookAuthenticationConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codepipeline.ICodepipelineWebhookAuthenticationConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthenticationConfiguration")]
        public virtual void ResetAuthenticationConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Codepipeline.CodepipelineWebhook))!;

        [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineWebhookAuthenticationConfigurationOutputReference\"}")]
        public virtual aws.Codepipeline.CodepipelineWebhookAuthenticationConfigurationOutputReference AuthenticationConfiguration
        {
            get => GetInstanceProperty<aws.Codepipeline.CodepipelineWebhookAuthenticationConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationConfigurationInput", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineWebhookAuthenticationConfiguration\"}", isOptional: true)]
        public virtual aws.Codepipeline.ICodepipelineWebhookAuthenticationConfiguration? AuthenticationConfigurationInput
        {
            get => GetInstanceProperty<aws.Codepipeline.ICodepipelineWebhookAuthenticationConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthenticationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineWebhookFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetPipelineInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetPipelineInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "authentication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authentication
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codepipeline.CodepipelineWebhookFilter\"},\"kind\":\"array\"}}]}}")]
        public virtual object Filter
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetPipeline", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetPipeline
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
