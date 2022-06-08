using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    #pragma warning disable CS8618

    /// <summary>AWS Lambda.</summary>
    [JsiiByValue(fqn: "aws.lambdafunction.LambdaLayerVersionConfig")]
    public class LambdaLayerVersionConfig : aws.Lambdafunction.ILambdaLayerVersionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#layer_name LambdaLayerVersion#layer_name}.</summary>
        [JsiiProperty(name: "layerName", typeJson: "{\"primitive\":\"string\"}")]
        public string LayerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#compatible_runtimes LambdaLayerVersion#compatible_runtimes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compatibleRuntimes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CompatibleRuntimes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#description LambdaLayerVersion#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#filename LambdaLayerVersion#filename}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Filename
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#license_info LambdaLayerVersion#license_info}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenseInfo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LicenseInfo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#s3_bucket LambdaLayerVersion#s3_bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#s3_key LambdaLayerVersion#s3_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#s3_object_version LambdaLayerVersion#s3_object_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3ObjectVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3ObjectVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_layer_version#source_code_hash LambdaLayerVersion#source_code_hash}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceCodeHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceCodeHash
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
