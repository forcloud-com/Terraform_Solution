using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    [JsiiInterface(nativeType: typeof(IDatasyncTaskOptions), fullyQualifiedName: "aws.datasync.DatasyncTaskOptions")]
    public interface IDatasyncTaskOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#atime DatasyncTask#atime}.</summary>
        [JsiiProperty(name: "atime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Atime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#bytes_per_second DatasyncTask#bytes_per_second}.</summary>
        [JsiiProperty(name: "bytesPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BytesPerSecond
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#gid DatasyncTask#gid}.</summary>
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Gid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#mtime DatasyncTask#mtime}.</summary>
        [JsiiProperty(name: "mtime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mtime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#posix_permissions DatasyncTask#posix_permissions}.</summary>
        [JsiiProperty(name: "posixPermissions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PosixPermissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#preserve_deleted_files DatasyncTask#preserve_deleted_files}.</summary>
        [JsiiProperty(name: "preserveDeletedFiles", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreserveDeletedFiles
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#preserve_devices DatasyncTask#preserve_devices}.</summary>
        [JsiiProperty(name: "preserveDevices", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreserveDevices
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#uid DatasyncTask#uid}.</summary>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#verify_mode DatasyncTask#verify_mode}.</summary>
        [JsiiProperty(name: "verifyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VerifyMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncTaskOptions), fullyQualifiedName: "aws.datasync.DatasyncTaskOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Datasync.IDatasyncTaskOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#atime DatasyncTask#atime}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "atime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Atime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#bytes_per_second DatasyncTask#bytes_per_second}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bytesPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BytesPerSecond
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#gid DatasyncTask#gid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Gid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#mtime DatasyncTask#mtime}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mtime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mtime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#posix_permissions DatasyncTask#posix_permissions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "posixPermissions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PosixPermissions
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#preserve_deleted_files DatasyncTask#preserve_deleted_files}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preserveDeletedFiles", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreserveDeletedFiles
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#preserve_devices DatasyncTask#preserve_devices}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preserveDevices", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreserveDevices
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#uid DatasyncTask#uid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#verify_mode DatasyncTask#verify_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "verifyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VerifyMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
