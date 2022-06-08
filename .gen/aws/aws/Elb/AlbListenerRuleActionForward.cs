using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.AlbListenerRuleActionForward")]
    public class AlbListenerRuleActionForward : aws.Elb.IAlbListenerRuleActionForward
    {
        /// <summary>target_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#target_group AlbListenerRule#target_group}
        /// </remarks>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.AlbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}]}}")]
        public object TargetGroup
        {
            get;
            set;
        }

        /// <summary>stickiness block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#stickiness AlbListenerRule#stickiness}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionForwardStickiness\"}", isOptional: true)]
        public aws.Elb.IAlbListenerRuleActionForwardStickiness? Stickiness
        {
            get;
            set;
        }
    }
}
