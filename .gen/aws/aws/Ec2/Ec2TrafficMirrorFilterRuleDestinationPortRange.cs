using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.Ec2TrafficMirrorFilterRuleDestinationPortRange")]
    public class Ec2TrafficMirrorFilterRuleDestinationPortRange : aws.Ec2.IEc2TrafficMirrorFilterRuleDestinationPortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#from_port Ec2TrafficMirrorFilterRule#from_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FromPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_traffic_mirror_filter_rule#to_port Ec2TrafficMirrorFilterRule#to_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ToPort
        {
            get;
            set;
        }
    }
}
