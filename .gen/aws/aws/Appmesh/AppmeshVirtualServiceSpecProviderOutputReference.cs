using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualServiceSpecProviderOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualServiceSpecProviderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualServiceSpecProviderOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualServiceSpecProviderOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualServiceSpecProviderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualServiceSpecProviderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putVirtualNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualNode\"}}]")]
        public virtual void PutVirtualNode(aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVirtualRouter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualRouter\"}}]")]
        public virtual void PutVirtualRouter(aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualRouter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualRouter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetVirtualNode")]
        public virtual void ResetVirtualNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualRouter")]
        public virtual void ResetVirtualRouter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "virtualNode", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualNodeOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualServiceSpecProviderVirtualNodeOutputReference VirtualNode
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualServiceSpecProviderVirtualNodeOutputReference>()!;
        }

        [JsiiProperty(name: "virtualRouter", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualRouterOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualServiceSpecProviderVirtualRouterOutputReference VirtualRouter
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualServiceSpecProviderVirtualRouterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualNodeInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualNode\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualNode? VirtualNodeInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualRouterInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualRouter\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualRouter? VirtualRouterInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualRouter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProvider\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualServiceSpecProvider? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualServiceSpecProvider?>();
            set => SetInstanceProperty(value);
        }
    }
}
