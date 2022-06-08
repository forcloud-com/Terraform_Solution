using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    /// <summary>AWS VPC.</summary>
    [JsiiInterface(nativeType: typeof(ISecurityGroupRuleConfig), fullyQualifiedName: "aws.vpc.SecurityGroupRuleConfig")]
    public interface ISecurityGroupRuleConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#from_port SecurityGroupRule#from_port}.</summary>
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}")]
        double FromPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#protocol SecurityGroupRule#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#security_group_id SecurityGroupRule#security_group_id}.</summary>
        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string SecurityGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#to_port SecurityGroupRule#to_port}.</summary>
        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}")]
        double ToPort
        {
            get;
        }

        /// <summary>Type of rule, ingress (inbound) or egress (outbound).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#type SecurityGroupRule#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#cidr_blocks SecurityGroupRule#cidr_blocks}.</summary>
        [JsiiProperty(name: "cidrBlocks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CidrBlocks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#description SecurityGroupRule#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#ipv6_cidr_blocks SecurityGroupRule#ipv6_cidr_blocks}.</summary>
        [JsiiProperty(name: "ipv6CidrBlocks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Ipv6CidrBlocks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#prefix_list_ids SecurityGroupRule#prefix_list_ids}.</summary>
        [JsiiProperty(name: "prefixListIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PrefixListIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#self SecurityGroupRule#self}.</summary>
        [JsiiProperty(name: "selfAttribute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SelfAttribute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#source_security_group_id SecurityGroupRule#source_security_group_id}.</summary>
        [JsiiProperty(name: "sourceSecurityGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceSecurityGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS VPC.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISecurityGroupRuleConfig), fullyQualifiedName: "aws.vpc.SecurityGroupRuleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Vpc.ISecurityGroupRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#from_port SecurityGroupRule#from_port}.</summary>
            [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}")]
            public double FromPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#protocol SecurityGroupRule#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#security_group_id SecurityGroupRule#security_group_id}.</summary>
            [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecurityGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#to_port SecurityGroupRule#to_port}.</summary>
            [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}")]
            public double ToPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Type of rule, ingress (inbound) or egress (outbound).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#type SecurityGroupRule#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#cidr_blocks SecurityGroupRule#cidr_blocks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cidrBlocks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CidrBlocks
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#description SecurityGroupRule#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#ipv6_cidr_blocks SecurityGroupRule#ipv6_cidr_blocks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6CidrBlocks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Ipv6CidrBlocks
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#prefix_list_ids SecurityGroupRule#prefix_list_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefixListIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PrefixListIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#self SecurityGroupRule#self}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "selfAttribute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SelfAttribute
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/security_group_rule#source_security_group_id SecurityGroupRule#source_security_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceSecurityGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceSecurityGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
