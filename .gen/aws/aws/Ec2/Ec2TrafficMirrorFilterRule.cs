using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule aws_ec2_traffic_mirror_filter_rule}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2.Ec2TrafficMirrorFilterRule), fullyQualifiedName: "aws.ec2.Ec2TrafficMirrorFilterRule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ec2.Ec2TrafficMirrorFilterRuleConfig\"}}]")]
    public class Ec2TrafficMirrorFilterRule : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule aws_ec2_traffic_mirror_filter_rule} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Ec2TrafficMirrorFilterRule(Constructs.Construct scope, string id, aws.Ec2.IEc2TrafficMirrorFilterRuleConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2TrafficMirrorFilterRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2TrafficMirrorFilterRule(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestinationPortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.Ec2TrafficMirrorFilterRuleDestinationPortRange\"}}]")]
        public virtual void PutDestinationPortRange(aws.Ec2.IEc2TrafficMirrorFilterRuleDestinationPortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.IEc2TrafficMirrorFilterRuleDestinationPortRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourcePortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.Ec2TrafficMirrorFilterRuleSourcePortRange\"}}]")]
        public virtual void PutSourcePortRange(aws.Ec2.IEc2TrafficMirrorFilterRuleSourcePortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.IEc2TrafficMirrorFilterRuleSourcePortRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationPortRange")]
        public virtual void ResetDestinationPortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourcePortRange")]
        public virtual void ResetSourcePortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Ec2.Ec2TrafficMirrorFilterRule))!;

        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"aws.ec2.Ec2TrafficMirrorFilterRuleDestinationPortRangeOutputReference\"}")]
        public virtual aws.Ec2.Ec2TrafficMirrorFilterRuleDestinationPortRangeOutputReference DestinationPortRange
        {
            get => GetInstanceProperty<aws.Ec2.Ec2TrafficMirrorFilterRuleDestinationPortRangeOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"aws.ec2.Ec2TrafficMirrorFilterRuleSourcePortRangeOutputReference\"}")]
        public virtual aws.Ec2.Ec2TrafficMirrorFilterRuleSourcePortRangeOutputReference SourcePortRange
        {
            get => GetInstanceProperty<aws.Ec2.Ec2TrafficMirrorFilterRuleSourcePortRangeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationCidrBlockInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationCidrBlockInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationPortRangeInput", typeJson: "{\"fqn\":\"aws.ec2.Ec2TrafficMirrorFilterRuleDestinationPortRange\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2TrafficMirrorFilterRuleDestinationPortRange? DestinationPortRangeInput
        {
            get => GetInstanceProperty<aws.Ec2.IEc2TrafficMirrorFilterRuleDestinationPortRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ProtocolInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuleActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleNumberInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RuleNumberInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceCidrBlockInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceCidrBlockInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRangeInput", typeJson: "{\"fqn\":\"aws.ec2.Ec2TrafficMirrorFilterRuleSourcePortRange\"}", isOptional: true)]
        public virtual aws.Ec2.IEc2TrafficMirrorFilterRuleSourcePortRange? SourcePortRangeInput
        {
            get => GetInstanceProperty<aws.Ec2.IEc2TrafficMirrorFilterRuleSourcePortRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficDirectionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrafficDirectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficMirrorFilterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrafficMirrorFilterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationCidrBlock
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Protocol
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ruleAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ruleNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RuleNumber
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCidrBlock
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trafficDirection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrafficDirection
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trafficMirrorFilterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrafficMirrorFilterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
