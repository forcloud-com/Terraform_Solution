using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleConditionHttpRequestMethod), fullyQualifiedName: "aws.elb.AlbListenerRuleConditionHttpRequestMethod")]
    public interface IAlbListenerRuleConditionHttpRequestMethod
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#values AlbListenerRule#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleConditionHttpRequestMethod), fullyQualifiedName: "aws.elb.AlbListenerRuleConditionHttpRequestMethod")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.IAlbListenerRuleConditionHttpRequestMethod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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
