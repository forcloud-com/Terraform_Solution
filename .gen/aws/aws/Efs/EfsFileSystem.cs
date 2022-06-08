using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system aws_efs_file_system}.</summary>
    [JsiiClass(nativeType: typeof(aws.Efs.EfsFileSystem), fullyQualifiedName: "aws.efs.EfsFileSystem", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.efs.EfsFileSystemConfig\"}}]")]
    public class EfsFileSystem : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system aws_efs_file_system} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EfsFileSystem(Constructs.Construct scope, string id, aws.Efs.IEfsFileSystemConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsFileSystem(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsFileSystem(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLifecyclePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.efs.EfsFileSystemLifecyclePolicy\"}}]")]
        public virtual void PutLifecyclePolicy(aws.Efs.IEfsFileSystemLifecyclePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Efs.IEfsFileSystemLifecyclePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCreationToken")]
        public virtual void ResetCreationToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncrypted")]
        public virtual void ResetEncrypted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyId")]
        public virtual void ResetKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLifecyclePolicy")]
        public virtual void ResetLifecyclePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPerformanceMode")]
        public virtual void ResetPerformanceMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProvisionedThroughputInMibps")]
        public virtual void ResetProvisionedThroughputInMibps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReferenceName")]
        public virtual void ResetReferenceName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThroughputMode")]
        public virtual void ResetThroughputMode()
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
        = GetStaticProperty<string>(typeof(aws.Efs.EfsFileSystem))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecyclePolicy", typeJson: "{\"fqn\":\"aws.efs.EfsFileSystemLifecyclePolicyOutputReference\"}")]
        public virtual aws.Efs.EfsFileSystemLifecyclePolicyOutputReference LifecyclePolicy
        {
            get => GetInstanceProperty<aws.Efs.EfsFileSystemLifecyclePolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "creationTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreationTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EncryptedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifecyclePolicyInput", typeJson: "{\"fqn\":\"aws.efs.EfsFileSystemLifecyclePolicy\"}", isOptional: true)]
        public virtual aws.Efs.IEfsFileSystemLifecyclePolicy? LifecyclePolicyInput
        {
            get => GetInstanceProperty<aws.Efs.IEfsFileSystemLifecyclePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "performanceModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PerformanceModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "provisionedThroughputInMibpsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ProvisionedThroughputInMibpsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "referenceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReferenceNameInput
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
        [JsiiProperty(name: "throughputModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ThroughputModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "creationToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Encrypted
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "performanceMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PerformanceMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "provisionedThroughputInMibps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionedThroughputInMibps
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "referenceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReferenceName
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

        [JsiiProperty(name: "throughputMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ThroughputMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
