using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    [JsiiClass(nativeType: typeof(aws.Batch.BatchJobDefinitionRetryStrategyOutputReference), fullyQualifiedName: "aws.batch.BatchJobDefinitionRetryStrategyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BatchJobDefinitionRetryStrategyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BatchJobDefinitionRetryStrategyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchJobDefinitionRetryStrategyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchJobDefinitionRetryStrategyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAttempts")]
        public virtual void ResetAttempts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "attemptsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AttemptsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Attempts
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.batch.BatchJobDefinitionRetryStrategy\"}", isOptional: true)]
        public virtual aws.Batch.IBatchJobDefinitionRetryStrategy? InternalValue
        {
            get => GetInstanceProperty<aws.Batch.IBatchJobDefinitionRetryStrategy?>();
            set => SetInstanceProperty(value);
        }
    }
}
