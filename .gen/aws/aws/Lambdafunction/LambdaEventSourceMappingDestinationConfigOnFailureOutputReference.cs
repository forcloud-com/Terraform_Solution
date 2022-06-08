using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiClass(nativeType: typeof(aws.Lambdafunction.LambdaEventSourceMappingDestinationConfigOnFailureOutputReference), fullyQualifiedName: "aws.lambdafunction.LambdaEventSourceMappingDestinationConfigOnFailureOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LambdaEventSourceMappingDestinationConfigOnFailureOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LambdaEventSourceMappingDestinationConfigOnFailureOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaEventSourceMappingDestinationConfigOnFailureOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaEventSourceMappingDestinationConfigOnFailureOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfigOnFailure\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfigOnFailure? InternalValue
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfigOnFailure?>();
            set => SetInstanceProperty(value);
        }
    }
}
