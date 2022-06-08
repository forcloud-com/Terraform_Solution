using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionIotEvents), fullyQualifiedName: "aws.iot.IotTopicRuleErrorActionIotEvents")]
    public interface IIotTopicRuleErrorActionIotEvents
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#input_name IotTopicRule#input_name}.</summary>
        [JsiiProperty(name: "inputName", typeJson: "{\"primitive\":\"string\"}")]
        string InputName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#message_id IotTopicRule#message_id}.</summary>
        [JsiiProperty(name: "messageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionIotEvents), fullyQualifiedName: "aws.iot.IotTopicRuleErrorActionIotEvents")]
        internal sealed class _Proxy : DeputyBase, aws.Iot.IIotTopicRuleErrorActionIotEvents
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#input_name IotTopicRule#input_name}.</summary>
            [JsiiProperty(name: "inputName", typeJson: "{\"primitive\":\"string\"}")]
            public string InputName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#message_id IotTopicRule#message_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
