using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eks.EksClusterVpcConfig")]
    public class EksClusterVpcConfig : aws.Eks.IEksClusterVpcConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#subnet_ids EksCluster#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SubnetIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#endpoint_private_access EksCluster#endpoint_private_access}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointPrivateAccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EndpointPrivateAccess
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#endpoint_public_access EksCluster#endpoint_public_access}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointPublicAccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EndpointPublicAccess
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#public_access_cidrs EksCluster#public_access_cidrs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicAccessCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PublicAccessCidrs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#security_group_ids EksCluster#security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroupIds
        {
            get;
            set;
        }
    }
}
