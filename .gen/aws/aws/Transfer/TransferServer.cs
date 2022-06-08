using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Transfer
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/transfer_server aws_transfer_server}.</summary>
    [JsiiClass(nativeType: typeof(aws.Transfer.TransferServer), fullyQualifiedName: "aws.transfer.TransferServer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.transfer.TransferServerConfig\"}}]")]
    public class TransferServer : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/transfer_server aws_transfer_server} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public TransferServer(Constructs.Construct scope, string id, aws.Transfer.ITransferServerConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TransferServer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TransferServer(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEndpointDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transfer.TransferServerEndpointDetails\"}}]")]
        public virtual void PutEndpointDetails(aws.Transfer.ITransferServerEndpointDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Transfer.ITransferServerEndpointDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEndpointDetails")]
        public virtual void ResetEndpointDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndpointType")]
        public virtual void ResetEndpointType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceDestroy")]
        public virtual void ResetForceDestroy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostKey")]
        public virtual void ResetHostKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentityProviderType")]
        public virtual void ResetIdentityProviderType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInvocationRole")]
        public virtual void ResetInvocationRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingRole")]
        public virtual void ResetLoggingRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrl")]
        public virtual void ResetUrl()
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
        = GetStaticProperty<string>(typeof(aws.Transfer.TransferServer))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointDetails", typeJson: "{\"fqn\":\"aws.transfer.TransferServerEndpointDetailsOutputReference\"}")]
        public virtual aws.Transfer.TransferServerEndpointDetailsOutputReference EndpointDetails
        {
            get => GetInstanceProperty<aws.Transfer.TransferServerEndpointDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "hostKeyFingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostKeyFingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointDetailsInput", typeJson: "{\"fqn\":\"aws.transfer.TransferServerEndpointDetails\"}", isOptional: true)]
        public virtual aws.Transfer.ITransferServerEndpointDetails? EndpointDetailsInput
        {
            get => GetInstanceProperty<aws.Transfer.ITransferServerEndpointDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDestroyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceDestroyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityProviderTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityProviderTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "invocationRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InvocationRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoggingRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceDestroy
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identityProviderType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityProviderType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "invocationRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvocationRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loggingRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoggingRole
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

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
