using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer")]
    public interface IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer
    {
        /// <summary>orc_ser_de block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#orc_ser_de KinesisFirehoseDeliveryStream#orc_ser_de}
        /// </remarks>
        [JsiiProperty(name: "orcSerDe", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe? OrcSerDe
        {
            get
            {
                return null;
            }
        }

        /// <summary>parquet_ser_de block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#parquet_ser_de KinesisFirehoseDeliveryStream#parquet_ser_de}
        /// </remarks>
        [JsiiProperty(name: "parquetSerDe", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe? ParquetSerDe
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>orc_ser_de block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#orc_ser_de KinesisFirehoseDeliveryStream#orc_ser_de}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orcSerDe", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe? OrcSerDe
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerOrcSerDe?>();
            }

            /// <summary>parquet_ser_de block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#parquet_ser_de KinesisFirehoseDeliveryStream#parquet_ser_de}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parquetSerDe", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe\"}", isOptional: true)]
            public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe? ParquetSerDe
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe?>();
            }
        }
    }
}
