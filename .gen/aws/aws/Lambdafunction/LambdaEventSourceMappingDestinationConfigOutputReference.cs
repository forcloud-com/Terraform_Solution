using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiClass(nativeType: typeof(aws.Lambdafunction.LambdaEventSourceMappingDestinationConfigOutputReference), fullyQualifiedName: "aws.lambdafunction.LambdaEventSourceMappingDestinationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LambdaEventSourceMappingDestinationConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LambdaEventSourceMappingDestinationConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaEventSourceMappingDestinationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaEventSourceMappingDestinationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOnFailure", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfigOnFailure\"}}]")]
        public virtual void PutOnFailure(aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfigOnFailure @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfigOnFailure)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOnFailure")]
        public virtual void ResetOnFailure()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfigOnFailureOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaEventSourceMappingDestinationConfigOnFailureOutputReference OnFailure
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaEventSourceMappingDestinationConfigOnFailureOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "onFailureInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfigOnFailure\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfigOnFailure? OnFailureInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfigOnFailure?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfig\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
