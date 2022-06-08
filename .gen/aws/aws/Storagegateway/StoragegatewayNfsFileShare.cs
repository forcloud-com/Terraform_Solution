using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share aws_storagegateway_nfs_file_share}.</summary>
    [JsiiClass(nativeType: typeof(aws.Storagegateway.StoragegatewayNfsFileShare), fullyQualifiedName: "aws.storagegateway.StoragegatewayNfsFileShare", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.storagegateway.StoragegatewayNfsFileShareConfig\"}}]")]
    public class StoragegatewayNfsFileShare : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share aws_storagegateway_nfs_file_share} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StoragegatewayNfsFileShare(Constructs.Construct scope, string id, aws.Storagegateway.IStoragegatewayNfsFileShareConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayNfsFileShare(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayNfsFileShare(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNfsFileShareDefaults", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.storagegateway.StoragegatewayNfsFileShareNfsFileShareDefaults\"}}]")]
        public virtual void PutNfsFileShareDefaults(aws.Storagegateway.IStoragegatewayNfsFileShareNfsFileShareDefaults @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Storagegateway.IStoragegatewayNfsFileShareNfsFileShareDefaults)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.storagegateway.StoragegatewayNfsFileShareTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Storagegateway.IStoragegatewayNfsFileShareTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Storagegateway.IStoragegatewayNfsFileShareTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefaultStorageClass")]
        public virtual void ResetDefaultStorageClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGuessMimeTypeEnabled")]
        public virtual void ResetGuessMimeTypeEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsEncrypted")]
        public virtual void ResetKmsEncrypted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyArn")]
        public virtual void ResetKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNfsFileShareDefaults")]
        public virtual void ResetNfsFileShareDefaults()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectAcl")]
        public virtual void ResetObjectAcl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadOnly")]
        public virtual void ResetReadOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequesterPays")]
        public virtual void ResetRequesterPays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSquash")]
        public virtual void ResetSquash()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(aws.Storagegateway.StoragegatewayNfsFileShare))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileshareId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileshareId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nfsFileShareDefaults", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayNfsFileShareNfsFileShareDefaultsOutputReference\"}")]
        public virtual aws.Storagegateway.StoragegatewayNfsFileShareNfsFileShareDefaultsOutputReference NfsFileShareDefaults
        {
            get => GetInstanceProperty<aws.Storagegateway.StoragegatewayNfsFileShareNfsFileShareDefaultsOutputReference>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayNfsFileShareTimeoutsOutputReference\"}")]
        public virtual aws.Storagegateway.StoragegatewayNfsFileShareTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Storagegateway.StoragegatewayNfsFileShareTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientListInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ClientListInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultStorageClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultStorageClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "guessMimeTypeEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? GuessMimeTypeEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsEncryptedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? KmsEncryptedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nfsFileShareDefaultsInput", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayNfsFileShareNfsFileShareDefaults\"}", isOptional: true)]
        public virtual aws.Storagegateway.IStoragegatewayNfsFileShareNfsFileShareDefaults? NfsFileShareDefaultsInput
        {
            get => GetInstanceProperty<aws.Storagegateway.IStoragegatewayNfsFileShareNfsFileShareDefaults?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectAclInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectAclInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReadOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requesterPaysInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequesterPaysInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "squashInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SquashInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayNfsFileShareTimeouts\"}", isOptional: true)]
        public virtual aws.Storagegateway.IStoragegatewayNfsFileShareTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Storagegateway.IStoragegatewayNfsFileShareTimeouts?>();
        }

        [JsiiProperty(name: "clientList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ClientList
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultStorageClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultStorageClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "guessMimeTypeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object GuessMimeTypeEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsEncrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object KmsEncrypted
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "locationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocationArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectAcl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectAcl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ReadOnly
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requesterPays", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RequesterPays
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "squash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Squash
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
