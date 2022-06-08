using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl aws_wafv2_web_acl}.</summary>
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAcl), fullyQualifiedName: "aws.wafv2.Wafv2WebAcl", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclConfig\"}}]")]
    public class Wafv2WebAcl : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl aws_wafv2_web_acl} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Wafv2WebAcl(Constructs.Construct scope, string id, aws.Wafv2.IWafv2WebAclConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAcl(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAcl(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultAction\"}}]")]
        public virtual void PutDefaultAction(aws.Wafv2.IWafv2WebAclDefaultAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclDefaultAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVisibilityConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclVisibilityConfig\"}}]")]
        public virtual void PutVisibilityConfig(aws.Wafv2.IWafv2WebAclVisibilityConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclVisibilityConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRule")]
        public virtual void ResetRule()
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
        = GetStaticProperty<string>(typeof(aws.Wafv2.Wafv2WebAcl))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Capacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "defaultAction", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclDefaultActionOutputReference DefaultAction
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclDefaultActionOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lockToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LockToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "visibilityConfig", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclVisibilityConfigOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclVisibilityConfigOutputReference VisibilityConfig
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclVisibilityConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultActionInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultAction\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclDefaultAction? DefaultActionInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclDefaultAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScopeInput
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
        [JsiiProperty(name: "visibilityConfigInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclVisibilityConfig\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclVisibilityConfig? VisibilityConfigInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclVisibilityConfig?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRule\"},\"kind\":\"array\"}}]}}")]
        public virtual object Rule
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
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
    }
}
