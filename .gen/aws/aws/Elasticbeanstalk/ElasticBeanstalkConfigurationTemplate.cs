using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticbeanstalk
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template aws_elastic_beanstalk_configuration_template}.</summary>
    [JsiiClass(nativeType: typeof(aws.Elasticbeanstalk.ElasticBeanstalkConfigurationTemplate), fullyQualifiedName: "aws.elasticbeanstalk.ElasticBeanstalkConfigurationTemplate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elasticbeanstalk.ElasticBeanstalkConfigurationTemplateConfig\"}}]")]
    public class ElasticBeanstalkConfigurationTemplate : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template aws_elastic_beanstalk_configuration_template} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElasticBeanstalkConfigurationTemplate(Constructs.Construct scope, string id, aws.Elasticbeanstalk.IElasticBeanstalkConfigurationTemplateConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticBeanstalkConfigurationTemplate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticBeanstalkConfigurationTemplate(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironmentId")]
        public virtual void ResetEnvironmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSetting")]
        public virtual void ResetSetting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSolutionStackName")]
        public virtual void ResetSolutionStackName()
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
        = GetStaticProperty<string>(typeof(aws.Elasticbeanstalk.ElasticBeanstalkConfigurationTemplate))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnvironmentIdInput
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
        [JsiiProperty(name: "settingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticbeanstalk.ElasticBeanstalkConfigurationTemplateSetting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SettingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "solutionStackNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SolutionStackNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Application
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentId
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

        [JsiiProperty(name: "setting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticbeanstalk.ElasticBeanstalkConfigurationTemplateSetting\"},\"kind\":\"array\"}}]}}")]
        public virtual object Setting
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "solutionStackName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SolutionStackName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
