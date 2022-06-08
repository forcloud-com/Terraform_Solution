using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    [JsiiInterface(nativeType: typeof(IVpcPeeringConnectionRequester), fullyQualifiedName: "aws.vpc.VpcPeeringConnectionRequester")]
    public interface IVpcPeeringConnectionRequester
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#allow_classic_link_to_remote_vpc VpcPeeringConnection#allow_classic_link_to_remote_vpc}.</summary>
        [JsiiProperty(name: "allowClassicLinkToRemoteVpc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowClassicLinkToRemoteVpc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#allow_remote_vpc_dns_resolution VpcPeeringConnection#allow_remote_vpc_dns_resolution}.</summary>
        [JsiiProperty(name: "allowRemoteVpcDnsResolution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowRemoteVpcDnsResolution
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#allow_vpc_to_remote_classic_link VpcPeeringConnection#allow_vpc_to_remote_classic_link}.</summary>
        [JsiiProperty(name: "allowVpcToRemoteClassicLink", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowVpcToRemoteClassicLink
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcPeeringConnectionRequester), fullyQualifiedName: "aws.vpc.VpcPeeringConnectionRequester")]
        internal sealed class _Proxy : DeputyBase, aws.Vpc.IVpcPeeringConnectionRequester
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#allow_classic_link_to_remote_vpc VpcPeeringConnection#allow_classic_link_to_remote_vpc}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowClassicLinkToRemoteVpc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowClassicLinkToRemoteVpc
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#allow_remote_vpc_dns_resolution VpcPeeringConnection#allow_remote_vpc_dns_resolution}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowRemoteVpcDnsResolution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowRemoteVpcDnsResolution
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#allow_vpc_to_remote_classic_link VpcPeeringConnection#allow_vpc_to_remote_classic_link}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowVpcToRemoteClassicLink", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowVpcToRemoteClassicLink
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
