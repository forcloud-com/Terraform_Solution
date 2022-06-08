using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecLoggingAccessLogOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLogOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualNodeSpecLoggingAccessLogOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualNodeSpecLoggingAccessLogOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecLoggingAccessLogOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecLoggingAccessLogOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLogFile\"}}]")]
        public virtual void PutFile(aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLogFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLogFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFile")]
        public virtual void ResetFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLogFileOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecLoggingAccessLogFileOutputReference File
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecLoggingAccessLogFileOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLogFile\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLogFile? FileInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLogFile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLog\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLog? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLog?>();
            set => SetInstanceProperty(value);
        }
    }
}
