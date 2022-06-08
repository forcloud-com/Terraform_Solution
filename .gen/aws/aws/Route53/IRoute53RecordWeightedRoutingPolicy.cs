using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordWeightedRoutingPolicy), fullyQualifiedName: "aws.route53.Route53RecordWeightedRoutingPolicy")]
    public interface IRoute53RecordWeightedRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#weight Route53Record#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        double Weight
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordWeightedRoutingPolicy), fullyQualifiedName: "aws.route53.Route53RecordWeightedRoutingPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Route53.IRoute53RecordWeightedRoutingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#weight Route53Record#weight}.</summary>
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
            public double Weight
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
