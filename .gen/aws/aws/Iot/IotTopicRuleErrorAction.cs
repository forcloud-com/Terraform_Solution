using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiByValue(fqn: "aws.iot.IotTopicRuleErrorAction")]
    public class IotTopicRuleErrorAction : aws.Iot.IIotTopicRuleErrorAction
    {
        /// <summary>cloudwatch_alarm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#cloudwatch_alarm IotTopicRule#cloudwatch_alarm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionCloudwatchAlarm\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionCloudwatchAlarm? CloudwatchAlarm
        {
            get;
            set;
        }

        /// <summary>cloudwatch_metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#cloudwatch_metric IotTopicRule#cloudwatch_metric}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionCloudwatchMetric\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionCloudwatchMetric? CloudwatchMetric
        {
            get;
            set;
        }

        /// <summary>dynamodb block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#dynamodb IotTopicRule#dynamodb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dynamodb", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionDynamodb\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionDynamodb? Dynamodb
        {
            get;
            set;
        }

        /// <summary>dynamodbv2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#dynamodbv2 IotTopicRule#dynamodbv2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dynamodbv2", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionDynamodbv2\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionDynamodbv2? Dynamodbv2
        {
            get;
            set;
        }

        /// <summary>elasticsearch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#elasticsearch IotTopicRule#elasticsearch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "elasticsearch", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionElasticsearch\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionElasticsearch? Elasticsearch
        {
            get;
            set;
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#firehose IotTopicRule#firehose}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionFirehose\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionFirehose? Firehose
        {
            get;
            set;
        }

        /// <summary>iot_analytics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#iot_analytics IotTopicRule#iot_analytics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iotAnalytics", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionIotAnalytics\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionIotAnalytics? IotAnalytics
        {
            get;
            set;
        }

        /// <summary>iot_events block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#iot_events IotTopicRule#iot_events}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iotEvents", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionIotEvents\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionIotEvents? IotEvents
        {
            get;
            set;
        }

        /// <summary>kinesis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#kinesis IotTopicRule#kinesis}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesis", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionKinesis\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionKinesis? Kinesis
        {
            get;
            set;
        }

        /// <summary>lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#lambda IotTopicRule#lambda}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionLambda\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionLambda? Lambda
        {
            get;
            set;
        }

        /// <summary>republish block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#republish IotTopicRule#republish}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "republish", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionRepublish\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionRepublish? Republish
        {
            get;
            set;
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#s3 IotTopicRule#s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionS3\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionS3? S3
        {
            get;
            set;
        }

        /// <summary>sns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sns IotTopicRule#sns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sns", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionSns\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionSns? Sns
        {
            get;
            set;
        }

        /// <summary>sqs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sqs IotTopicRule#sqs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqs", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionSqs\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionSqs? Sqs
        {
            get;
            set;
        }

        /// <summary>step_functions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#step_functions IotTopicRule#step_functions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepFunctions", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionStepFunctions\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorActionStepFunctions? StepFunctions
        {
            get;
            set;
        }
    }
}
