using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainLogPublishingOptions), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainLogPublishingOptions")]
    public interface IElasticsearchDomainLogPublishingOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#cloudwatch_log_group_arn ElasticsearchDomain#cloudwatch_log_group_arn}.</summary>
        [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        string CloudwatchLogGroupArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#log_type ElasticsearchDomain#log_type}.</summary>
        [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}")]
        string LogType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#enabled ElasticsearchDomain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainLogPublishingOptions), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainLogPublishingOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Elasticsearch.IElasticsearchDomainLogPublishingOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#cloudwatch_log_group_arn ElasticsearchDomain#cloudwatch_log_group_arn}.</summary>
            [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudwatchLogGroupArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#log_type ElasticsearchDomain#log_type}.</summary>
            [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}")]
            public string LogType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#enabled ElasticsearchDomain#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
