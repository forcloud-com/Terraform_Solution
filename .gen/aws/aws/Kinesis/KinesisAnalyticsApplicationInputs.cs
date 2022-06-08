using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationInputs")]
    public class KinesisAnalyticsApplicationInputs : aws.Kinesis.IKinesisAnalyticsApplicationInputs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#name_prefix KinesisAnalyticsApplication#name_prefix}.</summary>
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public string NamePrefix
        {
            get;
            set;
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#schema KinesisAnalyticsApplication#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchema\"}")]
        public aws.Kinesis.IKinesisAnalyticsApplicationInputsSchema Schema
        {
            get;
            set;
        }

        /// <summary>kinesis_firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#kinesis_firehose KinesisAnalyticsApplication#kinesis_firehose}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsKinesisFirehose\"}", isOptional: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisFirehose? KinesisFirehose
        {
            get;
            set;
        }

        /// <summary>kinesis_stream block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#kinesis_stream KinesisAnalyticsApplication#kinesis_stream}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisStream", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsKinesisStream\"}", isOptional: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisStream? KinesisStream
        {
            get;
            set;
        }

        /// <summary>parallelism block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#parallelism KinesisAnalyticsApplication#parallelism}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parallelism", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsParallelism\"}", isOptional: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationInputsParallelism? Parallelism
        {
            get;
            set;
        }

        /// <summary>processing_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#processing_configuration KinesisAnalyticsApplication#processing_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfiguration\"}", isOptional: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfiguration? ProcessingConfiguration
        {
            get;
            set;
        }
    }
}
