using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration")]
    public class KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration : aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#enabled KinesisFirehoseDeliveryStream#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get;
            set;
        }

        /// <summary>processors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#processors KinesisFirehoseDeliveryStream#processors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processors", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessors\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Processors
        {
            get;
            set;
        }
    }
}
