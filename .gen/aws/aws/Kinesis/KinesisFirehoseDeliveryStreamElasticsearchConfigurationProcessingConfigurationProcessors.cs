using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors")]
    public class KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors : aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessors
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#type KinesisFirehoseDeliveryStream#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#parameters KinesisFirehoseDeliveryStream#parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessorsParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Parameters
        {
            get;
            set;
        }
    }
}
