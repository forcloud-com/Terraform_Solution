using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecListenerOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualNodeSpecListenerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualNodeSpecListenerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHealthCheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerHealthCheck\"}}]")]
        public virtual void PutHealthCheck(aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPortMapping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerPortMapping\"}}]")]
        public virtual void PutPortMapping(aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHealthCheck")]
        public virtual void ResetHealthCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerHealthCheckOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerHealthCheckOutputReference HealthCheck
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerHealthCheckOutputReference>()!;
        }

        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerPortMappingOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerPortMappingOutputReference PortMapping
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerPortMappingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerHealthCheck\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck? HealthCheckInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portMappingInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerPortMapping\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping? PortMappingInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListener\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListener? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListener?>();
            set => SetInstanceProperty(value);
        }
    }
}
