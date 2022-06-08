using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleConditionHttpHeader), fullyQualifiedName: "aws.elb.AlbListenerRuleConditionHttpHeader")]
    public interface IAlbListenerRuleConditionHttpHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#http_header_name AlbListenerRule#http_header_name}.</summary>
        [JsiiProperty(name: "httpHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        string HttpHeaderName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#values AlbListenerRule#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleConditionHttpHeader), fullyQualifiedName: "aws.elb.AlbListenerRuleConditionHttpHeader")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.IAlbListenerRuleConditionHttpHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#http_header_name AlbListenerRule#http_header_name}.</summary>
            [JsiiProperty(name: "httpHeaderName", typeJson: "{\"primitive\":\"string\"}")]
            public string HttpHeaderName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#values AlbListenerRule#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
