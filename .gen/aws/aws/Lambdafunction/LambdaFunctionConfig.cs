using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    #pragma warning disable CS8618

    /// <summary>AWS Lambda.</summary>
    [JsiiByValue(fqn: "aws.lambdafunction.LambdaFunctionConfig")]
    public class LambdaFunctionConfig : aws.Lambdafunction.ILambdaFunctionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#function_name LambdaFunction#function_name}.</summary>
        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public string FunctionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#handler LambdaFunction#handler}.</summary>
        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}")]
        public string Handler
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#role LambdaFunction#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public string Role
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#runtime LambdaFunction#runtime}.</summary>
        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}")]
        public string Runtime
        {
            get;
            set;
        }

        /// <summary>dead_letter_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#dead_letter_config LambdaFunction#dead_letter_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionDeadLetterConfig\"}", isOptional: true)]
        public aws.Lambdafunction.ILambdaFunctionDeadLetterConfig? DeadLetterConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#description LambdaFunction#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>environment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#environment LambdaFunction#environment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEnvironment\"}", isOptional: true)]
        public aws.Lambdafunction.ILambdaFunctionEnvironment? Environment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#filename LambdaFunction#filename}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Filename
        {
            get;
            set;
        }

        /// <summary>file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#file_system_config LambdaFunction#file_system_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionFileSystemConfig\"}", isOptional: true)]
        public aws.Lambdafunction.ILambdaFunctionFileSystemConfig? FileSystemConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#kms_key_arn LambdaFunction#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#layers LambdaFunction#layers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "layers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Layers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#memory_size LambdaFunction#memory_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memorySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemorySize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#publish LambdaFunction#publish}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publish", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Publish
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#reserved_concurrent_executions LambdaFunction#reserved_concurrent_executions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reservedConcurrentExecutions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReservedConcurrentExecutions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#s3_bucket LambdaFunction#s3_bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#s3_key LambdaFunction#s3_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#s3_object_version LambdaFunction#s3_object_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3ObjectVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3ObjectVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#source_code_hash LambdaFunction#source_code_hash}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceCodeHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceCodeHash
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#tags LambdaFunction#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#timeout LambdaFunction#timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Timeout
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#timeouts LambdaFunction#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionTimeouts\"}", isOptional: true)]
        public aws.Lambdafunction.ILambdaFunctionTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>tracing_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#tracing_config LambdaFunction#tracing_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tracingConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionTracingConfig\"}", isOptional: true)]
        public aws.Lambdafunction.ILambdaFunctionTracingConfig? TracingConfig
        {
            get;
            set;
        }

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#vpc_config LambdaFunction#vpc_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionVpcConfig\"}", isOptional: true)]
        public aws.Lambdafunction.ILambdaFunctionVpcConfig? VpcConfig
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
