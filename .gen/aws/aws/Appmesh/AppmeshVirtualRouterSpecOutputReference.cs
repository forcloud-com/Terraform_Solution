using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualRouterSpecOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualRouterSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualRouterSpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualRouterSpecOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualRouterSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualRouterSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putListener", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListener\"}}]")]
        public virtual void PutListener(aws.Appmesh.IAppmeshVirtualRouterSpecListener @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualRouterSpecListener)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetServiceNames")]
        public virtual void ResetServiceNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "listener", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListenerOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualRouterSpecListenerOutputReference Listener
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualRouterSpecListenerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "listenerInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListener\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualRouterSpecListener? ListenerInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualRouterSpecListener?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ServiceNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "serviceNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ServiceNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpec\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualRouterSpec? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualRouterSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
