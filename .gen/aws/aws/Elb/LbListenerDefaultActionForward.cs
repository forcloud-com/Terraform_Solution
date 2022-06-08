using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.LbListenerDefaultActionForward")]
    public class LbListenerDefaultActionForward : aws.Elb.ILbListenerDefaultActionForward
    {
        /// <summary>target_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#target_group LbListener#target_group}
        /// </remarks>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}")]
        public object TargetGroup
        {
            get;
            set;
        }

        /// <summary>stickiness block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#stickiness LbListener#stickiness}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionForwardStickiness\"}", isOptional: true)]
        public aws.Elb.ILbListenerDefaultActionForwardStickiness? Stickiness
        {
            get;
            set;
        }
    }
}
