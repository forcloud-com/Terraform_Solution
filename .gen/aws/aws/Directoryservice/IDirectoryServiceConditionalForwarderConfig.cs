using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directoryservice
{
    /// <summary>AWS Directory Service.</summary>
    [JsiiInterface(nativeType: typeof(IDirectoryServiceConditionalForwarderConfig), fullyQualifiedName: "aws.directoryservice.DirectoryServiceConditionalForwarderConfig")]
    public interface IDirectoryServiceConditionalForwarderConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_conditional_forwarder#directory_id DirectoryServiceConditionalForwarder#directory_id}.</summary>
        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        string DirectoryId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_conditional_forwarder#dns_ips DirectoryServiceConditionalForwarder#dns_ips}.</summary>
        [JsiiProperty(name: "dnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DnsIps
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_conditional_forwarder#remote_domain_name DirectoryServiceConditionalForwarder#remote_domain_name}.</summary>
        [JsiiProperty(name: "remoteDomainName", typeJson: "{\"primitive\":\"string\"}")]
        string RemoteDomainName
        {
            get;
        }

        /// <summary>AWS Directory Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDirectoryServiceConditionalForwarderConfig), fullyQualifiedName: "aws.directoryservice.DirectoryServiceConditionalForwarderConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Directoryservice.IDirectoryServiceConditionalForwarderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_conditional_forwarder#directory_id DirectoryServiceConditionalForwarder#directory_id}.</summary>
            [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
            public string DirectoryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_conditional_forwarder#dns_ips DirectoryServiceConditionalForwarder#dns_ips}.</summary>
            [JsiiProperty(name: "dnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DnsIps
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_conditional_forwarder#remote_domain_name DirectoryServiceConditionalForwarder#remote_domain_name}.</summary>
            [JsiiProperty(name: "remoteDomainName", typeJson: "{\"primitive\":\"string\"}")]
            public string RemoteDomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
