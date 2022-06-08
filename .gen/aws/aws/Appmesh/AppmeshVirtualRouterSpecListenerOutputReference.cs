using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualRouterSpecListenerOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualRouterSpecListenerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualRouterSpecListenerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualRouterSpecListenerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualRouterSpecListenerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualRouterSpecListenerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPortMapping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListenerPortMapping\"}}]")]
        public virtual void PutPortMapping(aws.Appmesh.IAppmeshVirtualRouterSpecListenerPortMapping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualRouterSpecListenerPortMapping)}, new object[]{@value});
        }

        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListenerPortMappingOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualRouterSpecListenerPortMappingOutputReference PortMapping
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualRouterSpecListenerPortMappingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "portMappingInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListenerPortMapping\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualRouterSpecListenerPortMapping? PortMappingInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualRouterSpecListenerPortMapping?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListener\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualRouterSpecListener? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualRouterSpecListener?>();
            set => SetInstanceProperty(value);
        }
    }
}
