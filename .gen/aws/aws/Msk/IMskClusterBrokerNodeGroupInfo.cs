using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiInterface(nativeType: typeof(IMskClusterBrokerNodeGroupInfo), fullyQualifiedName: "aws.msk.MskClusterBrokerNodeGroupInfo")]
    public interface IMskClusterBrokerNodeGroupInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#client_subnets MskCluster#client_subnets}.</summary>
        [JsiiProperty(name: "clientSubnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ClientSubnets
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#ebs_volume_size MskCluster#ebs_volume_size}.</summary>
        [JsiiProperty(name: "ebsVolumeSize", typeJson: "{\"primitive\":\"number\"}")]
        double EbsVolumeSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#instance_type MskCluster#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#security_groups MskCluster#security_groups}.</summary>
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroups
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#az_distribution MskCluster#az_distribution}.</summary>
        [JsiiProperty(name: "azDistribution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzDistribution
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterBrokerNodeGroupInfo), fullyQualifiedName: "aws.msk.MskClusterBrokerNodeGroupInfo")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskClusterBrokerNodeGroupInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#client_subnets MskCluster#client_subnets}.</summary>
            [JsiiProperty(name: "clientSubnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ClientSubnets
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#ebs_volume_size MskCluster#ebs_volume_size}.</summary>
            [JsiiProperty(name: "ebsVolumeSize", typeJson: "{\"primitive\":\"number\"}")]
            public double EbsVolumeSize
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#instance_type MskCluster#instance_type}.</summary>
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#security_groups MskCluster#security_groups}.</summary>
            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroups
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#az_distribution MskCluster#az_distribution}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "azDistribution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzDistribution
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
