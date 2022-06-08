using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    [JsiiClass(nativeType: typeof(aws.Efs.EfsFileSystemLifecyclePolicyOutputReference), fullyQualifiedName: "aws.efs.EfsFileSystemLifecyclePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EfsFileSystemLifecyclePolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EfsFileSystemLifecyclePolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsFileSystemLifecyclePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsFileSystemLifecyclePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitionToIaInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransitionToIaInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "transitionToIa", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransitionToIa
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.efs.EfsFileSystemLifecyclePolicy\"}", isOptional: true)]
        public virtual aws.Efs.IEfsFileSystemLifecyclePolicy? InternalValue
        {
            get => GetInstanceProperty<aws.Efs.IEfsFileSystemLifecyclePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
