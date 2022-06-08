using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticsearch.ElasticsearchDomainEbsOptions")]
    public class ElasticsearchDomainEbsOptions : aws.Elasticsearch.IElasticsearchDomainEbsOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#ebs_enabled ElasticsearchDomain#ebs_enabled}.</summary>
        [JsiiProperty(name: "ebsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object EbsEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#iops ElasticsearchDomain#iops}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Iops
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#volume_size ElasticsearchDomain#volume_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VolumeSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#volume_type ElasticsearchDomain#volume_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeType
        {
            get;
            set;
        }
    }
}
