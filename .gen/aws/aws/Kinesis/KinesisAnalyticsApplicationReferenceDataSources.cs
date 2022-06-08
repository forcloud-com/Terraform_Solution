using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSources")]
    public class KinesisAnalyticsApplicationReferenceDataSources : aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSources
    {
        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#s3 KinesisAnalyticsApplication#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesS3\"}")]
        public aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesS3 S3
        {
            get;
            set;
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#schema KinesisAnalyticsApplication#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchema\"}")]
        public aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchema Schema
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#table_name KinesisAnalyticsApplication#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public string TableName
        {
            get;
            set;
        }
    }
}
