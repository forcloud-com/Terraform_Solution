using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    /// <summary>AWS Simple Storage Service.</summary>
    [JsiiInterface(nativeType: typeof(IS3BucketInventoryConfig), fullyQualifiedName: "aws.s3.S3BucketInventoryConfig")]
    public interface IS3BucketInventoryConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#bucket S3BucketInventory#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#destination S3BucketInventory#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestination\"}")]
        aws.S3.IS3BucketInventoryDestination Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#included_object_versions S3BucketInventory#included_object_versions}.</summary>
        [JsiiProperty(name: "includedObjectVersions", typeJson: "{\"primitive\":\"string\"}")]
        string IncludedObjectVersions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#name S3BucketInventory#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#schedule S3BucketInventory#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventorySchedule\"}")]
        aws.S3.IS3BucketInventorySchedule Schedule
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#enabled S3BucketInventory#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#filter S3BucketInventory#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketInventoryFilter? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#optional_fields S3BucketInventory#optional_fields}.</summary>
        [JsiiProperty(name: "optionalFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OptionalFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Simple Storage Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IS3BucketInventoryConfig), fullyQualifiedName: "aws.s3.S3BucketInventoryConfig")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketInventoryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#bucket S3BucketInventory#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#destination S3BucketInventory#destination}
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestination\"}")]
            public aws.S3.IS3BucketInventoryDestination Destination
            {
                get => GetInstanceProperty<aws.S3.IS3BucketInventoryDestination>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#included_object_versions S3BucketInventory#included_object_versions}.</summary>
            [JsiiProperty(name: "includedObjectVersions", typeJson: "{\"primitive\":\"string\"}")]
            public string IncludedObjectVersions
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#name S3BucketInventory#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#schedule S3BucketInventory#schedule}
            /// </remarks>
            [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventorySchedule\"}")]
            public aws.S3.IS3BucketInventorySchedule Schedule
            {
                get => GetInstanceProperty<aws.S3.IS3BucketInventorySchedule>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#enabled S3BucketInventory#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#filter S3BucketInventory#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryFilter\"}", isOptional: true)]
            public aws.S3.IS3BucketInventoryFilter? Filter
            {
                get => GetInstanceProperty<aws.S3.IS3BucketInventoryFilter?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#optional_fields S3BucketInventory#optional_fields}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "optionalFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OptionalFields
            {
                get => GetInstanceProperty<string[]?>();
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
