using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(ILbListenerRuleActionForward), fullyQualifiedName: "aws.elb.LbListenerRuleActionForward")]
    public interface ILbListenerRuleActionForward
    {
        /// <summary>target_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#target_group LbListenerRule#target_group}
        /// </remarks>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}")]
        object TargetGroup
        {
            get;
        }

        /// <summary>stickiness block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#stickiness LbListenerRule#stickiness}
        /// </remarks>
        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionForwardStickiness\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerRuleActionForwardStickiness? Stickiness
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerRuleActionForward), fullyQualifiedName: "aws.elb.LbListenerRuleActionForward")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.ILbListenerRuleActionForward
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#target_group LbListenerRule#target_group}
            /// </remarks>
            [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}")]
            public object TargetGroup
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>stickiness block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#stickiness LbListenerRule#stickiness}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionForwardStickiness\"}", isOptional: true)]
            public aws.Elb.ILbListenerRuleActionForwardStickiness? Stickiness
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerRuleActionForwardStickiness?>();
            }
        }
    }
}
