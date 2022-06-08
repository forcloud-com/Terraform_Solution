using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Redshift
{
    [JsiiInterface(nativeType: typeof(IRedshiftSecurityGroupIngress), fullyQualifiedName: "aws.redshift.RedshiftSecurityGroupIngress")]
    public interface IRedshiftSecurityGroupIngress
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_security_group#cidr RedshiftSecurityGroup#cidr}.</summary>
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cidr
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_security_group#security_group_name RedshiftSecurityGroup#security_group_name}.</summary>
        [JsiiProperty(name: "securityGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityGroupName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_security_group#security_group_owner_id RedshiftSecurityGroup#security_group_owner_id}.</summary>
        [JsiiProperty(name: "securityGroupOwnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityGroupOwnerId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftSecurityGroupIngress), fullyQualifiedName: "aws.redshift.RedshiftSecurityGroupIngress")]
        internal sealed class _Proxy : DeputyBase, aws.Redshift.IRedshiftSecurityGroupIngress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_security_group#cidr RedshiftSecurityGroup#cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cidr
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_security_group#security_group_name RedshiftSecurityGroup#security_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityGroupName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_security_group#security_group_owner_id RedshiftSecurityGroup#security_group_owner_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupOwnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityGroupOwnerId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
