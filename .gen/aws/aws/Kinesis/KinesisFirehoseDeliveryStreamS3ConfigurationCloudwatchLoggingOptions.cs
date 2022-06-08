using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions")]
    public class KinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions : aws.Kinesis.IKinesisFirehoseDeliveryStreamS3ConfigurationCloudwatchLoggingOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#enabled KinesisFirehoseDeliveryStream#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#log_group_name KinesisFirehoseDeliveryStream#log_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#log_stream_name KinesisFirehoseDeliveryStream#log_stream_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logStreamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogStreamName
        {
            get;
            set;
        }
    }
}
