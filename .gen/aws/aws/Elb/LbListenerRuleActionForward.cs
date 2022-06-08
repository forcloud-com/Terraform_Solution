using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.LbListenerRuleActionForward")]
    public class LbListenerRuleActionForward : aws.Elb.ILbListenerRuleActionForward
    {
        /// <summary>target_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#target_group LbListenerRule#target_group}
        /// </remarks>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}")]
        public object TargetGroup
        {
            get;
            set;
        }

        /// <summary>stickiness block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#stickiness LbListenerRule#stickiness}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionForwardStickiness\"}", isOptional: true)]
        public aws.Elb.ILbListenerRuleActionForwardStickiness? Stickiness
        {
            get;
            set;
        }
    }
}
