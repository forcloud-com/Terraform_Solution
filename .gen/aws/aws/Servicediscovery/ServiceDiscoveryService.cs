using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicediscovery
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service aws_service_discovery_service}.</summary>
    [JsiiClass(nativeType: typeof(aws.Servicediscovery.ServiceDiscoveryService), fullyQualifiedName: "aws.servicediscovery.ServiceDiscoveryService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceConfig\"}}]")]
    public class ServiceDiscoveryService : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/service_discovery_service aws_service_discovery_service} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServiceDiscoveryService(Constructs.Construct scope, string id, aws.Servicediscovery.IServiceDiscoveryServiceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceDiscoveryService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceDiscoveryService(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDnsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceDnsConfig\"}}]")]
        public virtual void PutDnsConfig(aws.Servicediscovery.IServiceDiscoveryServiceDnsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Servicediscovery.IServiceDiscoveryServiceDnsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthCheckConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceHealthCheckConfig\"}}]")]
        public virtual void PutHealthCheckConfig(aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthCheckCustomConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceHealthCheckCustomConfig\"}}]")]
        public virtual void PutHealthCheckCustomConfig(aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckCustomConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckCustomConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsConfig")]
        public virtual void ResetDnsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckConfig")]
        public virtual void ResetHealthCheckConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckCustomConfig")]
        public virtual void ResetHealthCheckCustomConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamespaceId")]
        public virtual void ResetNamespaceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Servicediscovery.ServiceDiscoveryService))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsConfig", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceDnsConfigOutputReference\"}")]
        public virtual aws.Servicediscovery.ServiceDiscoveryServiceDnsConfigOutputReference DnsConfig
        {
            get => GetInstanceProperty<aws.Servicediscovery.ServiceDiscoveryServiceDnsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheckConfig", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceHealthCheckConfigOutputReference\"}")]
        public virtual aws.Servicediscovery.ServiceDiscoveryServiceHealthCheckConfigOutputReference HealthCheckConfig
        {
            get => GetInstanceProperty<aws.Servicediscovery.ServiceDiscoveryServiceHealthCheckConfigOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheckCustomConfig", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceHealthCheckCustomConfigOutputReference\"}")]
        public virtual aws.Servicediscovery.ServiceDiscoveryServiceHealthCheckCustomConfigOutputReference HealthCheckCustomConfig
        {
            get => GetInstanceProperty<aws.Servicediscovery.ServiceDiscoveryServiceHealthCheckCustomConfigOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsConfigInput", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceDnsConfig\"}", isOptional: true)]
        public virtual aws.Servicediscovery.IServiceDiscoveryServiceDnsConfig? DnsConfigInput
        {
            get => GetInstanceProperty<aws.Servicediscovery.IServiceDiscoveryServiceDnsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckConfigInput", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceHealthCheckConfig\"}", isOptional: true)]
        public virtual aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckConfig? HealthCheckConfigInput
        {
            get => GetInstanceProperty<aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckCustomConfigInput", typeJson: "{\"fqn\":\"aws.servicediscovery.ServiceDiscoveryServiceHealthCheckCustomConfig\"}", isOptional: true)]
        public virtual aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckCustomConfig? HealthCheckCustomConfigInput
        {
            get => GetInstanceProperty<aws.Servicediscovery.IServiceDiscoveryServiceHealthCheckCustomConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamespaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
