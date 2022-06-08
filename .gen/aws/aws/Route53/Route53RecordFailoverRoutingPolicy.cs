using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53.Route53RecordFailoverRoutingPolicy")]
    public class Route53RecordFailoverRoutingPolicy : aws.Route53.IRoute53RecordFailoverRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#type Route53Record#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
