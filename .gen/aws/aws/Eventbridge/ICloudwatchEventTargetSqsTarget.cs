using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetSqsTarget), fullyQualifiedName: "aws.eventbridge.CloudwatchEventTargetSqsTarget")]
    public interface ICloudwatchEventTargetSqsTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#message_group_id CloudwatchEventTarget#message_group_id}.</summary>
        [JsiiProperty(name: "messageGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageGroupId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetSqsTarget), fullyQualifiedName: "aws.eventbridge.CloudwatchEventTargetSqsTarget")]
        internal sealed class _Proxy : DeputyBase, aws.Eventbridge.ICloudwatchEventTargetSqsTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#message_group_id CloudwatchEventTarget#message_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageGroupId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
