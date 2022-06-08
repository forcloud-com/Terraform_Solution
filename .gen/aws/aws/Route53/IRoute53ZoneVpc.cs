using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    [JsiiInterface(nativeType: typeof(IRoute53ZoneVpc), fullyQualifiedName: "aws.route53.Route53ZoneVpc")]
    public interface IRoute53ZoneVpc
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_zone#vpc_id Route53Zone#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_zone#vpc_region Route53Zone#vpc_region}.</summary>
        [JsiiProperty(name: "vpcRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcRegion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53ZoneVpc), fullyQualifiedName: "aws.route53.Route53ZoneVpc")]
        internal sealed class _Proxy : DeputyBase, aws.Route53.IRoute53ZoneVpc
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_zone#vpc_id Route53Zone#vpc_id}.</summary>
            [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_zone#vpc_region Route53Zone#vpc_region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcRegion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
