using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination), fullyQualifiedName: "aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination")]
    public interface IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination
    {
        /// <summary>s3_bucket_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration#s3_bucket_destination S3BucketAnalyticsConfiguration#s3_bucket_destination}
        /// </remarks>
        [JsiiProperty(name: "s3BucketDestination", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination\"}")]
        aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination S3BucketDestination
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination), fullyQualifiedName: "aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_bucket_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration#s3_bucket_destination S3BucketAnalyticsConfiguration#s3_bucket_destination}
            /// </remarks>
            [JsiiProperty(name: "s3BucketDestination", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination\"}")]
            public aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination S3BucketDestination
            {
                get => GetInstanceProperty<aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination>()!;
            }
        }
    }
}
