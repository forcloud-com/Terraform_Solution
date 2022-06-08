using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessorsParameters), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessorsParameters")]
    public interface IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessorsParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#parameter_name KinesisFirehoseDeliveryStream#parameter_name}.</summary>
        [JsiiProperty(name: "parameterName", typeJson: "{\"primitive\":\"string\"}")]
        string ParameterName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#parameter_value KinesisFirehoseDeliveryStream#parameter_value}.</summary>
        [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}")]
        string ParameterValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessorsParameters), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessorsParameters")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisFirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessorsParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#parameter_name KinesisFirehoseDeliveryStream#parameter_name}.</summary>
            [JsiiProperty(name: "parameterName", typeJson: "{\"primitive\":\"string\"}")]
            public string ParameterName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#parameter_value KinesisFirehoseDeliveryStream#parameter_value}.</summary>
            [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}")]
            public string ParameterValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
