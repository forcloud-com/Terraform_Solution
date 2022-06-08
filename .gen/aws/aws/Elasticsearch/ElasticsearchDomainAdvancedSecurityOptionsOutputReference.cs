using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiClass(nativeType: typeof(aws.Elasticsearch.ElasticsearchDomainAdvancedSecurityOptionsOutputReference), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ElasticsearchDomainAdvancedSecurityOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ElasticsearchDomainAdvancedSecurityOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainAdvancedSecurityOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainAdvancedSecurityOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMasterUserOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions\"}}]")]
        public virtual void PutMasterUserOptions(aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInternalUserDatabaseEnabled")]
        public virtual void ResetInternalUserDatabaseEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterUserOptions")]
        public virtual void ResetMasterUserOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "masterUserOptions", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptionsOutputReference\"}")]
        public virtual aws.Elasticsearch.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptionsOutputReference MasterUserOptions
        {
            get => GetInstanceProperty<aws.Elasticsearch.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalUserDatabaseEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalUserDatabaseEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterUserOptionsInput", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions? MasterUserOptionsInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptionsMasterUserOptions?>();
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "internalUserDatabaseEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object InternalUserDatabaseEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainAdvancedSecurityOptions\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainAdvancedSecurityOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
