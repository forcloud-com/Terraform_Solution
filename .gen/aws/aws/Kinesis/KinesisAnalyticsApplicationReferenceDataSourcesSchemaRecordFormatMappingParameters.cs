using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters : aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters
    {
        /// <summary>csv block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#csv KinesisAnalyticsApplication#csv}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "csv", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv\"}", isOptional: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv? Csv
        {
            get;
            set;
        }

        /// <summary>json block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#json KinesisAnalyticsApplication#json}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "json", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson\"}", isOptional: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson? Json
        {
            get;
            set;
        }
    }
}
