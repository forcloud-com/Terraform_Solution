using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(ILbSslNegotiationPolicyAttribute), fullyQualifiedName: "aws.elb.LbSslNegotiationPolicyAttribute")]
    public interface ILbSslNegotiationPolicyAttribute
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_ssl_negotiation_policy#name LbSslNegotiationPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_ssl_negotiation_policy#value LbSslNegotiationPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbSslNegotiationPolicyAttribute), fullyQualifiedName: "aws.elb.LbSslNegotiationPolicyAttribute")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.ILbSslNegotiationPolicyAttribute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_ssl_negotiation_policy#name LbSslNegotiationPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_ssl_negotiation_policy#value LbSslNegotiationPolicy#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
