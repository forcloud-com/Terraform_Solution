using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiClass(nativeType: typeof(aws.Lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOutputReference), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LambdaFunctionEventInvokeConfigDestinationConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LambdaFunctionEventInvokeConfigDestinationConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunctionEventInvokeConfigDestinationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunctionEventInvokeConfigDestinationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOnFailure", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure\"}}]")]
        public virtual void PutOnFailure(aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOnSuccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess\"}}]")]
        public virtual void PutOnSuccess(aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOnFailure")]
        public virtual void ResetOnFailure()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnSuccess")]
        public virtual void ResetOnSuccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnFailureOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnFailureOutputReference OnFailure
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnFailureOutputReference>()!;
        }

        [JsiiProperty(name: "onSuccess", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccessOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccessOutputReference OnSuccess
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccessOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "onFailureInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure? OnFailureInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onSuccessInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess? OnSuccessInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfig\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
