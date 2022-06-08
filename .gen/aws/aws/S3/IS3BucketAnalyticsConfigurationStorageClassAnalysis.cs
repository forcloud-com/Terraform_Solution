using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysis), fullyQualifiedName: "aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysis")]
    public interface IS3BucketAnalyticsConfigurationStorageClassAnalysis
    {
        /// <summary>data_export block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration#data_export S3BucketAnalyticsConfiguration#data_export}
        /// </remarks>
        [JsiiProperty(name: "dataExport", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport\"}")]
        aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport DataExport
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketAnalyticsConfigurationStorageClassAnalysis), fullyQualifiedName: "aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysis")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysis
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>data_export block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration#data_export S3BucketAnalyticsConfiguration#data_export}
            /// </remarks>
            [JsiiProperty(name: "dataExport", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport\"}")]
            public aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport DataExport
            {
                get => GetInstanceProperty<aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport>()!;
            }
        }
    }
}
