using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationOutputs")]
    public class KinesisAnalyticsApplicationOutputs : aws.Kinesis.IKinesisAnalyticsApplicationOutputs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#name KinesisAnalyticsApplication#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#schema KinesisAnalyticsApplication#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputsSchema\"}")]
        public aws.Kinesis.IKinesisAnalyticsApplicationOutputsSchema Schema
        {
            get;
            set;
        }

        /// <summary>kinesis_firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#kinesis_firehose KinesisAnalyticsApplication#kinesis_firehose}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputsKinesisFirehose\"}", isOptional: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationOutputsKinesisFirehose? KinesisFirehose
        {
            get;
            set;
        }

        /// <summary>kinesis_stream block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#kinesis_stream KinesisAnalyticsApplication#kinesis_stream}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisStream", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputsKinesisStream\"}", isOptional: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationOutputsKinesisStream? KinesisStream
        {
            get;
            set;
        }

        /// <summary>lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#lambda KinesisAnalyticsApplication#lambda}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputsLambda\"}", isOptional: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationOutputsLambda? Lambda
        {
            get;
            set;
        }
    }
}
