using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directoryservice
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory aws_directory_service_directory}.</summary>
    [JsiiClass(nativeType: typeof(aws.Directoryservice.DirectoryServiceDirectory), fullyQualifiedName: "aws.directoryservice.DirectoryServiceDirectory", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.directoryservice.DirectoryServiceDirectoryConfig\"}}]")]
    public class DirectoryServiceDirectory : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory aws_directory_service_directory} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DirectoryServiceDirectory(Constructs.Construct scope, string id, aws.Directoryservice.IDirectoryServiceDirectoryConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DirectoryServiceDirectory(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DirectoryServiceDirectory(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.directoryservice.DirectoryServiceDirectoryConnectSettings\"}}]")]
        public virtual void PutConnectSettings(aws.Directoryservice.IDirectoryServiceDirectoryConnectSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Directoryservice.IDirectoryServiceDirectoryConnectSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.directoryservice.DirectoryServiceDirectoryVpcSettings\"}}]")]
        public virtual void PutVpcSettings(aws.Directoryservice.IDirectoryServiceDirectoryVpcSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Directoryservice.IDirectoryServiceDirectoryVpcSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlias")]
        public virtual void ResetAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectSettings")]
        public virtual void ResetConnectSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEdition")]
        public virtual void ResetEdition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableSso")]
        public virtual void ResetEnableSso()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShortName")]
        public virtual void ResetShortName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSize")]
        public virtual void ResetSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcSettings")]
        public virtual void ResetVpcSettings()
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
        = GetStaticProperty<string>(typeof(aws.Directoryservice.DirectoryServiceDirectory))!;

        [JsiiProperty(name: "accessUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectSettings", typeJson: "{\"fqn\":\"aws.directoryservice.DirectoryServiceDirectoryConnectSettingsOutputReference\"}")]
        public virtual aws.Directoryservice.DirectoryServiceDirectoryConnectSettingsOutputReference ConnectSettings
        {
            get => GetInstanceProperty<aws.Directoryservice.DirectoryServiceDirectoryConnectSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "dnsIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcSettings", typeJson: "{\"fqn\":\"aws.directoryservice.DirectoryServiceDirectoryVpcSettingsOutputReference\"}")]
        public virtual aws.Directoryservice.DirectoryServiceDirectoryVpcSettingsOutputReference VpcSettings
        {
            get => GetInstanceProperty<aws.Directoryservice.DirectoryServiceDirectoryVpcSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AliasInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectSettingsInput", typeJson: "{\"fqn\":\"aws.directoryservice.DirectoryServiceDirectoryConnectSettings\"}", isOptional: true)]
        public virtual aws.Directoryservice.IDirectoryServiceDirectoryConnectSettings? ConnectSettingsInput
        {
            get => GetInstanceProperty<aws.Directoryservice.IDirectoryServiceDirectoryConnectSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "editionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EditionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableSsoInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableSsoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shortNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShortNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SizeInput
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
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcSettingsInput", typeJson: "{\"fqn\":\"aws.directoryservice.DirectoryServiceDirectoryVpcSettings\"}", isOptional: true)]
        public virtual aws.Directoryservice.IDirectoryServiceDirectoryVpcSettings? VpcSettingsInput
        {
            get => GetInstanceProperty<aws.Directoryservice.IDirectoryServiceDirectoryVpcSettings?>();
        }

        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Alias
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "edition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Edition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableSso", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableSso
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Size
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
