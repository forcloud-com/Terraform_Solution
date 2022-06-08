using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticbeanstalk
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_application aws_elastic_beanstalk_application}.</summary>
    [JsiiClass(nativeType: typeof(aws.Elasticbeanstalk.ElasticBeanstalkApplication), fullyQualifiedName: "aws.elasticbeanstalk.ElasticBeanstalkApplication", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elasticbeanstalk.ElasticBeanstalkApplicationConfig\"}}]")]
    public class ElasticBeanstalkApplication : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_application aws_elastic_beanstalk_application} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElasticBeanstalkApplication(Constructs.Construct scope, string id, aws.Elasticbeanstalk.IElasticBeanstalkApplicationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticBeanstalkApplication(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticBeanstalkApplication(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAppversionLifecycle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticbeanstalk.ElasticBeanstalkApplicationAppversionLifecycle\"}}]")]
        public virtual void PutAppversionLifecycle(aws.Elasticbeanstalk.IElasticBeanstalkApplicationAppversionLifecycle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticbeanstalk.IElasticBeanstalkApplicationAppversionLifecycle)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAppversionLifecycle")]
        public virtual void ResetAppversionLifecycle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
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
        = GetStaticProperty<string>(typeof(aws.Elasticbeanstalk.ElasticBeanstalkApplication))!;

        [JsiiProperty(name: "appversionLifecycle", typeJson: "{\"fqn\":\"aws.elasticbeanstalk.ElasticBeanstalkApplicationAppversionLifecycleOutputReference\"}")]
        public virtual aws.Elasticbeanstalk.ElasticBeanstalkApplicationAppversionLifecycleOutputReference AppversionLifecycle
        {
            get => GetInstanceProperty<aws.Elasticbeanstalk.ElasticBeanstalkApplicationAppversionLifecycleOutputReference>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "appversionLifecycleInput", typeJson: "{\"fqn\":\"aws.elasticbeanstalk.ElasticBeanstalkApplicationAppversionLifecycle\"}", isOptional: true)]
        public virtual aws.Elasticbeanstalk.IElasticBeanstalkApplicationAppversionLifecycle? AppversionLifecycleInput
        {
            get => GetInstanceProperty<aws.Elasticbeanstalk.IElasticBeanstalkApplicationAppversionLifecycle?>();
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
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
