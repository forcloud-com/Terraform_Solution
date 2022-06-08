using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/glue_job aws_glue_job}.</summary>
    [JsiiClass(nativeType: typeof(aws.Glue.GlueJob), fullyQualifiedName: "aws.glue.GlueJob", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.glue.GlueJobConfig\"}}]")]
    public class GlueJob : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/glue_job aws_glue_job} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GlueJob(Constructs.Construct scope, string id, aws.Glue.IGlueJobConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueJob(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueJob(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCommand", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueJobCommand\"}}]")]
        public virtual void PutCommand(aws.Glue.IGlueJobCommand @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueJobCommand)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExecutionProperty", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueJobExecutionProperty\"}}]")]
        public virtual void PutExecutionProperty(aws.Glue.IGlueJobExecutionProperty @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueJobExecutionProperty)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotificationProperty", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueJobNotificationProperty\"}}]")]
        public virtual void PutNotificationProperty(aws.Glue.IGlueJobNotificationProperty @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueJobNotificationProperty)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllocatedCapacity")]
        public virtual void ResetAllocatedCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnections")]
        public virtual void ResetConnections()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultArguments")]
        public virtual void ResetDefaultArguments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutionProperty")]
        public virtual void ResetExecutionProperty()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGlueVersion")]
        public virtual void ResetGlueVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxCapacity")]
        public virtual void ResetMaxCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxRetries")]
        public virtual void ResetMaxRetries()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotificationProperty")]
        public virtual void ResetNotificationProperty()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberOfWorkers")]
        public virtual void ResetNumberOfWorkers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityConfiguration")]
        public virtual void ResetSecurityConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeout")]
        public virtual void ResetTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkerType")]
        public virtual void ResetWorkerType()
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
        = GetStaticProperty<string>(typeof(aws.Glue.GlueJob))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "command", typeJson: "{\"fqn\":\"aws.glue.GlueJobCommandOutputReference\"}")]
        public virtual aws.Glue.GlueJobCommandOutputReference Command
        {
            get => GetInstanceProperty<aws.Glue.GlueJobCommandOutputReference>()!;
        }

        [JsiiProperty(name: "executionProperty", typeJson: "{\"fqn\":\"aws.glue.GlueJobExecutionPropertyOutputReference\"}")]
        public virtual aws.Glue.GlueJobExecutionPropertyOutputReference ExecutionProperty
        {
            get => GetInstanceProperty<aws.Glue.GlueJobExecutionPropertyOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationProperty", typeJson: "{\"fqn\":\"aws.glue.GlueJobNotificationPropertyOutputReference\"}")]
        public virtual aws.Glue.GlueJobNotificationPropertyOutputReference NotificationProperty
        {
            get => GetInstanceProperty<aws.Glue.GlueJobNotificationPropertyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocatedCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AllocatedCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commandInput", typeJson: "{\"fqn\":\"aws.glue.GlueJobCommand\"}", isOptional: true)]
        public virtual aws.Glue.IGlueJobCommand? CommandInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueJobCommand?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ConnectionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultArgumentsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefaultArgumentsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionPropertyInput", typeJson: "{\"fqn\":\"aws.glue.GlueJobExecutionProperty\"}", isOptional: true)]
        public virtual aws.Glue.IGlueJobExecutionProperty? ExecutionPropertyInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueJobExecutionProperty?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "glueVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GlueVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxRetriesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxRetriesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationPropertyInput", typeJson: "{\"fqn\":\"aws.glue.GlueJobNotificationProperty\"}", isOptional: true)]
        public virtual aws.Glue.IGlueJobNotificationProperty? NotificationPropertyInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueJobNotificationProperty?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberOfWorkersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumberOfWorkersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityConfigurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityConfigurationInput
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
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workerTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkerTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allocatedCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AllocatedCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connections", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Connections
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefaultArguments
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "glueVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GlueVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRetries
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numberOfWorkers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfWorkers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityConfiguration
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

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkerType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
