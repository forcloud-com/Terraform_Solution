using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Redshift
{
    [JsiiByValue(fqn: "aws.redshift.RedshiftSecurityGroupIngress")]
    public class RedshiftSecurityGroupIngress : aws.Redshift.IRedshiftSecurityGroupIngress
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_security_group#cidr RedshiftSecurityGroup#cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cidr
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_security_group#security_group_name RedshiftSecurityGroup#security_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_security_group#security_group_owner_id RedshiftSecurityGroup#security_group_owner_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupOwnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityGroupOwnerId
        {
            get;
            set;
        }
    }
}
