using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition aws_batch_job_definition}.</summary>
    [JsiiClass(nativeType: typeof(aws.Batch.BatchJobDefinition), fullyQualifiedName: "aws.batch.BatchJobDefinition", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.batch.BatchJobDefinitionConfig\"}}]")]
    public class BatchJobDefinition : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition aws_batch_job_definition} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BatchJobDefinition(Constructs.Construct scope, string id, aws.Batch.IBatchJobDefinitionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchJobDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchJobDefinition(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRetryStrategy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.batch.BatchJobDefinitionRetryStrategy\"}}]")]
        public virtual void PutRetryStrategy(aws.Batch.IBatchJobDefinitionRetryStrategy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Batch.IBatchJobDefinitionRetryStrategy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.batch.BatchJobDefinitionTimeout\"}}]")]
        public virtual void PutTimeout(aws.Batch.IBatchJobDefinitionTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Batch.IBatchJobDefinitionTimeout)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContainerProperties")]
        public virtual void ResetContainerProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetryStrategy")]
        public virtual void ResetRetryStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeout")]
        public virtual void ResetTimeout()
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
        = GetStaticProperty<string>(typeof(aws.Batch.BatchJobDefinition))!;

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

        [JsiiProperty(name: "retryStrategy", typeJson: "{\"fqn\":\"aws.batch.BatchJobDefinitionRetryStrategyOutputReference\"}")]
        public virtual aws.Batch.BatchJobDefinitionRetryStrategyOutputReference RetryStrategy
        {
            get => GetInstanceProperty<aws.Batch.BatchJobDefinitionRetryStrategyOutputReference>()!;
        }

        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Revision
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.batch.BatchJobDefinitionTimeoutOutputReference\"}")]
        public virtual aws.Batch.BatchJobDefinitionTimeoutOutputReference Timeout
        {
            get => GetInstanceProperty<aws.Batch.BatchJobDefinitionTimeoutOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerPropertiesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerPropertiesInput
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
        [JsiiProperty(name: "parametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryStrategyInput", typeJson: "{\"fqn\":\"aws.batch.BatchJobDefinitionRetryStrategy\"}", isOptional: true)]
        public virtual aws.Batch.IBatchJobDefinitionRetryStrategy? RetryStrategyInput
        {
            get => GetInstanceProperty<aws.Batch.IBatchJobDefinitionRetryStrategy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"fqn\":\"aws.batch.BatchJobDefinitionTimeout\"}", isOptional: true)]
        public virtual aws.Batch.IBatchJobDefinitionTimeout? TimeoutInput
        {
            get => GetInstanceProperty<aws.Batch.IBatchJobDefinitionTimeout?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "containerProperties", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerProperties
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

        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
