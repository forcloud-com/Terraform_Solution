using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    [JsiiClass(nativeType: typeof(aws.Datasync.DatasyncTaskOptionsOutputReference), fullyQualifiedName: "aws.datasync.DatasyncTaskOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatasyncTaskOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatasyncTaskOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncTaskOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncTaskOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAtime")]
        public virtual void ResetAtime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBytesPerSecond")]
        public virtual void ResetBytesPerSecond()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGid")]
        public virtual void ResetGid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMtime")]
        public virtual void ResetMtime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPosixPermissions")]
        public virtual void ResetPosixPermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreserveDeletedFiles")]
        public virtual void ResetPreserveDeletedFiles()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreserveDevices")]
        public virtual void ResetPreserveDevices()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUid")]
        public virtual void ResetUid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerifyMode")]
        public virtual void ResetVerifyMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "atimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AtimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bytesPerSecondInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BytesPerSecondInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mtimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MtimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "posixPermissionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PosixPermissionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preserveDeletedFilesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreserveDeletedFilesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preserveDevicesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreserveDevicesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verifyModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VerifyModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "atime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Atime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bytesPerSecond", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BytesPerSecond
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Gid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mtime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mtime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "posixPermissions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PosixPermissions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preserveDeletedFiles", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreserveDeletedFiles
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preserveDevices", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreserveDevices
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "verifyMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerifyMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.datasync.DatasyncTaskOptions\"}", isOptional: true)]
        public virtual aws.Datasync.IDatasyncTaskOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Datasync.IDatasyncTaskOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
