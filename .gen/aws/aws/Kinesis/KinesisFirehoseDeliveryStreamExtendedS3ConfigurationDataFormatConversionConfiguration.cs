using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration")]
    public class KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration : aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfiguration
    {
        /// <summary>input_format_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#input_format_configuration KinesisFirehoseDeliveryStream#input_format_configuration}
        /// </remarks>
        [JsiiProperty(name: "inputFormatConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration\"}")]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationInputFormatConfiguration InputFormatConfiguration
        {
            get;
            set;
        }

        /// <summary>output_format_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#output_format_configuration KinesisFirehoseDeliveryStream#output_format_configuration}
        /// </remarks>
        [JsiiProperty(name: "outputFormatConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfiguration\"}")]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfiguration OutputFormatConfiguration
        {
            get;
            set;
        }

        /// <summary>schema_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#schema_configuration KinesisFirehoseDeliveryStream#schema_configuration}
        /// </remarks>
        [JsiiProperty(name: "schemaConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfiguration\"}")]
        public aws.Kinesis.IKinesisFirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationSchemaConfiguration SchemaConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#enabled KinesisFirehoseDeliveryStream#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get;
            set;
        }
    }
}
