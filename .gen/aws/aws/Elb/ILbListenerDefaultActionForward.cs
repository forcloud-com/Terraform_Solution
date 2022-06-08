using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(ILbListenerDefaultActionForward), fullyQualifiedName: "aws.elb.LbListenerDefaultActionForward")]
    public interface ILbListenerDefaultActionForward
    {
        /// <summary>target_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#target_group LbListener#target_group}
        /// </remarks>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}")]
        object TargetGroup
        {
            get;
        }

        /// <summary>stickiness block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#stickiness LbListener#stickiness}
        /// </remarks>
        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionForwardStickiness\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerDefaultActionForwardStickiness? Stickiness
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbListenerDefaultActionForward), fullyQualifiedName: "aws.elb.LbListenerDefaultActionForward")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.ILbListenerDefaultActionForward
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#target_group LbListener#target_group}
            /// </remarks>
            [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}")]
            public object TargetGroup
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>stickiness block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#stickiness LbListener#stickiness}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionForwardStickiness\"}", isOptional: true)]
            public aws.Elb.ILbListenerDefaultActionForwardStickiness? Stickiness
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerDefaultActionForwardStickiness?>();
            }
        }
    }
}
