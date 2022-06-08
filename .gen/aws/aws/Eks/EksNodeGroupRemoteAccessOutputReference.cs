using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiClass(nativeType: typeof(aws.Eks.EksNodeGroupRemoteAccessOutputReference), fullyQualifiedName: "aws.eks.EksNodeGroupRemoteAccessOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksNodeGroupRemoteAccessOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksNodeGroupRemoteAccessOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksNodeGroupRemoteAccessOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksNodeGroupRemoteAccessOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEc2SshKey")]
        public virtual void ResetEc2SshKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceSecurityGroupIds")]
        public virtual void ResetSourceSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2SshKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ec2SshKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceSecurityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SourceSecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "ec2SshKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ec2SshKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SourceSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupRemoteAccess\"}", isOptional: true)]
        public virtual aws.Eks.IEksNodeGroupRemoteAccess? InternalValue
        {
            get => GetInstanceProperty<aws.Eks.IEksNodeGroupRemoteAccess?>();
            set => SetInstanceProperty(value);
        }
    }
}
