using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorAction), fullyQualifiedName: "aws.iot.IotTopicRuleErrorAction")]
    public interface IIotTopicRuleErrorAction
    {
        /// <summary>cloudwatch_alarm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#cloudwatch_alarm IotTopicRule#cloudwatch_alarm}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionCloudwatchAlarm\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionCloudwatchAlarm? CloudwatchAlarm
        {
            get
            {
                return null;
            }
        }

        /// <summary>cloudwatch_metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#cloudwatch_metric IotTopicRule#cloudwatch_metric}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionCloudwatchMetric\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionCloudwatchMetric? CloudwatchMetric
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamodb block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#dynamodb IotTopicRule#dynamodb}
        /// </remarks>
        [JsiiProperty(name: "dynamodb", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionDynamodb\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionDynamodb? Dynamodb
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamodbv2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#dynamodbv2 IotTopicRule#dynamodbv2}
        /// </remarks>
        [JsiiProperty(name: "dynamodbv2", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionDynamodbv2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionDynamodbv2? Dynamodbv2
        {
            get
            {
                return null;
            }
        }

        /// <summary>elasticsearch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#elasticsearch IotTopicRule#elasticsearch}
        /// </remarks>
        [JsiiProperty(name: "elasticsearch", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionElasticsearch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionElasticsearch? Elasticsearch
        {
            get
            {
                return null;
            }
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#firehose IotTopicRule#firehose}
        /// </remarks>
        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionFirehose\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionFirehose? Firehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>iot_analytics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#iot_analytics IotTopicRule#iot_analytics}
        /// </remarks>
        [JsiiProperty(name: "iotAnalytics", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionIotAnalytics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionIotAnalytics? IotAnalytics
        {
            get
            {
                return null;
            }
        }

        /// <summary>iot_events block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#iot_events IotTopicRule#iot_events}
        /// </remarks>
        [JsiiProperty(name: "iotEvents", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionIotEvents\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionIotEvents? IotEvents
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#kinesis IotTopicRule#kinesis}
        /// </remarks>
        [JsiiProperty(name: "kinesis", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionKinesis\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionKinesis? Kinesis
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#lambda IotTopicRule#lambda}
        /// </remarks>
        [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionLambda\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionLambda? Lambda
        {
            get
            {
                return null;
            }
        }

        /// <summary>republish block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#republish IotTopicRule#republish}
        /// </remarks>
        [JsiiProperty(name: "republish", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionRepublish\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionRepublish? Republish
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#s3 IotTopicRule#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionS3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionS3? S3
        {
            get
            {
                return null;
            }
        }

        /// <summary>sns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sns IotTopicRule#sns}
        /// </remarks>
        [JsiiProperty(name: "sns", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionSns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionSns? Sns
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sqs IotTopicRule#sqs}
        /// </remarks>
        [JsiiProperty(name: "sqs", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionSqs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionSqs? Sqs
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_functions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#step_functions IotTopicRule#step_functions}
        /// </remarks>
        [JsiiProperty(name: "stepFunctions", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionStepFunctions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorActionStepFunctions? StepFunctions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorAction), fullyQualifiedName: "aws.iot.IotTopicRuleErrorAction")]
        internal sealed class _Proxy : DeputyBase, aws.Iot.IIotTopicRuleErrorAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_alarm block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#cloudwatch_alarm IotTopicRule#cloudwatch_alarm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionCloudwatchAlarm\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionCloudwatchAlarm? CloudwatchAlarm
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionCloudwatchAlarm?>();
            }

            /// <summary>cloudwatch_metric block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#cloudwatch_metric IotTopicRule#cloudwatch_metric}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionCloudwatchMetric\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionCloudwatchMetric? CloudwatchMetric
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionCloudwatchMetric?>();
            }

            /// <summary>dynamodb block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#dynamodb IotTopicRule#dynamodb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodb", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionDynamodb\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionDynamodb? Dynamodb
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionDynamodb?>();
            }

            /// <summary>dynamodbv2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#dynamodbv2 IotTopicRule#dynamodbv2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodbv2", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionDynamodbv2\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionDynamodbv2? Dynamodbv2
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionDynamodbv2?>();
            }

            /// <summary>elasticsearch block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#elasticsearch IotTopicRule#elasticsearch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "elasticsearch", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionElasticsearch\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionElasticsearch? Elasticsearch
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionElasticsearch?>();
            }

            /// <summary>firehose block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#firehose IotTopicRule#firehose}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionFirehose\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionFirehose? Firehose
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionFirehose?>();
            }

            /// <summary>iot_analytics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#iot_analytics IotTopicRule#iot_analytics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iotAnalytics", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionIotAnalytics\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionIotAnalytics? IotAnalytics
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionIotAnalytics?>();
            }

            /// <summary>iot_events block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#iot_events IotTopicRule#iot_events}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iotEvents", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionIotEvents\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionIotEvents? IotEvents
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionIotEvents?>();
            }

            /// <summary>kinesis block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#kinesis IotTopicRule#kinesis}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesis", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionKinesis\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionKinesis? Kinesis
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionKinesis?>();
            }

            /// <summary>lambda block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#lambda IotTopicRule#lambda}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionLambda\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionLambda? Lambda
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionLambda?>();
            }

            /// <summary>republish block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#republish IotTopicRule#republish}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "republish", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionRepublish\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionRepublish? Republish
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionRepublish?>();
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#s3 IotTopicRule#s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionS3\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionS3? S3
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionS3?>();
            }

            /// <summary>sns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sns IotTopicRule#sns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sns", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionSns\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionSns? Sns
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionSns?>();
            }

            /// <summary>sqs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sqs IotTopicRule#sqs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqs", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionSqs\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionSqs? Sqs
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionSqs?>();
            }

            /// <summary>step_functions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#step_functions IotTopicRule#step_functions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepFunctions", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionStepFunctions\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorActionStepFunctions? StepFunctions
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorActionStepFunctions?>();
            }
        }
    }
}
