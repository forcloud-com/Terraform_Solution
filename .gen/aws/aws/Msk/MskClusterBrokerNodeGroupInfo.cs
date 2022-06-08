using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.msk.MskClusterBrokerNodeGroupInfo")]
    public class MskClusterBrokerNodeGroupInfo : aws.Msk.IMskClusterBrokerNodeGroupInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#client_subnets MskCluster#client_subnets}.</summary>
        [JsiiProperty(name: "clientSubnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ClientSubnets
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#ebs_volume_size MskCluster#ebs_volume_size}.</summary>
        [JsiiProperty(name: "ebsVolumeSize", typeJson: "{\"primitive\":\"number\"}")]
        public double EbsVolumeSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#instance_type MskCluster#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#security_groups MskCluster#security_groups}.</summary>
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SecurityGroups
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#az_distribution MskCluster#az_distribution}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azDistribution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AzDistribution
        {
            get;
            set;
        }
    }
}
