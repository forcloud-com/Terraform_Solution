using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiByValue(fqn: "aws.elb.LbListenerRuleConditionPathPattern")]
    public class LbListenerRuleConditionPathPattern : aws.Elb.ILbListenerRuleConditionPathPattern
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#values LbListenerRule#values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
