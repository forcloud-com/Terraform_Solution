using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiClass(nativeType: typeof(aws.Iot.IotTopicRuleErrorActionOutputReference), fullyQualifiedName: "aws.iot.IotTopicRuleErrorActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotTopicRuleErrorActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotTopicRuleErrorActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRuleErrorActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRuleErrorActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchAlarm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionCloudwatchAlarm\"}}]")]
        public virtual void PutCloudwatchAlarm(aws.Iot.IIotTopicRuleErrorActionCloudwatchAlarm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionCloudwatchAlarm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCloudwatchMetric", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionCloudwatchMetric\"}}]")]
        public virtual void PutCloudwatchMetric(aws.Iot.IIotTopicRuleErrorActionCloudwatchMetric @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionCloudwatchMetric)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDynamodb", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionDynamodb\"}}]")]
        public virtual void PutDynamodb(aws.Iot.IIotTopicRuleErrorActionDynamodb @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionDynamodb)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDynamodbv2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionDynamodbv2\"}}]")]
        public virtual void PutDynamodbv2(aws.Iot.IIotTopicRuleErrorActionDynamodbv2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionDynamodbv2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putElasticsearch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionElasticsearch\"}}]")]
        public virtual void PutElasticsearch(aws.Iot.IIotTopicRuleErrorActionElasticsearch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionElasticsearch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFirehose", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionFirehose\"}}]")]
        public virtual void PutFirehose(aws.Iot.IIotTopicRuleErrorActionFirehose @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionFirehose)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIotAnalytics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionIotAnalytics\"}}]")]
        public virtual void PutIotAnalytics(aws.Iot.IIotTopicRuleErrorActionIotAnalytics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionIotAnalytics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIotEvents", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionIotEvents\"}}]")]
        public virtual void PutIotEvents(aws.Iot.IIotTopicRuleErrorActionIotEvents @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionIotEvents)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesis", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionKinesis\"}}]")]
        public virtual void PutKinesis(aws.Iot.IIotTopicRuleErrorActionKinesis @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionKinesis)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambda", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionLambda\"}}]")]
        public virtual void PutLambda(aws.Iot.IIotTopicRuleErrorActionLambda @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionLambda)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRepublish", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionRepublish\"}}]")]
        public virtual void PutRepublish(aws.Iot.IIotTopicRuleErrorActionRepublish @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionRepublish)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionS3\"}}]")]
        public virtual void PutS3(aws.Iot.IIotTopicRuleErrorActionS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionS3)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionSns\"}}]")]
        public virtual void PutSns(aws.Iot.IIotTopicRuleErrorActionSns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionSns)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionSqs\"}}]")]
        public virtual void PutSqs(aws.Iot.IIotTopicRuleErrorActionSqs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionSqs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepFunctions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorActionStepFunctions\"}}]")]
        public virtual void PutStepFunctions(aws.Iot.IIotTopicRuleErrorActionStepFunctions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorActionStepFunctions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchAlarm")]
        public virtual void ResetCloudwatchAlarm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudwatchMetric")]
        public virtual void ResetCloudwatchMetric()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodb")]
        public virtual void ResetDynamodb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodbv2")]
        public virtual void ResetDynamodbv2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearch")]
        public virtual void ResetElasticsearch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirehose")]
        public virtual void ResetFirehose()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIotAnalytics")]
        public virtual void ResetIotAnalytics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIotEvents")]
        public virtual void ResetIotEvents()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesis")]
        public virtual void ResetKinesis()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambda")]
        public virtual void ResetLambda()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepublish")]
        public virtual void ResetRepublish()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3")]
        public virtual void ResetS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSns")]
        public virtual void ResetSns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqs")]
        public virtual void ResetSqs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepFunctions")]
        public virtual void ResetStepFunctions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionCloudwatchAlarmOutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionCloudwatchAlarmOutputReference CloudwatchAlarm
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionCloudwatchAlarmOutputReference>()!;
        }

        [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionCloudwatchMetricOutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionCloudwatchMetricOutputReference CloudwatchMetric
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionCloudwatchMetricOutputReference>()!;
        }

        [JsiiProperty(name: "dynamodb", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionDynamodbOutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionDynamodbOutputReference Dynamodb
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionDynamodbOutputReference>()!;
        }

        [JsiiProperty(name: "dynamodbv2", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionDynamodbv2OutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionDynamodbv2OutputReference Dynamodbv2
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionDynamodbv2OutputReference>()!;
        }

        [JsiiProperty(name: "elasticsearch", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionElasticsearchOutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionElasticsearchOutputReference Elasticsearch
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionElasticsearchOutputReference>()!;
        }

        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionFirehoseOutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionFirehoseOutputReference Firehose
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionFirehoseOutputReference>()!;
        }

        [JsiiProperty(name: "iotAnalytics", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionIotAnalyticsOutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionIotAnalyticsOutputReference IotAnalytics
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionIotAnalyticsOutputReference>()!;
        }

        [JsiiProperty(name: "iotEvents", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionIotEventsOutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionIotEventsOutputReference IotEvents
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionIotEventsOutputReference>()!;
        }

        [JsiiProperty(name: "kinesis", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionKinesisOutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionKinesisOutputReference Kinesis
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionKinesisOutputReference>()!;
        }

        [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionLambdaOutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionLambdaOutputReference Lambda
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionLambdaOutputReference>()!;
        }

        [JsiiProperty(name: "republish", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionRepublishOutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionRepublishOutputReference Republish
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionRepublishOutputReference>()!;
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionS3OutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionS3OutputReference S3
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionS3OutputReference>()!;
        }

        [JsiiProperty(name: "sns", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionSnsOutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionSnsOutputReference Sns
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionSnsOutputReference>()!;
        }

        [JsiiProperty(name: "sqs", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionSqsOutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionSqsOutputReference Sqs
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionSqsOutputReference>()!;
        }

        [JsiiProperty(name: "stepFunctions", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionStepFunctionsOutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionStepFunctionsOutputReference StepFunctions
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionStepFunctionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchAlarmInput", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionCloudwatchAlarm\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionCloudwatchAlarm? CloudwatchAlarmInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionCloudwatchAlarm?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchMetricInput", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionCloudwatchMetric\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionCloudwatchMetric? CloudwatchMetricInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionCloudwatchMetric?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbInput", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionDynamodb\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionDynamodb? DynamodbInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionDynamodb?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbv2Input", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionDynamodbv2\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionDynamodbv2? Dynamodbv2Input
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionDynamodbv2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchInput", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionElasticsearch\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionElasticsearch? ElasticsearchInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionElasticsearch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firehoseInput", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionFirehose\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionFirehose? FirehoseInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionFirehose?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iotAnalyticsInput", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionIotAnalytics\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionIotAnalytics? IotAnalyticsInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionIotAnalytics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iotEventsInput", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionIotEvents\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionIotEvents? IotEventsInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionIotEvents?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisInput", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionKinesis\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionKinesis? KinesisInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionKinesis?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaInput", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionLambda\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionLambda? LambdaInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionLambda?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "republishInput", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionRepublish\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionRepublish? RepublishInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionRepublish?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionS3\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionS3? S3Input
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snsInput", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionSns\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionSns? SnsInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionSns?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqsInput", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionSqs\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionSqs? SqsInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionSqs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepFunctionsInput", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionStepFunctions\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorActionStepFunctions? StepFunctionsInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionStepFunctions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorAction\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorAction? InternalValue
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
