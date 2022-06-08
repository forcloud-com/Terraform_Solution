using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainCognitoOptions), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainCognitoOptions")]
    public interface IElasticsearchDomainCognitoOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#identity_pool_id ElasticsearchDomain#identity_pool_id}.</summary>
        [JsiiProperty(name: "identityPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityPoolId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#role_arn ElasticsearchDomain#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#user_pool_id ElasticsearchDomain#user_pool_id}.</summary>
        [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string UserPoolId
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

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainCognitoOptions), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainCognitoOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Elasticsearch.IElasticsearchDomainCognitoOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#identity_pool_id ElasticsearchDomain#identity_pool_id}.</summary>
            [JsiiProperty(name: "identityPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityPoolId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#role_arn ElasticsearchDomain#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticsearch_domain#user_pool_id ElasticsearchDomain#user_pool_id}.</summary>
            [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPoolId
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
