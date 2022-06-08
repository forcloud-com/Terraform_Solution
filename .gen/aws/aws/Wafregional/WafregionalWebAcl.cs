using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl aws_wafregional_web_acl}.</summary>
    [JsiiClass(nativeType: typeof(aws.Wafregional.WafregionalWebAcl), fullyQualifiedName: "aws.wafregional.WafregionalWebAcl", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.wafregional.WafregionalWebAclConfig\"}}]")]
    public class WafregionalWebAcl : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/wafregional_web_acl aws_wafregional_web_acl} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WafregionalWebAcl(Constructs.Construct scope, string id, aws.Wafregional.IWafregionalWebAclConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafregionalWebAcl(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafregionalWebAcl(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafregional.WafregionalWebAclDefaultAction\"}}]")]
        public virtual void PutDefaultAction(aws.Wafregional.IWafregionalWebAclDefaultAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafregional.IWafregionalWebAclDefaultAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoggingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfiguration\"}}]")]
        public virtual void PutLoggingConfiguration(aws.Wafregional.IWafregionalWebAclLoggingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafregional.IWafregionalWebAclLoggingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLoggingConfiguration")]
        public virtual void ResetLoggingConfiguration()
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
        = GetStaticProperty<string>(typeof(aws.Wafregional.WafregionalWebAcl))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultAction", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclDefaultActionOutputReference\"}")]
        public virtual aws.Wafregional.WafregionalWebAclDefaultActionOutputReference DefaultAction
        {
            get => GetInstanceProperty<aws.Wafregional.WafregionalWebAclDefaultActionOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfigurationOutputReference\"}")]
        public virtual aws.Wafregional.WafregionalWebAclLoggingConfigurationOutputReference LoggingConfiguration
        {
            get => GetInstanceProperty<aws.Wafregional.WafregionalWebAclLoggingConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultActionInput", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclDefaultAction\"}", isOptional: true)]
        public virtual aws.Wafregional.IWafregionalWebAclDefaultAction? DefaultActionInput
        {
            get => GetInstanceProperty<aws.Wafregional.IWafregionalWebAclDefaultAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingConfigurationInput", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalWebAclLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.Wafregional.IWafregionalWebAclLoggingConfiguration? LoggingConfigurationInput
        {
            get => GetInstanceProperty<aws.Wafregional.IWafregionalWebAclLoggingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricNameInput
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
        [JsiiProperty(name: "ruleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafregional.WafregionalWebAclRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricName
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

        [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafregional.WafregionalWebAclRule\"},\"kind\":\"array\"}}]}}")]
        public virtual object Rule
        {
            get => GetInstanceProperty<object>()!;
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
