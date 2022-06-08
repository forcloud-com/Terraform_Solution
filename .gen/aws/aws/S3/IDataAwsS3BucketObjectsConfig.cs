using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    /// <summary>AWS Simple Storage Service.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsS3BucketObjectsConfig), fullyQualifiedName: "aws.s3.DataAwsS3BucketObjectsConfig")]
    public interface IDataAwsS3BucketObjectsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#bucket DataAwsS3BucketObjects#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#delimiter DataAwsS3BucketObjects#delimiter}.</summary>
        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delimiter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#encoding_type DataAwsS3BucketObjects#encoding_type}.</summary>
        [JsiiProperty(name: "encodingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncodingType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#fetch_owner DataAwsS3BucketObjects#fetch_owner}.</summary>
        [JsiiProperty(name: "fetchOwner", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FetchOwner
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#max_keys DataAwsS3BucketObjects#max_keys}.</summary>
        [JsiiProperty(name: "maxKeys", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxKeys
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#prefix DataAwsS3BucketObjects#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#start_after DataAwsS3BucketObjects#start_after}.</summary>
        [JsiiProperty(name: "startAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartAfter
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Simple Storage Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsS3BucketObjectsConfig), fullyQualifiedName: "aws.s3.DataAwsS3BucketObjectsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IDataAwsS3BucketObjectsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#bucket DataAwsS3BucketObjects#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#delimiter DataAwsS3BucketObjects#delimiter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delimiter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#encoding_type DataAwsS3BucketObjects#encoding_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encodingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncodingType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#fetch_owner DataAwsS3BucketObjects#fetch_owner}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fetchOwner", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? FetchOwner
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#max_keys DataAwsS3BucketObjects#max_keys}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxKeys", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxKeys
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#prefix DataAwsS3BucketObjects#prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#start_after DataAwsS3BucketObjects#start_after}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartAfter
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
