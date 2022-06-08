using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters")]
    public class KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters : aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters
    {
        /// <summary>csv block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#csv KinesisAnalyticsApplication#csv}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "csv", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv\"}", isOptional: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv? Csv
        {
            get;
            set;
        }

        /// <summary>json block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#json KinesisAnalyticsApplication#json}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "json", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson\"}", isOptional: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson? Json
        {
            get;
            set;
        }
    }
}
