using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetKinesisTarget), fullyQualifiedName: "aws.eventbridge.CloudwatchEventTargetKinesisTarget")]
    public interface ICloudwatchEventTargetKinesisTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#partition_key_path CloudwatchEventTarget#partition_key_path}.</summary>
        [JsiiProperty(name: "partitionKeyPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PartitionKeyPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetKinesisTarget), fullyQualifiedName: "aws.eventbridge.CloudwatchEventTargetKinesisTarget")]
        internal sealed class _Proxy : DeputyBase, aws.Eventbridge.ICloudwatchEventTargetKinesisTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#partition_key_path CloudwatchEventTarget#partition_key_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "partitionKeyPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PartitionKeyPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
