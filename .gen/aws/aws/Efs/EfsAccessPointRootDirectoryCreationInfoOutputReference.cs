using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    [JsiiClass(nativeType: typeof(aws.Efs.EfsAccessPointRootDirectoryCreationInfoOutputReference), fullyQualifiedName: "aws.efs.EfsAccessPointRootDirectoryCreationInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EfsAccessPointRootDirectoryCreationInfoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EfsAccessPointRootDirectoryCreationInfoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsAccessPointRootDirectoryCreationInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsAccessPointRootDirectoryCreationInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerGidInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OwnerGidInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerUidInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OwnerUidInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PermissionsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "ownerGid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OwnerGid
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ownerUid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OwnerUid
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Permissions
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointRootDirectoryCreationInfo\"}", isOptional: true)]
        public virtual aws.Efs.IEfsAccessPointRootDirectoryCreationInfo? InternalValue
        {
            get => GetInstanceProperty<aws.Efs.IEfsAccessPointRootDirectoryCreationInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
