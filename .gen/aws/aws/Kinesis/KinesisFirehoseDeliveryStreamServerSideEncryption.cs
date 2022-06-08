using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamServerSideEncryption")]
    public class KinesisFirehoseDeliveryStreamServerSideEncryption : aws.Kinesis.IKinesisFirehoseDeliveryStreamServerSideEncryption
    {
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
