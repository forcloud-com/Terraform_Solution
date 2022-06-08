using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.LbListenerRuleActionFixedResponse")]
    public class LbListenerRuleActionFixedResponse : aws.Elb.ILbListenerRuleActionFixedResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#content_type LbListenerRule#content_type}.</summary>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        public string ContentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#message_body LbListenerRule#message_body}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageBody
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#status_code LbListenerRule#status_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StatusCode
        {
            get;
            set;
        }
    }
}
