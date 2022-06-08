using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationOutputsSchema")]
    public class KinesisAnalyticsApplicationOutputsSchema : aws.Kinesis.IKinesisAnalyticsApplicationOutputsSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_format_type KinesisAnalyticsApplication#record_format_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recordFormatType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecordFormatType
        {
            get;
            set;
        }
    }
}
