using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directconnect
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface_accepter aws_dx_hosted_public_virtual_interface_accepter}.</summary>
    [JsiiClass(nativeType: typeof(aws.Directconnect.DxHostedPublicVirtualInterfaceAccepter), fullyQualifiedName: "aws.directconnect.DxHostedPublicVirtualInterfaceAccepter", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.directconnect.DxHostedPublicVirtualInterfaceAccepterConfig\"}}]")]
    public class DxHostedPublicVirtualInterfaceAccepter : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/dx_hosted_public_virtual_interface_accepter aws_dx_hosted_public_virtual_interface_accepter} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DxHostedPublicVirtualInterfaceAccepter(Constructs.Construct scope, string id, aws.Directconnect.IDxHostedPublicVirtualInterfaceAccepterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DxHostedPublicVirtualInterfaceAccepter(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DxHostedPublicVirtualInterfaceAccepter(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.directconnect.DxHostedPublicVirtualInterfaceAccepterTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Directconnect.IDxHostedPublicVirtualInterfaceAccepterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Directconnect.IDxHostedPublicVirtualInterfaceAccepterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Directconnect.DxHostedPublicVirtualInterfaceAccepter))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directconnect.DxHostedPublicVirtualInterfaceAccepterTimeoutsOutputReference\"}")]
        public virtual aws.Directconnect.DxHostedPublicVirtualInterfaceAccepterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Directconnect.DxHostedPublicVirtualInterfaceAccepterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.directconnect.DxHostedPublicVirtualInterfaceAccepterTimeouts\"}", isOptional: true)]
        public virtual aws.Directconnect.IDxHostedPublicVirtualInterfaceAccepterTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Directconnect.IDxHostedPublicVirtualInterfaceAccepterTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualInterfaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualInterfaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "virtualInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualInterfaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
