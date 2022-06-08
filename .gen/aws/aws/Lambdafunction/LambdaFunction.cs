using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/lambda_function aws_lambda_function}.</summary>
    [JsiiClass(nativeType: typeof(aws.Lambdafunction.LambdaFunction), fullyQualifiedName: "aws.lambdafunction.LambdaFunction", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaFunctionConfig\"}}]")]
    public class LambdaFunction : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/lambda_function aws_lambda_function} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LambdaFunction(Constructs.Construct scope, string id, aws.Lambdafunction.ILambdaFunctionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunction(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunction(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDeadLetterConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaFunctionDeadLetterConfig\"}}]")]
        public virtual void PutDeadLetterConfig(aws.Lambdafunction.ILambdaFunctionDeadLetterConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaFunctionDeadLetterConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnvironment", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaFunctionEnvironment\"}}]")]
        public virtual void PutEnvironment(aws.Lambdafunction.ILambdaFunctionEnvironment @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaFunctionEnvironment)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFileSystemConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaFunctionFileSystemConfig\"}}]")]
        public virtual void PutFileSystemConfig(aws.Lambdafunction.ILambdaFunctionFileSystemConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaFunctionFileSystemConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaFunctionTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Lambdafunction.ILambdaFunctionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaFunctionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTracingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaFunctionTracingConfig\"}}]")]
        public virtual void PutTracingConfig(aws.Lambdafunction.ILambdaFunctionTracingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaFunctionTracingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaFunctionVpcConfig\"}}]")]
        public virtual void PutVpcConfig(aws.Lambdafunction.ILambdaFunctionVpcConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaFunctionVpcConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeadLetterConfig")]
        public virtual void ResetDeadLetterConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironment")]
        public virtual void ResetEnvironment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilename")]
        public virtual void ResetFilename()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileSystemConfig")]
        public virtual void ResetFileSystemConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyArn")]
        public virtual void ResetKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLayers")]
        public virtual void ResetLayers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemorySize")]
        public virtual void ResetMemorySize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublish")]
        public virtual void ResetPublish()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReservedConcurrentExecutions")]
        public virtual void ResetReservedConcurrentExecutions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Bucket")]
        public virtual void ResetS3Bucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Key")]
        public virtual void ResetS3Key()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3ObjectVersion")]
        public virtual void ResetS3ObjectVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceCodeHash")]
        public virtual void ResetSourceCodeHash()
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

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTracingConfig")]
        public virtual void ResetTracingConfig()
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
        = GetStaticProperty<string>(typeof(aws.Lambdafunction.LambdaFunction))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionDeadLetterConfigOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaFunctionDeadLetterConfigOutputReference DeadLetterConfig
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaFunctionDeadLetterConfigOutputReference>()!;
        }

        [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEnvironmentOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaFunctionEnvironmentOutputReference Environment
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaFunctionEnvironmentOutputReference>()!;
        }

        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionFileSystemConfigOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaFunctionFileSystemConfigOutputReference FileSystemConfig
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaFunctionFileSystemConfigOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invokeArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvokeArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "qualifiedArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QualifiedArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceCodeSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SourceCodeSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionTimeoutsOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaFunctionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaFunctionTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "tracingConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionTracingConfigOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaFunctionTracingConfigOutputReference TracingConfig
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaFunctionTracingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionVpcConfigOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaFunctionVpcConfigOutputReference VpcConfig
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaFunctionVpcConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deadLetterConfigInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionDeadLetterConfig\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaFunctionDeadLetterConfig? DeadLetterConfigInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionDeadLetterConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEnvironment\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaFunctionEnvironment? EnvironmentInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionEnvironment?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filenameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FilenameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemConfigInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionFileSystemConfig\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaFunctionFileSystemConfig? FileSystemConfigInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionFileSystemConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "handlerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HandlerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "layersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LayersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memorySizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemorySizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publishInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PublishInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reservedConcurrentExecutionsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReservedConcurrentExecutionsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuntimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3KeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3KeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ObjectVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3ObjectVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceCodeHashInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceCodeHashInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionTimeouts\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaFunctionTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tracingConfigInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionTracingConfig\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaFunctionTracingConfig? TracingConfigInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionTracingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionVpcConfig\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaFunctionVpcConfig? VpcConfigInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionVpcConfig?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Filename
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Handler
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "layers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Layers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memorySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publish", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Publish
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reservedConcurrentExecutions", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReservedConcurrentExecutions
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Runtime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3Key
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3ObjectVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3ObjectVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceCodeHash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCodeHash
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
    }
}
