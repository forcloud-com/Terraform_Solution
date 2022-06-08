using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    [JsiiInterface(nativeType: typeof(IRoute53ResolverRuleTargetIp), fullyQualifiedName: "aws.route53.Route53ResolverRuleTargetIp")]
    public interface IRoute53ResolverRuleTargetIp
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_rule#ip Route53ResolverRule#ip}.</summary>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        string Ip
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_rule#port Route53ResolverRule#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53ResolverRuleTargetIp), fullyQualifiedName: "aws.route53.Route53ResolverRuleTargetIp")]
        internal sealed class _Proxy : DeputyBase, aws.Route53.IRoute53ResolverRuleTargetIp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_rule#ip Route53ResolverRule#ip}.</summary>
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
            public string Ip
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_resolver_rule#port Route53ResolverRule#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
