using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualServiceSpecOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualServiceSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualServiceSpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualServiceSpecOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualServiceSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualServiceSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putProvider", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProvider\"}}]")]
        public virtual void PutProvider(aws.Appmesh.IAppmeshVirtualServiceSpecProvider @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualServiceSpecProvider)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetProvider")]
        public virtual void ResetProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProviderOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualServiceSpecProviderOutputReference Provider
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualServiceSpecProviderOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "providerInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProvider\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualServiceSpecProvider? ProviderInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualServiceSpecProvider?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpec\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualServiceSpec? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualServiceSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
