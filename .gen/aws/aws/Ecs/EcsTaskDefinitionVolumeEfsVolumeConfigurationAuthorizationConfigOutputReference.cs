using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiClass(nativeType: typeof(aws.Ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfigOutputReference), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccessPointId")]
        public virtual void ResetAccessPointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIam")]
        public virtual void ResetIam()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessPointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessPointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IamInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accessPointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessPointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iam", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Iam
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
