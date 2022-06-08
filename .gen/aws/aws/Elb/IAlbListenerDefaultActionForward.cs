using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(IAlbListenerDefaultActionForward), fullyQualifiedName: "aws.elb.AlbListenerDefaultActionForward")]
    public interface IAlbListenerDefaultActionForward
    {
        /// <summary>target_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#target_group AlbListener#target_group}
        /// </remarks>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.AlbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}")]
        object TargetGroup
        {
            get;
        }

        /// <summary>stickiness block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#stickiness AlbListener#stickiness}
        /// </remarks>
        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionForwardStickiness\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerDefaultActionForwardStickiness? Stickiness
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerDefaultActionForward), fullyQualifiedName: "aws.elb.AlbListenerDefaultActionForward")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.IAlbListenerDefaultActionForward
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#target_group AlbListener#target_group}
            /// </remarks>
            [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.AlbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}")]
            public object TargetGroup
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>stickiness block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#stickiness AlbListener#stickiness}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionForwardStickiness\"}", isOptional: true)]
            public aws.Elb.IAlbListenerDefaultActionForwardStickiness? Stickiness
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerDefaultActionForwardStickiness?>();
            }
        }
    }
}
