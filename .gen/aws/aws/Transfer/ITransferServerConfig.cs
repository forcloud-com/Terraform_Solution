using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Transfer
{
    /// <summary>AWS Transfer.</summary>
    [JsiiInterface(nativeType: typeof(ITransferServerConfig), fullyQualifiedName: "aws.transfer.TransferServerConfig")]
    public interface ITransferServerConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>endpoint_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#endpoint_details TransferServer#endpoint_details}
        /// </remarks>
        [JsiiProperty(name: "endpointDetails", typeJson: "{\"fqn\":\"aws.transfer.TransferServerEndpointDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Transfer.ITransferServerEndpointDetails? EndpointDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#endpoint_type TransferServer#endpoint_type}.</summary>
        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndpointType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#force_destroy TransferServer#force_destroy}.</summary>
        [JsiiProperty(name: "forceDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForceDestroy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#host_key TransferServer#host_key}.</summary>
        [JsiiProperty(name: "hostKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#identity_provider_type TransferServer#identity_provider_type}.</summary>
        [JsiiProperty(name: "identityProviderType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentityProviderType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#invocation_role TransferServer#invocation_role}.</summary>
        [JsiiProperty(name: "invocationRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InvocationRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#logging_role TransferServer#logging_role}.</summary>
        [JsiiProperty(name: "loggingRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoggingRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#tags TransferServer#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#url TransferServer#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Url
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Transfer.</summary>
        [JsiiTypeProxy(nativeType: typeof(ITransferServerConfig), fullyQualifiedName: "aws.transfer.TransferServerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Transfer.ITransferServerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>endpoint_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#endpoint_details TransferServer#endpoint_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endpointDetails", typeJson: "{\"fqn\":\"aws.transfer.TransferServerEndpointDetails\"}", isOptional: true)]
            public aws.Transfer.ITransferServerEndpointDetails? EndpointDetails
            {
                get => GetInstanceProperty<aws.Transfer.ITransferServerEndpointDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#endpoint_type TransferServer#endpoint_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndpointType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#force_destroy TransferServer#force_destroy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forceDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ForceDestroy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#host_key TransferServer#host_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#identity_provider_type TransferServer#identity_provider_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identityProviderType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentityProviderType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#invocation_role TransferServer#invocation_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "invocationRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InvocationRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#logging_role TransferServer#logging_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loggingRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoggingRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#tags TransferServer#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#url TransferServer#url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Url
            {
                get => GetInstanceProperty<string?>();
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
