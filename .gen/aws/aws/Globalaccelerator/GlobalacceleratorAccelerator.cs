using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Globalaccelerator
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_accelerator aws_globalaccelerator_accelerator}.</summary>
    [JsiiClass(nativeType: typeof(aws.Globalaccelerator.GlobalacceleratorAccelerator), fullyQualifiedName: "aws.globalaccelerator.GlobalacceleratorAccelerator", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorAcceleratorConfig\"}}]")]
    public class GlobalacceleratorAccelerator : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_accelerator aws_globalaccelerator_accelerator} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GlobalacceleratorAccelerator(Constructs.Construct scope, string id, aws.Globalaccelerator.IGlobalacceleratorAcceleratorConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlobalacceleratorAccelerator(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlobalacceleratorAccelerator(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAttributes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorAcceleratorAttributes\"}}]")]
        public virtual void PutAttributes(aws.Globalaccelerator.IGlobalacceleratorAcceleratorAttributes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Globalaccelerator.IGlobalacceleratorAcceleratorAttributes)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAttributes")]
        public virtual void ResetAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpAddressType")]
        public virtual void ResetIpAddressType()
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
        = GetStaticProperty<string>(typeof(aws.Globalaccelerator.GlobalacceleratorAccelerator))!;

        [JsiiProperty(name: "attributes", typeJson: "{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorAcceleratorAttributesOutputReference\"}")]
        public virtual aws.Globalaccelerator.GlobalacceleratorAcceleratorAttributesOutputReference Attributes
        {
            get => GetInstanceProperty<aws.Globalaccelerator.GlobalacceleratorAcceleratorAttributesOutputReference>()!;
        }

        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostedZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipSets", typeJson: "{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorAcceleratorIpSetsList\"}")]
        public virtual aws.Globalaccelerator.GlobalacceleratorAcceleratorIpSetsList IpSets
        {
            get => GetInstanceProperty<aws.Globalaccelerator.GlobalacceleratorAcceleratorIpSetsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributesInput", typeJson: "{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorAcceleratorAttributes\"}", isOptional: true)]
        public virtual aws.Globalaccelerator.IGlobalacceleratorAcceleratorAttributes? AttributesInput
        {
            get => GetInstanceProperty<aws.Globalaccelerator.IGlobalacceleratorAcceleratorAttributes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipAddressTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpAddressTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddressType
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
