using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshRouteSpecHttpRouteOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshRouteSpecHttpRouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshRouteSpecHttpRouteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteAction\"}}]")]
        public virtual void PutAction(aws.Appmesh.IAppmeshRouteSpecHttpRouteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttpRouteAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatch\"}}]")]
        public virtual void PutMatch(aws.Appmesh.IAppmeshRouteSpecHttpRouteMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttpRouteMatch)}, new object[]{@value});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteActionOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttpRouteActionOutputReference Action
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttpRouteActionOutputReference>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatchOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttpRouteMatchOutputReference Match
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttpRouteMatchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteAction\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteAction? ActionInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteMatch\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteMatch? MatchInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRoute\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRoute? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRoute?>();
            set => SetInstanceProperty(value);
        }
    }
}
