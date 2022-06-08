using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    [JsiiClass(nativeType: typeof(aws.Storagegateway.StoragegatewayNfsFileShareNfsFileShareDefaultsOutputReference), fullyQualifiedName: "aws.storagegateway.StoragegatewayNfsFileShareNfsFileShareDefaultsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StoragegatewayNfsFileShareNfsFileShareDefaultsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StoragegatewayNfsFileShareNfsFileShareDefaultsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayNfsFileShareNfsFileShareDefaultsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayNfsFileShareNfsFileShareDefaultsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDirectoryMode")]
        public virtual void ResetDirectoryMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileMode")]
        public virtual void ResetFileMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGroupId")]
        public virtual void ResetGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOwnerId")]
        public virtual void ResetOwnerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "directoryModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DirectoryModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GroupIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OwnerIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "directoryMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fileMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GroupId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OwnerId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayNfsFileShareNfsFileShareDefaults\"}", isOptional: true)]
        public virtual aws.Storagegateway.IStoragegatewayNfsFileShareNfsFileShareDefaults? InternalValue
        {
            get => GetInstanceProperty<aws.Storagegateway.IStoragegatewayNfsFileShareNfsFileShareDefaults?>();
            set => SetInstanceProperty(value);
        }
    }
}
