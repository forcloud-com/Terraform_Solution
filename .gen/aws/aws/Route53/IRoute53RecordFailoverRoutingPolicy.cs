using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordFailoverRoutingPolicy), fullyQualifiedName: "aws.route53.Route53RecordFailoverRoutingPolicy")]
    public interface IRoute53RecordFailoverRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#type Route53Record#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordFailoverRoutingPolicy), fullyQualifiedName: "aws.route53.Route53RecordFailoverRoutingPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Route53.IRoute53RecordFailoverRoutingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#type Route53Record#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
