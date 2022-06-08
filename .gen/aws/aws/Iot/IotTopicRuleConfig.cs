using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    #pragma warning disable CS8618

    /// <summary>AWS IoT.</summary>
    [JsiiByValue(fqn: "aws.iot.IotTopicRuleConfig")]
    public class IotTopicRuleConfig : aws.Iot.IIotTopicRuleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#enabled IotTopicRule#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#name IotTopicRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sql IotTopicRule#sql}.</summary>
        [JsiiProperty(name: "sql", typeJson: "{\"primitive\":\"string\"}")]
        public string Sql
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sql_version IotTopicRule#sql_version}.</summary>
        [JsiiProperty(name: "sqlVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string SqlVersion
        {
            get;
            set;
        }

        /// <summary>cloudwatch_alarm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#cloudwatch_alarm IotTopicRule#cloudwatch_alarm}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleCloudwatchAlarm\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CloudwatchAlarm
        {
            get;
            set;
        }

        /// <summary>cloudwatch_metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#cloudwatch_metric IotTopicRule#cloudwatch_metric}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleCloudwatchMetric\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CloudwatchMetric
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#description IotTopicRule#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>dynamodb block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#dynamodb IotTopicRule#dynamodb}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dynamodb", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleDynamodb\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Dynamodb
        {
            get;
            set;
        }

        /// <summary>dynamodbv2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#dynamodbv2 IotTopicRule#dynamodbv2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dynamodbv2", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleDynamodbv2\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Dynamodbv2
        {
            get;
            set;
        }

        /// <summary>elasticsearch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#elasticsearch IotTopicRule#elasticsearch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "elasticsearch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleElasticsearch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Elasticsearch
        {
            get;
            set;
        }

        /// <summary>error_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#error_action IotTopicRule#error_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "errorAction", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorAction\"}", isOptional: true)]
        public aws.Iot.IIotTopicRuleErrorAction? ErrorAction
        {
            get;
            set;
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#firehose IotTopicRule#firehose}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firehose", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleFirehose\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Firehose
        {
            get;
            set;
        }

        /// <summary>iot_analytics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#iot_analytics IotTopicRule#iot_analytics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iotAnalytics", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleIotAnalytics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IotAnalytics
        {
            get;
            set;
        }

        /// <summary>iot_events block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#iot_events IotTopicRule#iot_events}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iotEvents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleIotEvents\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IotEvents
        {
            get;
            set;
        }

        /// <summary>kinesis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#kinesis IotTopicRule#kinesis}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleKinesis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Kinesis
        {
            get;
            set;
        }

        /// <summary>lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#lambda IotTopicRule#lambda}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambda", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleLambda\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Lambda
        {
            get;
            set;
        }

        /// <summary>republish block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#republish IotTopicRule#republish}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "republish", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleRepublish\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Republish
        {
            get;
            set;
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#s3 IotTopicRule#s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3
        {
            get;
            set;
        }

        /// <summary>sns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sns IotTopicRule#sns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleSns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Sns
        {
            get;
            set;
        }

        /// <summary>sqs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sqs IotTopicRule#sqs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleSqs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Sqs
        {
            get;
            set;
        }

        /// <summary>step_functions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#step_functions IotTopicRule#step_functions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepFunctions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleStepFunctions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StepFunctions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#tags IotTopicRule#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
