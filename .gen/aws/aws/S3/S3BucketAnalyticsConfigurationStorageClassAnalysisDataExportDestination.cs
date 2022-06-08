using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination")]
    public class S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination : aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination
    {
        /// <summary>s3_bucket_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration#s3_bucket_destination S3BucketAnalyticsConfiguration#s3_bucket_destination}
        /// </remarks>
        [JsiiProperty(name: "s3BucketDestination", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination\"}")]
        public aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination S3BucketDestination
        {
            get;
            set;
        }
    }
}
