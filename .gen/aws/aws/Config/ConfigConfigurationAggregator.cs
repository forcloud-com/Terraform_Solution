using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_aggregator aws_config_configuration_aggregator}.</summary>
    [JsiiClass(nativeType: typeof(aws.Config.ConfigConfigurationAggregator), fullyQualifiedName: "aws.config.ConfigConfigurationAggregator", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.config.ConfigConfigurationAggregatorConfig\"}}]")]
    public class ConfigConfigurationAggregator : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_aggregator aws_config_configuration_aggregator} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ConfigConfigurationAggregator(Constructs.Construct scope, string id, aws.Config.IConfigConfigurationAggregatorConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigurationAggregator(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigurationAggregator(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccountAggregationSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.config.ConfigConfigurationAggregatorAccountAggregationSource\"}}]")]
        public virtual void PutAccountAggregationSource(aws.Config.IConfigConfigurationAggregatorAccountAggregationSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Config.IConfigConfigurationAggregatorAccountAggregationSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOrganizationAggregationSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.config.ConfigConfigurationAggregatorOrganizationAggregationSource\"}}]")]
        public virtual void PutOrganizationAggregationSource(aws.Config.IConfigConfigurationAggregatorOrganizationAggregationSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Config.IConfigConfigurationAggregatorOrganizationAggregationSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountAggregationSource")]
        public virtual void ResetAccountAggregationSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrganizationAggregationSource")]
        public virtual void ResetOrganizationAggregationSource()
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
        = GetStaticProperty<string>(typeof(aws.Config.ConfigConfigurationAggregator))!;

        [JsiiProperty(name: "accountAggregationSource", typeJson: "{\"fqn\":\"aws.config.ConfigConfigurationAggregatorAccountAggregationSourceOutputReference\"}")]
        public virtual aws.Config.ConfigConfigurationAggregatorAccountAggregationSourceOutputReference AccountAggregationSource
        {
            get => GetInstanceProperty<aws.Config.ConfigConfigurationAggregatorAccountAggregationSourceOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "organizationAggregationSource", typeJson: "{\"fqn\":\"aws.config.ConfigConfigurationAggregatorOrganizationAggregationSourceOutputReference\"}")]
        public virtual aws.Config.ConfigConfigurationAggregatorOrganizationAggregationSourceOutputReference OrganizationAggregationSource
        {
            get => GetInstanceProperty<aws.Config.ConfigConfigurationAggregatorOrganizationAggregationSourceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountAggregationSourceInput", typeJson: "{\"fqn\":\"aws.config.ConfigConfigurationAggregatorAccountAggregationSource\"}", isOptional: true)]
        public virtual aws.Config.IConfigConfigurationAggregatorAccountAggregationSource? AccountAggregationSourceInput
        {
            get => GetInstanceProperty<aws.Config.IConfigConfigurationAggregatorAccountAggregationSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "organizationAggregationSourceInput", typeJson: "{\"fqn\":\"aws.config.ConfigConfigurationAggregatorOrganizationAggregationSource\"}", isOptional: true)]
        public virtual aws.Config.IConfigConfigurationAggregatorOrganizationAggregationSource? OrganizationAggregationSourceInput
        {
            get => GetInstanceProperty<aws.Config.IConfigConfigurationAggregatorOrganizationAggregationSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
    }
}
