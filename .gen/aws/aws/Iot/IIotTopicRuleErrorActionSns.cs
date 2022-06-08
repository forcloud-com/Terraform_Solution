using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionSns), fullyQualifiedName: "aws.iot.IotTopicRuleErrorActionSns")]
    public interface IIotTopicRuleErrorActionSns
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#target_arn IotTopicRule#target_arn}.</summary>
        [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
        string TargetArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#message_format IotTopicRule#message_format}.</summary>
        [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageFormat
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionSns), fullyQualifiedName: "aws.iot.IotTopicRuleErrorActionSns")]
        internal sealed class _Proxy : DeputyBase, aws.Iot.IIotTopicRuleErrorActionSns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#role_arn IotTopicRule#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#target_arn IotTopicRule#target_arn}.</summary>
            [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#message_format IotTopicRule#message_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageFormat
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
