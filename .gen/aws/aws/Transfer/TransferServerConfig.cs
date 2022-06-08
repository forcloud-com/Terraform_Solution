using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Transfer
{
    /// <summary>AWS Transfer.</summary>
    [JsiiByValue(fqn: "aws.transfer.TransferServerConfig")]
    public class TransferServerConfig : aws.Transfer.ITransferServerConfig
    {
        /// <summary>endpoint_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#endpoint_details TransferServer#endpoint_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpointDetails", typeJson: "{\"fqn\":\"aws.transfer.TransferServerEndpointDetails\"}", isOptional: true)]
        public aws.Transfer.ITransferServerEndpointDetails? EndpointDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#endpoint_type TransferServer#endpoint_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#force_destroy TransferServer#force_destroy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forceDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ForceDestroy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#host_key TransferServer#host_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#identity_provider_type TransferServer#identity_provider_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityProviderType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityProviderType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#invocation_role TransferServer#invocation_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "invocationRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InvocationRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#logging_role TransferServer#logging_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loggingRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoggingRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#tags TransferServer#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/transfer_server#url TransferServer#url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Url
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
