using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshMeshSpecOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshMeshSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshMeshSpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshMeshSpecOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshMeshSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshMeshSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEgressFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshMeshSpecEgressFilter\"}}]")]
        public virtual void PutEgressFilter(aws.Appmesh.IAppmeshMeshSpecEgressFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshMeshSpecEgressFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEgressFilter")]
        public virtual void ResetEgressFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "egressFilter", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshMeshSpecEgressFilterOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshMeshSpecEgressFilterOutputReference EgressFilter
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshMeshSpecEgressFilterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "egressFilterInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshMeshSpecEgressFilter\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshMeshSpecEgressFilter? EgressFilterInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshMeshSpecEgressFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshMeshSpec\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshMeshSpec? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshMeshSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
