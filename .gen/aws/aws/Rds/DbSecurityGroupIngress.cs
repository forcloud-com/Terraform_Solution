using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    [JsiiByValue(fqn: "aws.rds.DbSecurityGroupIngress")]
    public class DbSecurityGroupIngress : aws.Rds.IDbSecurityGroupIngress
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_security_group#cidr DbSecurityGroup#cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cidr
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_security_group#security_group_id DbSecurityGroup#security_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_security_group#security_group_name DbSecurityGroup#security_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_security_group#security_group_owner_id DbSecurityGroup#security_group_owner_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupOwnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityGroupOwnerId
        {
            get;
            set;
        }
    }
}
