using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration")]
    public class KinesisFirehoseDeliveryStreamKinesisSourceConfiguration : aws.Kinesis.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#kinesis_stream_arn KinesisFirehoseDeliveryStream#kinesis_stream_arn}.</summary>
        [JsiiProperty(name: "kinesisStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        public string KinesisStreamArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#role_arn KinesisFirehoseDeliveryStream#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }
    }
}
