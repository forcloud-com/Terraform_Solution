using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiByValue(fqn: "aws.eks.EksNodeGroupRemoteAccess")]
    public class EksNodeGroupRemoteAccess : aws.Eks.IEksNodeGroupRemoteAccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#ec2_ssh_key EksNodeGroup#ec2_ssh_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ec2SshKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ec2SshKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#source_security_group_ids EksNodeGroup#source_security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SourceSecurityGroupIds
        {
            get;
            set;
        }
    }
}
