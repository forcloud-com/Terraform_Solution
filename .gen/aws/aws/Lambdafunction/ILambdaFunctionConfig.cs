using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    /// <summary>AWS Lambda.</summary>
    [JsiiInterface(nativeType: typeof(ILambdaFunctionConfig), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionConfig")]
    public interface ILambdaFunctionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#function_name LambdaFunction#function_name}.</summary>
        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#handler LambdaFunction#handler}.</summary>
        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}")]
        string Handler
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#role LambdaFunction#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        string Role
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#runtime LambdaFunction#runtime}.</summary>
        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
        string Runtime
        {
            get;
        }

        /// <summary>dead_letter_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#dead_letter_config LambdaFunction#dead_letter_config}
        /// </remarks>
        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionDeadLetterConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lambdafunction.ILambdaFunctionDeadLetterConfig? DeadLetterConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#description LambdaFunction#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>environment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#environment LambdaFunction#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEnvironment\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lambdafunction.ILambdaFunctionEnvironment? Environment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#filename LambdaFunction#filename}.</summary>
        [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Filename
        {
            get
            {
                return null;
            }
        }

        /// <summary>file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#file_system_config LambdaFunction#file_system_config}
        /// </remarks>
        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionFileSystemConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lambdafunction.ILambdaFunctionFileSystemConfig? FileSystemConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#kms_key_arn LambdaFunction#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#layers LambdaFunction#layers}.</summary>
        [JsiiProperty(name: "layers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Layers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#memory_size LambdaFunction#memory_size}.</summary>
        [JsiiProperty(name: "memorySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemorySize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#publish LambdaFunction#publish}.</summary>
        [JsiiProperty(name: "publish", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Publish
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#reserved_concurrent_executions LambdaFunction#reserved_concurrent_executions}.</summary>
        [JsiiProperty(name: "reservedConcurrentExecutions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReservedConcurrentExecutions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#s3_bucket LambdaFunction#s3_bucket}.</summary>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#s3_key LambdaFunction#s3_key}.</summary>
        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#s3_object_version LambdaFunction#s3_object_version}.</summary>
        [JsiiProperty(name: "s3ObjectVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3ObjectVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#source_code_hash LambdaFunction#source_code_hash}.</summary>
        [JsiiProperty(name: "sourceCodeHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceCodeHash
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#tags LambdaFunction#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#timeout LambdaFunction#timeout}.</summary>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#timeouts LambdaFunction#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lambdafunction.ILambdaFunctionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>tracing_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#tracing_config LambdaFunction#tracing_config}
        /// </remarks>
        [JsiiProperty(name: "tracingConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionTracingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lambdafunction.ILambdaFunctionTracingConfig? TracingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#vpc_config LambdaFunction#vpc_config}
        /// </remarks>
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionVpcConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lambdafunction.ILambdaFunctionVpcConfig? VpcConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Lambda.</summary>
        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionConfig), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.ILambdaFunctionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#function_name LambdaFunction#function_name}.</summary>
            [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#handler LambdaFunction#handler}.</summary>
            [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}")]
            public string Handler
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#role LambdaFunction#role}.</summary>
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
            public string Role
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#runtime LambdaFunction#runtime}.</summary>
            [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
            public string Runtime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>dead_letter_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#dead_letter_config LambdaFunction#dead_letter_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionDeadLetterConfig\"}", isOptional: true)]
            public aws.Lambdafunction.ILambdaFunctionDeadLetterConfig? DeadLetterConfig
            {
                get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionDeadLetterConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#description LambdaFunction#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>environment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#environment LambdaFunction#environment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEnvironment\"}", isOptional: true)]
            public aws.Lambdafunction.ILambdaFunctionEnvironment? Environment
            {
                get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionEnvironment?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#filename LambdaFunction#filename}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Filename
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>file_system_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#file_system_config LambdaFunction#file_system_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionFileSystemConfig\"}", isOptional: true)]
            public aws.Lambdafunction.ILambdaFunctionFileSystemConfig? FileSystemConfig
            {
                get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionFileSystemConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#kms_key_arn LambdaFunction#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#layers LambdaFunction#layers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "layers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Layers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#memory_size LambdaFunction#memory_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memorySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemorySize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#publish LambdaFunction#publish}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publish", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Publish
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#reserved_concurrent_executions LambdaFunction#reserved_concurrent_executions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reservedConcurrentExecutions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReservedConcurrentExecutions
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#s3_bucket LambdaFunction#s3_bucket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#s3_key LambdaFunction#s3_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#s3_object_version LambdaFunction#s3_object_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3ObjectVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3ObjectVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#source_code_hash LambdaFunction#source_code_hash}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceCodeHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceCodeHash
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#tags LambdaFunction#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#timeout LambdaFunction#timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#timeouts LambdaFunction#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionTimeouts\"}", isOptional: true)]
            public aws.Lambdafunction.ILambdaFunctionTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionTimeouts?>();
            }

            /// <summary>tracing_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#tracing_config LambdaFunction#tracing_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tracingConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionTracingConfig\"}", isOptional: true)]
            public aws.Lambdafunction.ILambdaFunctionTracingConfig? TracingConfig
            {
                get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionTracingConfig?>();
            }

            /// <summary>vpc_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#vpc_config LambdaFunction#vpc_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionVpcConfig\"}", isOptional: true)]
            public aws.Lambdafunction.ILambdaFunctionVpcConfig? VpcConfig
            {
                get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionVpcConfig?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
