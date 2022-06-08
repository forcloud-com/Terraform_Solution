using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson : aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_row_path KinesisAnalyticsApplication#record_row_path}.</summary>
        [JsiiProperty(name: "recordRowPath", typeJson: "{\"primitive\":\"string\"}")]
        public string RecordRowPath
        {
            get;
            set;
        }
    }
}
