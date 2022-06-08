using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv : aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_column_delimiter KinesisAnalyticsApplication#record_column_delimiter}.</summary>
        [JsiiProperty(name: "recordColumnDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        public string RecordColumnDelimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_row_delimiter KinesisAnalyticsApplication#record_row_delimiter}.</summary>
        [JsiiProperty(name: "recordRowDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        public string RecordRowDelimiter
        {
            get;
            set;
        }
    }
}
