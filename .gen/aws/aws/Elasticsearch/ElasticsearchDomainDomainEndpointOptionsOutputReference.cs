using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiClass(nativeType: typeof(aws.Elasticsearch.ElasticsearchDomainDomainEndpointOptionsOutputReference), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainDomainEndpointOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ElasticsearchDomainDomainEndpointOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ElasticsearchDomainDomainEndpointOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainDomainEndpointOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainDomainEndpointOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTlsSecurityPolicy")]
        public virtual void ResetTlsSecurityPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "enforceHttpsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnforceHttpsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsSecurityPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TlsSecurityPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "enforceHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnforceHttps
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tlsSecurityPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TlsSecurityPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainDomainEndpointOptions\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainDomainEndpointOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainDomainEndpointOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
