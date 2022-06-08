using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshRouteSpecTcpRouteOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecTcpRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshRouteSpecTcpRouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshRouteSpecTcpRouteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecTcpRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecTcpRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteAction\"}}]")]
        public virtual void PutAction(aws.Appmesh.IAppmeshRouteSpecTcpRouteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecTcpRouteAction)}, new object[]{@value});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteActionOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecTcpRouteActionOutputReference Action
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecTcpRouteActionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteAction\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecTcpRouteAction? ActionInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecTcpRouteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRoute\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecTcpRoute? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecTcpRoute?>();
            set => SetInstanceProperty(value);
        }
    }
}
