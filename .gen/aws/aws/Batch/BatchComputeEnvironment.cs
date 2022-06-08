using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment aws_batch_compute_environment}.</summary>
    [JsiiClass(nativeType: typeof(aws.Batch.BatchComputeEnvironment), fullyQualifiedName: "aws.batch.BatchComputeEnvironment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.batch.BatchComputeEnvironmentConfig\"}}]")]
    public class BatchComputeEnvironment : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment aws_batch_compute_environment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BatchComputeEnvironment(Constructs.Construct scope, string id, aws.Batch.IBatchComputeEnvironmentConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchComputeEnvironment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchComputeEnvironment(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putComputeResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.batch.BatchComputeEnvironmentComputeResources\"}}]")]
        public virtual void PutComputeResources(aws.Batch.IBatchComputeEnvironmentComputeResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Batch.IBatchComputeEnvironmentComputeResources)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetComputeEnvironmentName")]
        public virtual void ResetComputeEnvironmentName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeEnvironmentNamePrefix")]
        public virtual void ResetComputeEnvironmentNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeResources")]
        public virtual void ResetComputeResources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
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
        = GetStaticProperty<string>(typeof(aws.Batch.BatchComputeEnvironment))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeResources", typeJson: "{\"fqn\":\"aws.batch.BatchComputeEnvironmentComputeResourcesOutputReference\"}")]
        public virtual aws.Batch.BatchComputeEnvironmentComputeResourcesOutputReference ComputeResources
        {
            get => GetInstanceProperty<aws.Batch.BatchComputeEnvironmentComputeResourcesOutputReference>()!;
        }

        [JsiiProperty(name: "eccClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EccClusterArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ecsClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EcsClusterArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeEnvironmentNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeEnvironmentNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeEnvironmentNamePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeEnvironmentNamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeResourcesInput", typeJson: "{\"fqn\":\"aws.batch.BatchComputeEnvironmentComputeResources\"}", isOptional: true)]
        public virtual aws.Batch.IBatchComputeEnvironmentComputeResources? ComputeResourcesInput
        {
            get => GetInstanceProperty<aws.Batch.IBatchComputeEnvironmentComputeResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "computeEnvironmentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeEnvironmentName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeEnvironmentNamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeEnvironmentNamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
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
