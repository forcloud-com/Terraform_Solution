using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl aws_waf_web_acl}.</summary>
    [JsiiClass(nativeType: typeof(aws.Waf.WafWebAcl), fullyQualifiedName: "aws.waf.WafWebAcl", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.waf.WafWebAclConfig\"}}]")]
    public class WafWebAcl : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl aws_waf_web_acl} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WafWebAcl(Constructs.Construct scope, string id, aws.Waf.IWafWebAclConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAcl(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAcl(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.waf.WafWebAclDefaultAction\"}}]")]
        public virtual void PutDefaultAction(aws.Waf.IWafWebAclDefaultAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Waf.IWafWebAclDefaultAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoggingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.waf.WafWebAclLoggingConfiguration\"}}]")]
        public virtual void PutLoggingConfiguration(aws.Waf.IWafWebAclLoggingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Waf.IWafWebAclLoggingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLoggingConfiguration")]
        public virtual void ResetLoggingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRules")]
        public virtual void ResetRules()
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
        = GetStaticProperty<string>(typeof(aws.Waf.WafWebAcl))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultAction", typeJson: "{\"fqn\":\"aws.waf.WafWebAclDefaultActionOutputReference\"}")]
        public virtual aws.Waf.WafWebAclDefaultActionOutputReference DefaultAction
        {
            get => GetInstanceProperty<aws.Waf.WafWebAclDefaultActionOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationOutputReference\"}")]
        public virtual aws.Waf.WafWebAclLoggingConfigurationOutputReference LoggingConfiguration
        {
            get => GetInstanceProperty<aws.Waf.WafWebAclLoggingConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultActionInput", typeJson: "{\"fqn\":\"aws.waf.WafWebAclDefaultAction\"}", isOptional: true)]
        public virtual aws.Waf.IWafWebAclDefaultAction? DefaultActionInput
        {
            get => GetInstanceProperty<aws.Waf.IWafWebAclDefaultAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingConfigurationInput", typeJson: "{\"fqn\":\"aws.waf.WafWebAclLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.Waf.IWafWebAclLoggingConfiguration? LoggingConfigurationInput
        {
            get => GetInstanceProperty<aws.Waf.IWafWebAclLoggingConfiguration?>();
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
        [JsiiProperty(name: "rulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.waf.WafWebAclRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RulesInput
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

        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.waf.WafWebAclRules\"},\"kind\":\"array\"}}]}}")]
        public virtual object Rules
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
