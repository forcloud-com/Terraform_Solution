using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecLoggingOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecLoggingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualNodeSpecLoggingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualNodeSpecLoggingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecLoggingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecLoggingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccessLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLog\"}}]")]
        public virtual void PutAccessLog(aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLog)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessLog")]
        public virtual void ResetAccessLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLogOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecLoggingAccessLogOutputReference AccessLog
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecLoggingAccessLogOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessLogInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLoggingAccessLog\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLog? AccessLogInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecLoggingAccessLog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLogging\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecLogging? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecLogging?>();
            set => SetInstanceProperty(value);
        }
    }
}
