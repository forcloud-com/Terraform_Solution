using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysis")]
    public class S3BucketAnalyticsConfigurationStorageClassAnalysis : aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysis
    {
        /// <summary>data_export block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration#data_export S3BucketAnalyticsConfiguration#data_export}
        /// </remarks>
        [JsiiProperty(name: "dataExport", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport\"}")]
        public aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport DataExport
        {
            get;
            set;
        }
    }
}
