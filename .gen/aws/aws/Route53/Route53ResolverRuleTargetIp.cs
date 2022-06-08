using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53.Route53ResolverRuleTargetIp")]
    public class Route53ResolverRuleTargetIp : aws.Route53.IRoute53ResolverRuleTargetIp
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_rule#ip Route53ResolverRule#ip}.</summary>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        public string Ip
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_rule#port Route53ResolverRule#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }
    }
}
