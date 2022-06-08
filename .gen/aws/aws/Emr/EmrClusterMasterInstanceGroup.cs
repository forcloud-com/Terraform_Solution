using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emr.EmrClusterMasterInstanceGroup")]
    public class EmrClusterMasterInstanceGroup : aws.Emr.IEmrClusterMasterInstanceGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#instance_type EmrCluster#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#bid_price EmrCluster#bid_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BidPrice
        {
            get;
            set;
        }

        /// <summary>ebs_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#ebs_config EmrCluster#ebs_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ebsConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceGroupEbsConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EbsConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#instance_count EmrCluster#instance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#name EmrCluster#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
