using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    /// <summary>AWS Lambda.</summary>
    [JsiiInterface(nativeType: typeof(ILambdaLayerVersionConfig), fullyQualifiedName: "aws.lambdafunction.LambdaLayerVersionConfig")]
    public interface ILambdaLayerVersionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#layer_name LambdaLayerVersion#layer_name}.</summary>
        [JsiiProperty(name: "layerName", typeJson: "{\"primitive\":\"string\"}")]
        string LayerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#compatible_runtimes LambdaLayerVersion#compatible_runtimes}.</summary>
        [JsiiProperty(name: "compatibleRuntimes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CompatibleRuntimes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#description LambdaLayerVersion#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#filename LambdaLayerVersion#filename}.</summary>
        [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Filename
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#license_info LambdaLayerVersion#license_info}.</summary>
        [JsiiProperty(name: "licenseInfo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LicenseInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#s3_bucket LambdaLayerVersion#s3_bucket}.</summary>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#s3_key LambdaLayerVersion#s3_key}.</summary>
        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#s3_object_version LambdaLayerVersion#s3_object_version}.</summary>
        [JsiiProperty(name: "s3ObjectVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3ObjectVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#source_code_hash LambdaLayerVersion#source_code_hash}.</summary>
        [JsiiProperty(name: "sourceCodeHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceCodeHash
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Lambda.</summary>
        [JsiiTypeProxy(nativeType: typeof(ILambdaLayerVersionConfig), fullyQualifiedName: "aws.lambdafunction.LambdaLayerVersionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.ILambdaLayerVersionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#layer_name LambdaLayerVersion#layer_name}.</summary>
            [JsiiProperty(name: "layerName", typeJson: "{\"primitive\":\"string\"}")]
            public string LayerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#compatible_runtimes LambdaLayerVersion#compatible_runtimes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compatibleRuntimes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CompatibleRuntimes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#description LambdaLayerVersion#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#filename LambdaLayerVersion#filename}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Filename
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#license_info LambdaLayerVersion#license_info}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "licenseInfo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LicenseInfo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#s3_bucket LambdaLayerVersion#s3_bucket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#s3_key LambdaLayerVersion#s3_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#s3_object_version LambdaLayerVersion#s3_object_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3ObjectVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3ObjectVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#source_code_hash LambdaLayerVersion#source_code_hash}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceCodeHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceCodeHash
            {
                get => GetInstanceProperty<string?>();
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
