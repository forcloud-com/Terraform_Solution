using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model aws_sagemaker_model}.</summary>
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerModel), fullyQualifiedName: "aws.sagemaker.SagemakerModel", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerModelConfig\"}}]")]
    public class SagemakerModel : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model aws_sagemaker_model} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SagemakerModel(Constructs.Construct scope, string id, aws.Sagemaker.ISagemakerModelConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModel(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModel(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPrimaryContainer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerModelPrimaryContainer\"}}]")]
        public virtual void PutPrimaryContainer(aws.Sagemaker.ISagemakerModelPrimaryContainer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerModelPrimaryContainer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerModelVpcConfig\"}}]")]
        public virtual void PutVpcConfig(aws.Sagemaker.ISagemakerModelVpcConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerModelVpcConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContainer")]
        public virtual void ResetContainer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableNetworkIsolation")]
        public virtual void ResetEnableNetworkIsolation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryContainer")]
        public virtual void ResetPrimaryContainer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcConfig")]
        public virtual void ResetVpcConfig()
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
        = GetStaticProperty<string>(typeof(aws.Sagemaker.SagemakerModel))!;

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

        [JsiiProperty(name: "primaryContainer", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerModelPrimaryContainerOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerModelPrimaryContainerOutputReference PrimaryContainer
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerModelPrimaryContainerOutputReference>()!;
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerModelVpcConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerModelVpcConfigOutputReference VpcConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerModelVpcConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerModelContainer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ContainerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableNetworkIsolationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableNetworkIsolationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleArnInput
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
        [JsiiProperty(name: "primaryContainerInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerModelPrimaryContainer\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerModelPrimaryContainer? PrimaryContainerInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerModelPrimaryContainer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerModelVpcConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerModelVpcConfig? VpcConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerModelVpcConfig?>();
        }

        [JsiiProperty(name: "container", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerModelContainer\"},\"kind\":\"array\"}}]}}")]
        public virtual object Container
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableNetworkIsolation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableNetworkIsolation
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleArn
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
