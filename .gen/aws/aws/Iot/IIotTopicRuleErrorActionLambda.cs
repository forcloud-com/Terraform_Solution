using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionLambda), fullyQualifiedName: "aws.iot.IotTopicRuleErrorActionLambda")]
    public interface IIotTopicRuleErrorActionLambda
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#function_arn IotTopicRule#function_arn}.</summary>
        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionLambda), fullyQualifiedName: "aws.iot.IotTopicRuleErrorActionLambda")]
        internal sealed class _Proxy : DeputyBase, aws.Iot.IIotTopicRuleErrorActionLambda
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#function_arn IotTopicRule#function_arn}.</summary>
            [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
