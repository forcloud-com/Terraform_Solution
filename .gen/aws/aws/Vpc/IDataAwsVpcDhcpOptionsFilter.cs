using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    [JsiiInterface(nativeType: typeof(IDataAwsVpcDhcpOptionsFilter), fullyQualifiedName: "aws.vpc.DataAwsVpcDhcpOptionsFilter")]
    public interface IDataAwsVpcDhcpOptionsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_dhcp_options#name DataAwsVpcDhcpOptions#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_dhcp_options#values DataAwsVpcDhcpOptions#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsVpcDhcpOptionsFilter), fullyQualifiedName: "aws.vpc.DataAwsVpcDhcpOptionsFilter")]
        internal sealed class _Proxy : DeputyBase, aws.Vpc.IDataAwsVpcDhcpOptionsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_dhcp_options#name DataAwsVpcDhcpOptions#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_dhcp_options#values DataAwsVpcDhcpOptions#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
