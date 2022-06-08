using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.AlbListenerRuleActionForwardTargetGroup")]
    public class AlbListenerRuleActionForwardTargetGroup : aws.Elb.IAlbListenerRuleActionForwardTargetGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#arn AlbListenerRule#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public string Arn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#weight AlbListenerRule#weight}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Weight
        {
            get;
            set;
        }
    }
}
