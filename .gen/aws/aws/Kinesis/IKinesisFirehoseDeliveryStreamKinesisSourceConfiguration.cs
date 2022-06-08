using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration")]
    public interface IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#kinesis_stream_arn KinesisFirehoseDeliveryStream#kinesis_stream_arn}.</summary>
        [JsiiProperty(name: "kinesisStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        string KinesisStreamArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#role_arn KinesisFirehoseDeliveryStream#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration), fullyQualifiedName: "aws.kinesis.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#kinesis_stream_arn KinesisFirehoseDeliveryStream#kinesis_stream_arn}.</summary>
            [JsiiProperty(name: "kinesisStreamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string KinesisStreamArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_firehose_delivery_stream#role_arn KinesisFirehoseDeliveryStream#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
