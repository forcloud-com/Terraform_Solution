using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessorsParameters")]
    public class KinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessorsParameters : aws.Kinesis.IKinesisFirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationProcessorsParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#parameter_name KinesisFirehoseDeliveryStream#parameter_name}.</summary>
        [JsiiProperty(name: "parameterName", typeJson: "{\"primitive\":\"string\"}")]
        public string ParameterName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#parameter_value KinesisFirehoseDeliveryStream#parameter_value}.</summary>
        [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}")]
        public string ParameterValue
        {
            get;
            set;
        }
    }
}
