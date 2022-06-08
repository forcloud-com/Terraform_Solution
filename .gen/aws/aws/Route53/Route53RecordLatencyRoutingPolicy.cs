using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53.Route53RecordLatencyRoutingPolicy")]
    public class Route53RecordLatencyRoutingPolicy : aws.Route53.IRoute53RecordLatencyRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#region Route53Record#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }
    }
}
