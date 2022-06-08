using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    [JsiiClass(nativeType: typeof(aws.Efs.EfsAccessPointRootDirectoryOutputReference), fullyQualifiedName: "aws.efs.EfsAccessPointRootDirectoryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EfsAccessPointRootDirectoryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EfsAccessPointRootDirectoryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsAccessPointRootDirectoryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsAccessPointRootDirectoryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCreationInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.efs.EfsAccessPointRootDirectoryCreationInfo\"}}]")]
        public virtual void PutCreationInfo(aws.Efs.IEfsAccessPointRootDirectoryCreationInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Efs.IEfsAccessPointRootDirectoryCreationInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCreationInfo")]
        public virtual void ResetCreationInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPath")]
        public virtual void ResetPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "creationInfo", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointRootDirectoryCreationInfoOutputReference\"}")]
        public virtual aws.Efs.EfsAccessPointRootDirectoryCreationInfoOutputReference CreationInfo
        {
            get => GetInstanceProperty<aws.Efs.EfsAccessPointRootDirectoryCreationInfoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "creationInfoInput", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointRootDirectoryCreationInfo\"}", isOptional: true)]
        public virtual aws.Efs.IEfsAccessPointRootDirectoryCreationInfo? CreationInfoInput
        {
            get => GetInstanceProperty<aws.Efs.IEfsAccessPointRootDirectoryCreationInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointRootDirectory\"}", isOptional: true)]
        public virtual aws.Efs.IEfsAccessPointRootDirectory? InternalValue
        {
            get => GetInstanceProperty<aws.Efs.IEfsAccessPointRootDirectory?>();
            set => SetInstanceProperty(value);
        }
    }
}
