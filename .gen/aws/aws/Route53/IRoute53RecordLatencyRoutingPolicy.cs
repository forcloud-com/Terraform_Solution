using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    [JsiiInterface(nativeType: typeof(IRoute53RecordLatencyRoutingPolicy), fullyQualifiedName: "aws.route53.Route53RecordLatencyRoutingPolicy")]
    public interface IRoute53RecordLatencyRoutingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#region Route53Record#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordLatencyRoutingPolicy), fullyQualifiedName: "aws.route53.Route53RecordLatencyRoutingPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Route53.IRoute53RecordLatencyRoutingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#region Route53Record#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
