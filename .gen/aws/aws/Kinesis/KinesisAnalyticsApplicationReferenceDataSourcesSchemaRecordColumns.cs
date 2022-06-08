using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns : aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#name KinesisAnalyticsApplication#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#sql_type KinesisAnalyticsApplication#sql_type}.</summary>
        [JsiiProperty(name: "sqlType", typeJson: "{\"primitive\":\"string\"}")]
        public string SqlType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#mapping KinesisAnalyticsApplication#mapping}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mapping", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mapping
        {
            get;
            set;
        }
    }
}
