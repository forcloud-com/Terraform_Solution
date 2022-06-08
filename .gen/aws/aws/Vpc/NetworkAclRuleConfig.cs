using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    #pragma warning disable CS8618

    /// <summary>AWS VPC.</summary>
    [JsiiByValue(fqn: "aws.vpc.NetworkAclRuleConfig")]
    public class NetworkAclRuleConfig : aws.Vpc.INetworkAclRuleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_acl_rule#network_acl_id NetworkAclRule#network_acl_id}.</summary>
        [JsiiProperty(name: "networkAclId", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkAclId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_acl_rule#protocol NetworkAclRule#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_acl_rule#rule_action NetworkAclRule#rule_action}.</summary>
        [JsiiProperty(name: "ruleAction", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_acl_rule#rule_number NetworkAclRule#rule_number}.</summary>
        [JsiiProperty(name: "ruleNumber", typeJson: "{\"primitive\":\"number\"}")]
        public double RuleNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_acl_rule#cidr_block NetworkAclRule#cidr_block}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CidrBlock
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_acl_rule#egress NetworkAclRule#egress}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "egress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Egress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_acl_rule#from_port NetworkAclRule#from_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FromPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_acl_rule#icmp_code NetworkAclRule#icmp_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "icmpCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IcmpCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_acl_rule#icmp_type NetworkAclRule#icmp_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "icmpType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IcmpType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_acl_rule#ipv6_cidr_block NetworkAclRule#ipv6_cidr_block}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6CidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv6CidrBlock
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/network_acl_rule#to_port NetworkAclRule#to_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ToPort
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
