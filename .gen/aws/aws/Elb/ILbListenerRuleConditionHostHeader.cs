using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleConditionHostHeader), fullyQualifiedName: "aws.elb.LbListenerRuleConditionHostHeader")]
    public interface ILbListenerRuleConditionHostHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#values LbListenerRule#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Values
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleConditionHostHeader), fullyQualifiedName: "aws.elb.LbListenerRuleConditionHostHeader")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.ILbListenerRuleConditionHostHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#values LbListenerRule#values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Values
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
