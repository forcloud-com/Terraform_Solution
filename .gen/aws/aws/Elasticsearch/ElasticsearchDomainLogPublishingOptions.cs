using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticsearch.ElasticsearchDomainLogPublishingOptions")]
    public class ElasticsearchDomainLogPublishingOptions : aws.Elasticsearch.IElasticsearchDomainLogPublishingOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#cloudwatch_log_group_arn ElasticsearchDomain#cloudwatch_log_group_arn}.</summary>
        [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public string CloudwatchLogGroupArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#log_type ElasticsearchDomain#log_type}.</summary>
        [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}")]
        public string LogType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#enabled ElasticsearchDomain#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get;
            set;
        }
    }
}
