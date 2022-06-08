using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiClass(nativeType: typeof(aws.Elasticsearch.ElasticsearchDomainClusterConfigOutputReference), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainClusterConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ElasticsearchDomainClusterConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ElasticsearchDomainClusterConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainClusterConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainClusterConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putZoneAwarenessConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainClusterConfigZoneAwarenessConfig\"}}]")]
        public virtual void PutZoneAwarenessConfig(aws.Elasticsearch.IElasticsearchDomainClusterConfigZoneAwarenessConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticsearch.IElasticsearchDomainClusterConfigZoneAwarenessConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDedicatedMasterCount")]
        public virtual void ResetDedicatedMasterCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDedicatedMasterEnabled")]
        public virtual void ResetDedicatedMasterEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDedicatedMasterType")]
        public virtual void ResetDedicatedMasterType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceCount")]
        public virtual void ResetInstanceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceType")]
        public virtual void ResetInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWarmCount")]
        public virtual void ResetWarmCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWarmEnabled")]
        public virtual void ResetWarmEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWarmType")]
        public virtual void ResetWarmType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZoneAwarenessConfig")]
        public virtual void ResetZoneAwarenessConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZoneAwarenessEnabled")]
        public virtual void ResetZoneAwarenessEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "zoneAwarenessConfig", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference\"}")]
        public virtual aws.Elasticsearch.ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference ZoneAwarenessConfig
        {
            get => GetInstanceProperty<aws.Elasticsearch.ElasticsearchDomainClusterConfigZoneAwarenessConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DedicatedMasterCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DedicatedMasterEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dedicatedMasterTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DedicatedMasterTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "warmCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WarmCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "warmEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WarmEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "warmTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WarmTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneAwarenessConfigInput", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainClusterConfigZoneAwarenessConfig\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainClusterConfigZoneAwarenessConfig? ZoneAwarenessConfigInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainClusterConfigZoneAwarenessConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneAwarenessEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ZoneAwarenessEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "dedicatedMasterCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DedicatedMasterCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dedicatedMasterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DedicatedMasterEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dedicatedMasterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DedicatedMasterType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "warmCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WarmCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "warmEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object WarmEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "warmType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WarmType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zoneAwarenessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ZoneAwarenessEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainClusterConfig\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainClusterConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainClusterConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
