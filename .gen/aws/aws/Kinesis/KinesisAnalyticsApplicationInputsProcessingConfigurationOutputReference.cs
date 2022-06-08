using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisAnalyticsApplicationInputsProcessingConfigurationOutputReference), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KinesisAnalyticsApplicationInputsProcessingConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KinesisAnalyticsApplicationInputsProcessingConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationInputsProcessingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationInputsProcessingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLambda", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfigurationLambda\"}}]")]
        public virtual void PutLambda(aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfigurationLambda @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfigurationLambda)}, new object[]{@value});
        }

        [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfigurationLambdaOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationInputsProcessingConfigurationLambdaOutputReference Lambda
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationInputsProcessingConfigurationLambdaOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfigurationLambda\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfigurationLambda? LambdaInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfigurationLambda?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
