using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/datasync_task aws_datasync_task}.</summary>
    [JsiiClass(nativeType: typeof(aws.Datasync.DatasyncTask), fullyQualifiedName: "aws.datasync.DatasyncTask", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.datasync.DatasyncTaskConfig\"}}]")]
    public class DatasyncTask : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/datasync_task aws_datasync_task} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatasyncTask(Constructs.Construct scope, string id, aws.Datasync.IDatasyncTaskConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncTask(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncTask(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasync.DatasyncTaskOptions\"}}]")]
        public virtual void PutOptions(aws.Datasync.IDatasyncTaskOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Datasync.IDatasyncTaskOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasync.DatasyncTaskTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Datasync.IDatasyncTaskTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Datasync.IDatasyncTaskTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLogGroupArn")]
        public virtual void ResetCloudwatchLogGroupArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOptions")]
        public virtual void ResetOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Datasync.DatasyncTask))!;

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

        [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"aws.datasync.DatasyncTaskOptionsOutputReference\"}")]
        public virtual aws.Datasync.DatasyncTaskOptionsOutputReference Options
        {
            get => GetInstanceProperty<aws.Datasync.DatasyncTaskOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.datasync.DatasyncTaskTimeoutsOutputReference\"}")]
        public virtual aws.Datasync.DatasyncTaskTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Datasync.DatasyncTaskTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogGroupArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudwatchLogGroupArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationLocationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationLocationArnInput
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
        [JsiiProperty(name: "optionsInput", typeJson: "{\"fqn\":\"aws.datasync.DatasyncTaskOptions\"}", isOptional: true)]
        public virtual aws.Datasync.IDatasyncTaskOptions? OptionsInput
        {
            get => GetInstanceProperty<aws.Datasync.IDatasyncTaskOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceLocationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceLocationArnInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.datasync.DatasyncTaskTimeouts\"}", isOptional: true)]
        public virtual aws.Datasync.IDatasyncTaskTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Datasync.IDatasyncTaskTimeouts?>();
        }

        [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudwatchLogGroupArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationLocationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationLocationArn
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

        [JsiiProperty(name: "sourceLocationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceLocationArn
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
