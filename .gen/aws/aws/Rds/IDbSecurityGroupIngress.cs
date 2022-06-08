using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    [JsiiInterface(nativeType: typeof(IDbSecurityGroupIngress), fullyQualifiedName: "aws.rds.DbSecurityGroupIngress")]
    public interface IDbSecurityGroupIngress
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_security_group#cidr DbSecurityGroup#cidr}.</summary>
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cidr
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_security_group#security_group_id DbSecurityGroup#security_group_id}.</summary>
        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_security_group#security_group_name DbSecurityGroup#security_group_name}.</summary>
        [JsiiProperty(name: "securityGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityGroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_security_group#security_group_owner_id DbSecurityGroup#security_group_owner_id}.</summary>
        [JsiiProperty(name: "securityGroupOwnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityGroupOwnerId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbSecurityGroupIngress), fullyQualifiedName: "aws.rds.DbSecurityGroupIngress")]
        internal sealed class _Proxy : DeputyBase, aws.Rds.IDbSecurityGroupIngress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_security_group#cidr DbSecurityGroup#cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cidr
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_security_group#security_group_id DbSecurityGroup#security_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_security_group#security_group_name DbSecurityGroup#security_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityGroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_security_group#security_group_owner_id DbSecurityGroup#security_group_owner_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupOwnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityGroupOwnerId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
