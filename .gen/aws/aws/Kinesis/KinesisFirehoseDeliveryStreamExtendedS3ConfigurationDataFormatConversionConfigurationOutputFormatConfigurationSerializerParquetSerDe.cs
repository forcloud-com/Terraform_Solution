using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe")]
    public class KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe : aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDe
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#block_size_bytes KinesisFirehoseDeliveryStream#block_size_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BlockSizeBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#compression KinesisFirehoseDeliveryStream#compression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Compression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#enable_dictionary_compression KinesisFirehoseDeliveryStream#enable_dictionary_compression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableDictionaryCompression", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableDictionaryCompression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#max_padding_bytes KinesisFirehoseDeliveryStream#max_padding_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPaddingBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPaddingBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#page_size_bytes KinesisFirehoseDeliveryStream#page_size_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pageSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PageSizeBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#writer_version KinesisFirehoseDeliveryStream#writer_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "writerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WriterVersion
        {
            get;
            set;
        }
    }
}
