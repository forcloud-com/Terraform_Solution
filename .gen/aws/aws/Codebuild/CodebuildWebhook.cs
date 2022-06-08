using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook aws_codebuild_webhook}.</summary>
    [JsiiClass(nativeType: typeof(aws.Codebuild.CodebuildWebhook), fullyQualifiedName: "aws.codebuild.CodebuildWebhook", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildWebhookConfig\"}}]")]
    public class CodebuildWebhook : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook aws_codebuild_webhook} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CodebuildWebhook(Constructs.Construct scope, string id, aws.Codebuild.ICodebuildWebhookConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildWebhook(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildWebhook(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBranchFilter")]
        public virtual void ResetBranchFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilterGroup")]
        public virtual void ResetFilterGroup()
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
        = GetStaticProperty<string>(typeof(aws.Codebuild.CodebuildWebhook))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payloadUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayloadUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Secret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "branchFilterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BranchFilterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterGroupInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildWebhookFilterGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterGroupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "branchFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BranchFilter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filterGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildWebhookFilterGroup\"},\"kind\":\"array\"}}]}}")]
        public virtual object FilterGroup
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
