using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshRouteSpecOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshRouteSpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshRouteSpecOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHttpRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRoute\"}}]")]
        public virtual void PutHttpRoute(aws.Appmesh.IAppmeshRouteSpecHttpRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttpRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcpRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRoute\"}}]")]
        public virtual void PutTcpRoute(aws.Appmesh.IAppmeshRouteSpecTcpRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecTcpRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHttpRoute")]
        public virtual void ResetHttpRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriority")]
        public virtual void ResetPriority()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTcpRoute")]
        public virtual void ResetTcpRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttpRouteOutputReference HttpRoute
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttpRouteOutputReference>()!;
        }

        [JsiiProperty(name: "tcpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecTcpRouteOutputReference TcpRoute
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecTcpRouteOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRouteInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRoute\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRoute? HttpRouteInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRoute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PriorityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcpRouteInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRoute\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecTcpRoute? TcpRouteInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecTcpRoute?>();
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpec\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpec? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
