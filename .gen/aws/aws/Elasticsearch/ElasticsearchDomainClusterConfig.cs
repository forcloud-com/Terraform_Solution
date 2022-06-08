using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiByValue(fqn: "aws.elasticsearch.ElasticsearchDomainClusterConfig")]
    public class ElasticsearchDomainClusterConfig : aws.Elasticsearch.IElasticsearchDomainClusterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#dedicated_master_count ElasticsearchDomain#dedicated_master_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DedicatedMasterCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#dedicated_master_enabled ElasticsearchDomain#dedicated_master_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DedicatedMasterEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#dedicated_master_type ElasticsearchDomain#dedicated_master_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DedicatedMasterType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#instance_count ElasticsearchDomain#instance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#instance_type ElasticsearchDomain#instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#warm_count ElasticsearchDomain#warm_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warmCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WarmCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#warm_enabled ElasticsearchDomain#warm_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warmEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? WarmEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#warm_type ElasticsearchDomain#warm_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WarmType
        {
            get;
            set;
        }

        /// <summary>zone_awareness_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#zone_awareness_config ElasticsearchDomain#zone_awareness_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zoneAwarenessConfig", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainClusterConfigZoneAwarenessConfig\"}", isOptional: true)]
        public aws.Elasticsearch.IElasticsearchDomainClusterConfigZoneAwarenessConfig? ZoneAwarenessConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#zone_awareness_enabled ElasticsearchDomain#zone_awareness_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zoneAwarenessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ZoneAwarenessEnabled
        {
            get;
            set;
        }
    }
}
