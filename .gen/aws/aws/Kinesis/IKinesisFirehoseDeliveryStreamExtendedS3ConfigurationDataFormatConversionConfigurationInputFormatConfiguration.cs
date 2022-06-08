using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration")]
    public interface IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration
    {
        /// <summary>deserializer block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#deserializer KinesisFirehoseDeliveryStream#deserializer}
        /// </remarks>
        [JsiiProperty(name: "deserializer", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializer\"}")]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializer Deserializer
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>deserializer block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#deserializer KinesisFirehoseDeliveryStream#deserializer}
            /// </remarks>
            [JsiiProperty(name: "deserializer", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializer\"}")]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializer Deserializer
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfigurationDeserializer>()!;
            }
        }
    }
}
