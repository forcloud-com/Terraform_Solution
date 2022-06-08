using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesS3")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesS3 : aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#bucket_arn KinesisAnalyticsApplication#bucket_arn}.</summary>
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#file_key KinesisAnalyticsApplication#file_key}.</summary>
        [JsiiProperty(name: "fileKey", typeJson: "{\"primitive\":\"string\"}")]
        public string FileKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#role_arn KinesisAnalyticsApplication#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }
    }
}
