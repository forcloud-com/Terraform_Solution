using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    [JsiiByValue(fqn: "aws.vpc.VpcIpv4CidrBlockAssociationTimeouts")]
    public class VpcIpv4CidrBlockAssociationTimeouts : aws.Vpc.IVpcIpv4CidrBlockAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipv4_cidr_block_association#create VpcIpv4CidrBlockAssociation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipv4_cidr_block_association#delete VpcIpv4CidrBlockAssociation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
