using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport), fullyQualifiedName: "aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport")]
    public interface IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration#destination S3BucketAnalyticsConfiguration#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination\"}")]
        aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration#output_schema_version S3BucketAnalyticsConfiguration#output_schema_version}.</summary>
        [JsiiProperty(name: "outputSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputSchemaVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport), fullyQualifiedName: "aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration#destination S3BucketAnalyticsConfiguration#destination}
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination\"}")]
            public aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination Destination
            {
                get => GetInstanceProperty<aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration#output_schema_version S3BucketAnalyticsConfiguration#output_schema_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputSchemaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputSchemaVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
