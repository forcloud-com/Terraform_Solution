using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53.Route53ResolverEndpointIpAddress")]
    public class Route53ResolverEndpointIpAddress : aws.Route53.IRoute53ResolverEndpointIpAddress
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_endpoint#subnet_id Route53ResolverEndpoint#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_endpoint#ip Route53ResolverEndpoint#ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ip
        {
            get;
            set;
        }
    }
}
