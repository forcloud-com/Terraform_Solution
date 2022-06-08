using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>AWS EC2.</summary>
    [JsiiInterface(nativeType: typeof(IEc2TrafficMirrorFilterRuleConfig), fullyQualifiedName: "aws.ec2.Ec2TrafficMirrorFilterRuleConfig")]
    public interface IEc2TrafficMirrorFilterRuleConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#destination_cidr_block Ec2TrafficMirrorFilterRule#destination_cidr_block}.</summary>
        [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationCidrBlock
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#rule_action Ec2TrafficMirrorFilterRule#rule_action}.</summary>
        [JsiiProperty(name: "ruleAction", typeJson: "{\"primitive\":\"string\"}")]
        string RuleAction
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#rule_number Ec2TrafficMirrorFilterRule#rule_number}.</summary>
        [JsiiProperty(name: "ruleNumber", typeJson: "{\"primitive\":\"number\"}")]
        double RuleNumber
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#source_cidr_block Ec2TrafficMirrorFilterRule#source_cidr_block}.</summary>
        [JsiiProperty(name: "sourceCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        string SourceCidrBlock
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#traffic_direction Ec2TrafficMirrorFilterRule#traffic_direction}.</summary>
        [JsiiProperty(name: "trafficDirection", typeJson: "{\"primitive\":\"string\"}")]
        string TrafficDirection
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#traffic_mirror_filter_id Ec2TrafficMirrorFilterRule#traffic_mirror_filter_id}.</summary>
        [JsiiProperty(name: "trafficMirrorFilterId", typeJson: "{\"primitive\":\"string\"}")]
        string TrafficMirrorFilterId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#description Ec2TrafficMirrorFilterRule#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>destination_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#destination_port_range Ec2TrafficMirrorFilterRule#destination_port_range}
        /// </remarks>
        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"aws.ec2.Ec2TrafficMirrorFilterRuleDestinationPortRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.IEc2TrafficMirrorFilterRuleDestinationPortRange? DestinationPortRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#protocol Ec2TrafficMirrorFilterRule#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#source_port_range Ec2TrafficMirrorFilterRule#source_port_range}
        /// </remarks>
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"aws.ec2.Ec2TrafficMirrorFilterRuleSourcePortRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.IEc2TrafficMirrorFilterRuleSourcePortRange? SourcePortRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EC2.</summary>
        [JsiiTypeProxy(nativeType: typeof(IEc2TrafficMirrorFilterRuleConfig), fullyQualifiedName: "aws.ec2.Ec2TrafficMirrorFilterRuleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IEc2TrafficMirrorFilterRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#destination_cidr_block Ec2TrafficMirrorFilterRule#destination_cidr_block}.</summary>
            [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationCidrBlock
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#rule_action Ec2TrafficMirrorFilterRule#rule_action}.</summary>
            [JsiiProperty(name: "ruleAction", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleAction
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#rule_number Ec2TrafficMirrorFilterRule#rule_number}.</summary>
            [JsiiProperty(name: "ruleNumber", typeJson: "{\"primitive\":\"number\"}")]
            public double RuleNumber
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#source_cidr_block Ec2TrafficMirrorFilterRule#source_cidr_block}.</summary>
            [JsiiProperty(name: "sourceCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceCidrBlock
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#traffic_direction Ec2TrafficMirrorFilterRule#traffic_direction}.</summary>
            [JsiiProperty(name: "trafficDirection", typeJson: "{\"primitive\":\"string\"}")]
            public string TrafficDirection
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#traffic_mirror_filter_id Ec2TrafficMirrorFilterRule#traffic_mirror_filter_id}.</summary>
            [JsiiProperty(name: "trafficMirrorFilterId", typeJson: "{\"primitive\":\"string\"}")]
            public string TrafficMirrorFilterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#description Ec2TrafficMirrorFilterRule#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>destination_port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#destination_port_range Ec2TrafficMirrorFilterRule#destination_port_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"aws.ec2.Ec2TrafficMirrorFilterRuleDestinationPortRange\"}", isOptional: true)]
            public aws.Ec2.IEc2TrafficMirrorFilterRuleDestinationPortRange? DestinationPortRange
            {
                get => GetInstanceProperty<aws.Ec2.IEc2TrafficMirrorFilterRuleDestinationPortRange?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#protocol Ec2TrafficMirrorFilterRule#protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Protocol
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>source_port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#source_port_range Ec2TrafficMirrorFilterRule#source_port_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"aws.ec2.Ec2TrafficMirrorFilterRuleSourcePortRange\"}", isOptional: true)]
            public aws.Ec2.IEc2TrafficMirrorFilterRuleSourcePortRange? SourcePortRange
            {
                get => GetInstanceProperty<aws.Ec2.IEc2TrafficMirrorFilterRuleSourcePortRange?>();
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
