using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiClass(nativeType: typeof(aws.Ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationOutputReference), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsTaskDefinitionVolumeEfsVolumeConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsTaskDefinitionVolumeEfsVolumeConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinitionVolumeEfsVolumeConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinitionVolumeEfsVolumeConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuthorizationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig\"}}]")]
        public virtual void PutAuthorizationConfig(aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthorizationConfig")]
        public virtual void ResetAuthorizationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootDirectory")]
        public virtual void ResetRootDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransitEncryption")]
        public virtual void ResetTransitEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransitEncryptionPort")]
        public virtual void ResetTransitEncryptionPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "authorizationConfig", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfigOutputReference\"}")]
        public virtual aws.Ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfigOutputReference AuthorizationConfig
        {
            get => GetInstanceProperty<aws.Ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationConfigInput", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig? AuthorizationConfigInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileSystemIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDirectoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RootDirectoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitEncryptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransitEncryptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitEncryptionPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TransitEncryptionPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDirectory
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transitEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransitEncryption
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transitEncryptionPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TransitEncryptionPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfiguration\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
