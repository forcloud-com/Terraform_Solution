using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleConditionHttpHeader), fullyQualifiedName: "aws.elb.LbListenerRuleConditionHttpHeader")]
    public interface ILbListenerRuleConditionHttpHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#http_header_name LbListenerRule#http_header_name}.</summary>
        [JsiiProperty(name: "httpHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        string HttpHeaderName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#values LbListenerRule#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleConditionHttpHeader), fullyQualifiedName: "aws.elb.LbListenerRuleConditionHttpHeader")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.ILbListenerRuleConditionHttpHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#http_header_name LbListenerRule#http_header_name}.</summary>
            [JsiiProperty(name: "httpHeaderName", typeJson: "{\"primitive\":\"string\"}")]
            public string HttpHeaderName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#values LbListenerRule#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
