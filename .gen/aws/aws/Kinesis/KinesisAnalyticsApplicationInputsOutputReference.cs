using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisAnalyticsApplicationInputsOutputReference), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KinesisAnalyticsApplicationInputsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KinesisAnalyticsApplicationInputsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationInputsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationInputsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKinesisFirehose", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsKinesisFirehose\"}}]")]
        public virtual void PutKinesisFirehose(aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisFirehose @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisFirehose)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesisStream", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsKinesisStream\"}}]")]
        public virtual void PutKinesisStream(aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisStream @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisStream)}, new object[]{@value});
        }

        [JsiiMethod(name: "putParallelism", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsParallelism\"}}]")]
        public virtual void PutParallelism(aws.Kinesis.IKinesisAnalyticsApplicationInputsParallelism @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationInputsParallelism)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProcessingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfiguration\"}}]")]
        public virtual void PutProcessingConfiguration(aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchema", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchema\"}}]")]
        public virtual void PutSchema(aws.Kinesis.IKinesisAnalyticsApplicationInputsSchema @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationInputsSchema)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKinesisFirehose")]
        public virtual void ResetKinesisFirehose()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisStream")]
        public virtual void ResetKinesisStream()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParallelism")]
        public virtual void ResetParallelism()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProcessingConfiguration")]
        public virtual void ResetProcessingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsKinesisFirehoseOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationInputsKinesisFirehoseOutputReference KinesisFirehose
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationInputsKinesisFirehoseOutputReference>()!;
        }

        [JsiiProperty(name: "kinesisStream", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsKinesisStreamOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationInputsKinesisStreamOutputReference KinesisStream
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationInputsKinesisStreamOutputReference>()!;
        }

        [JsiiProperty(name: "parallelism", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsParallelismOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationInputsParallelismOutputReference Parallelism
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationInputsParallelismOutputReference>()!;
        }

        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfigurationOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationInputsProcessingConfigurationOutputReference ProcessingConfiguration
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationInputsProcessingConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationInputsSchemaOutputReference Schema
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationInputsSchemaOutputReference>()!;
        }

        [JsiiProperty(name: "startingPositionConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsStartingPositionConfigurationList\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationInputsStartingPositionConfigurationList StartingPositionConfiguration
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationInputsStartingPositionConfigurationList>()!;
        }

        [JsiiProperty(name: "streamNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] StreamNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisFirehoseInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsKinesisFirehose\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisFirehose? KinesisFirehoseInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisFirehose?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisStreamInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsKinesisStream\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisStream? KinesisStreamInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisStream?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parallelismInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsParallelism\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsParallelism? ParallelismInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsParallelism?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processingConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfiguration\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfiguration? ProcessingConfigurationInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchema\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsSchema? SchemaInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsSchema?>();
        }

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputs\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputs? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputs?>();
            set => SetInstanceProperty(value);
        }
    }
}
