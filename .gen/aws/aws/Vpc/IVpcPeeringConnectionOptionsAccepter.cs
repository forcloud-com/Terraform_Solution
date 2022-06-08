using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    [JsiiInterface(nativeType: typeof(IVpcPeeringConnectionOptionsAccepter), fullyQualifiedName: "aws.vpc.VpcPeeringConnectionOptionsAccepter")]
    public interface IVpcPeeringConnectionOptionsAccepter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_options#allow_classic_link_to_remote_vpc VpcPeeringConnectionOptions#allow_classic_link_to_remote_vpc}.</summary>
        [JsiiProperty(name: "allowClassicLinkToRemoteVpc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowClassicLinkToRemoteVpc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_options#allow_remote_vpc_dns_resolution VpcPeeringConnectionOptions#allow_remote_vpc_dns_resolution}.</summary>
        [JsiiProperty(name: "allowRemoteVpcDnsResolution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowRemoteVpcDnsResolution
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_options#allow_vpc_to_remote_classic_link VpcPeeringConnectionOptions#allow_vpc_to_remote_classic_link}.</summary>
        [JsiiProperty(name: "allowVpcToRemoteClassicLink", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowVpcToRemoteClassicLink
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcPeeringConnectionOptionsAccepter), fullyQualifiedName: "aws.vpc.VpcPeeringConnectionOptionsAccepter")]
        internal sealed class _Proxy : DeputyBase, aws.Vpc.IVpcPeeringConnectionOptionsAccepter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_options#allow_classic_link_to_remote_vpc VpcPeeringConnectionOptions#allow_classic_link_to_remote_vpc}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowClassicLinkToRemoteVpc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowClassicLinkToRemoteVpc
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_options#allow_remote_vpc_dns_resolution VpcPeeringConnectionOptions#allow_remote_vpc_dns_resolution}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowRemoteVpcDnsResolution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowRemoteVpcDnsResolution
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_options#allow_vpc_to_remote_classic_link VpcPeeringConnectionOptions#allow_vpc_to_remote_classic_link}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowVpcToRemoteClassicLink", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowVpcToRemoteClassicLink
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
