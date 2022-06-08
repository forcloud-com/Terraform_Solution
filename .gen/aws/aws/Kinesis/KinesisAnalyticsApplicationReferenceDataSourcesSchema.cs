using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchema")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesSchema : aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchema
    {
        /// <summary>record_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_columns KinesisAnalyticsApplication#record_columns}
        /// </remarks>
        [JsiiProperty(name: "recordColumns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns\"},\"kind\":\"array\"}}]}}")]
        public object RecordColumns
        {
            get;
            set;
        }

        /// <summary>record_format block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_format KinesisAnalyticsApplication#record_format}
        /// </remarks>
        [JsiiProperty(name: "recordFormat", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat\"}")]
        public aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat RecordFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_encoding KinesisAnalyticsApplication#record_encoding}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recordEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecordEncoding
        {
            get;
            set;
        }
    }
}
