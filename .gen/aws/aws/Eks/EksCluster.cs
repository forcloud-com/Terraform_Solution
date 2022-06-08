using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster aws_eks_cluster}.</summary>
    [JsiiClass(nativeType: typeof(aws.Eks.EksCluster), fullyQualifiedName: "aws.eks.EksCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.eks.EksClusterConfig\"}}]")]
    public class EksCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster aws_eks_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EksCluster(Constructs.Construct scope, string id, aws.Eks.IEksClusterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksCluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEncryptionConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eks.EksClusterEncryptionConfig\"}}]")]
        public virtual void PutEncryptionConfig(aws.Eks.IEksClusterEncryptionConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eks.IEksClusterEncryptionConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eks.EksClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Eks.IEksClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eks.IEksClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eks.EksClusterVpcConfig\"}}]")]
        public virtual void PutVpcConfig(aws.Eks.IEksClusterVpcConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eks.IEksClusterVpcConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnabledClusterLogTypes")]
        public virtual void ResetEnabledClusterLogTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionConfig")]
        public virtual void ResetEncryptionConfig()
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

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
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
        = GetStaticProperty<string>(typeof(aws.Eks.EksCluster))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateAuthority", typeJson: "{\"fqn\":\"aws.eks.EksClusterCertificateAuthorityList\"}")]
        public virtual aws.Eks.EksClusterCertificateAuthorityList CertificateAuthority
        {
            get => GetInstanceProperty<aws.Eks.EksClusterCertificateAuthorityList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionConfig", typeJson: "{\"fqn\":\"aws.eks.EksClusterEncryptionConfigOutputReference\"}")]
        public virtual aws.Eks.EksClusterEncryptionConfigOutputReference EncryptionConfig
        {
            get => GetInstanceProperty<aws.Eks.EksClusterEncryptionConfigOutputReference>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"aws.eks.EksClusterIdentityList\"}")]
        public virtual aws.Eks.EksClusterIdentityList Identity
        {
            get => GetInstanceProperty<aws.Eks.EksClusterIdentityList>()!;
        }

        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.eks.EksClusterTimeoutsOutputReference\"}")]
        public virtual aws.Eks.EksClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Eks.EksClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.eks.EksClusterVpcConfigOutputReference\"}")]
        public virtual aws.Eks.EksClusterVpcConfigOutputReference VpcConfig
        {
            get => GetInstanceProperty<aws.Eks.EksClusterVpcConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledClusterLogTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EnabledClusterLogTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfigInput", typeJson: "{\"fqn\":\"aws.eks.EksClusterEncryptionConfig\"}", isOptional: true)]
        public virtual aws.Eks.IEksClusterEncryptionConfig? EncryptionConfigInput
        {
            get => GetInstanceProperty<aws.Eks.IEksClusterEncryptionConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.eks.EksClusterTimeouts\"}", isOptional: true)]
        public virtual aws.Eks.IEksClusterTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Eks.IEksClusterTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"fqn\":\"aws.eks.EksClusterVpcConfig\"}", isOptional: true)]
        public virtual aws.Eks.IEksClusterVpcConfig? VpcConfigInput
        {
            get => GetInstanceProperty<aws.Eks.IEksClusterVpcConfig?>();
        }

        [JsiiProperty(name: "enabledClusterLogTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledClusterLogTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
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

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
