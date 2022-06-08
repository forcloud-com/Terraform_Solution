using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    [JsiiInterface(nativeType: typeof(IRoute53ResolverEndpointIpAddress), fullyQualifiedName: "aws.route53.Route53ResolverEndpointIpAddress")]
    public interface IRoute53ResolverEndpointIpAddress
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_endpoint#subnet_id Route53ResolverEndpoint#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_endpoint#ip Route53ResolverEndpoint#ip}.</summary>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ip
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53ResolverEndpointIpAddress), fullyQualifiedName: "aws.route53.Route53ResolverEndpointIpAddress")]
        internal sealed class _Proxy : DeputyBase, aws.Route53.IRoute53ResolverEndpointIpAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_endpoint#subnet_id Route53ResolverEndpoint#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_endpoint#ip Route53ResolverEndpoint#ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ip
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
