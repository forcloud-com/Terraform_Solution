using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpc.DataAwsVpcDhcpOptionsFilter")]
    public class DataAwsVpcDhcpOptionsFilter : aws.Vpc.IDataAwsVpcDhcpOptionsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_dhcp_options#name DataAwsVpcDhcpOptions#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_dhcp_options#values DataAwsVpcDhcpOptions#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
