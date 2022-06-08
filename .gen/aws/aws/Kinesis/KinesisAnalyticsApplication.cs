using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application aws_kinesis_analytics_application}.</summary>
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisAnalyticsApplication), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplication", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationConfig\"}}]")]
    public class KinesisAnalyticsApplication : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application aws_kinesis_analytics_application} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KinesisAnalyticsApplication(Constructs.Construct scope, string id, aws.Kinesis.IKinesisAnalyticsApplicationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplication(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplication(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLoggingOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationCloudwatchLoggingOptions\"}}]")]
        public virtual void PutCloudwatchLoggingOptions(aws.Kinesis.IKinesisAnalyticsApplicationCloudwatchLoggingOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationCloudwatchLoggingOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInputs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputs\"}}]")]
        public virtual void PutInputs(aws.Kinesis.IKinesisAnalyticsApplicationInputs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationInputs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReferenceDataSources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSources\"}}]")]
        public virtual void PutReferenceDataSources(aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSources)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLoggingOptions")]
        public virtual void ResetCloudwatchLoggingOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCode")]
        public virtual void ResetCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputs")]
        public virtual void ResetInputs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputs")]
        public virtual void ResetOutputs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReferenceDataSources")]
        public virtual void ResetReferenceDataSources()
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
        = GetStaticProperty<string>(typeof(aws.Kinesis.KinesisAnalyticsApplication))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationCloudwatchLoggingOptionsOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationCloudwatchLoggingOptionsOutputReference CloudwatchLoggingOptions
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationCloudwatchLoggingOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "createTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateTimestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inputs", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationInputsOutputReference Inputs
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationInputsOutputReference>()!;
        }

        [JsiiProperty(name: "lastUpdateTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastUpdateTimestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "referenceDataSources", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesOutputReference ReferenceDataSources
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptionsInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationCloudwatchLoggingOptions\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationCloudwatchLoggingOptions? CloudwatchLoggingOptionsInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationCloudwatchLoggingOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CodeInput
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
        [JsiiProperty(name: "inputsInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputs\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputs? InputsInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OutputsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "referenceDataSourcesInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSources\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSources? ReferenceDataSourcesInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Code
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outputs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputs\"},\"kind\":\"array\"}}]}}")]
        public virtual object Outputs
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
