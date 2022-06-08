using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleActionForward), fullyQualifiedName: "aws.elb.AlbListenerRuleActionForward")]
    public interface IAlbListenerRuleActionForward
    {
        /// <summary>target_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#target_group AlbListenerRule#target_group}
        /// </remarks>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.AlbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}")]
        object TargetGroup
        {
            get;
        }

        /// <summary>stickiness block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#stickiness AlbListenerRule#stickiness}
        /// </remarks>
        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionForwardStickiness\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerRuleActionForwardStickiness? Stickiness
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleActionForward), fullyQualifiedName: "aws.elb.AlbListenerRuleActionForward")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.IAlbListenerRuleActionForward
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#target_group AlbListenerRule#target_group}
            /// </remarks>
            [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.AlbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}")]
            public object TargetGroup
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>stickiness block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#stickiness AlbListenerRule#stickiness}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionForwardStickiness\"}", isOptional: true)]
            public aws.Elb.IAlbListenerRuleActionForwardStickiness? Stickiness
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerRuleActionForwardStickiness?>();
            }
        }
    }
}
