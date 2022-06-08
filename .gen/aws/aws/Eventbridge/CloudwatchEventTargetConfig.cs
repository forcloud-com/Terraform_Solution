using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    #pragma warning disable CS8618

    /// <summary>AWS CloudWatch Event Bridge.</summary>
    [JsiiByValue(fqn: "aws.eventbridge.CloudwatchEventTargetConfig")]
    public class CloudwatchEventTargetConfig : aws.Eventbridge.ICloudwatchEventTargetConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#arn CloudwatchEventTarget#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public string Arn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#rule CloudwatchEventTarget#rule}.</summary>
        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        public string Rule
        {
            get;
            set;
        }

        /// <summary>batch_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#batch_target CloudwatchEventTarget#batch_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "batchTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetBatchTarget\"}", isOptional: true)]
        public aws.Eventbridge.ICloudwatchEventTargetBatchTarget? BatchTarget
        {
            get;
            set;
        }

        /// <summary>ecs_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#ecs_target CloudwatchEventTarget#ecs_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecsTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTarget\"}", isOptional: true)]
        public aws.Eventbridge.ICloudwatchEventTargetEcsTarget? EcsTarget
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#input CloudwatchEventTarget#input}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Input
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#input_path CloudwatchEventTarget#input_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputPath
        {
            get;
            set;
        }

        /// <summary>input_transformer block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#input_transformer CloudwatchEventTarget#input_transformer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputTransformer", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetInputTransformer\"}", isOptional: true)]
        public aws.Eventbridge.ICloudwatchEventTargetInputTransformer? InputTransformer
        {
            get;
            set;
        }

        /// <summary>kinesis_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#kinesis_target CloudwatchEventTarget#kinesis_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetKinesisTarget\"}", isOptional: true)]
        public aws.Eventbridge.ICloudwatchEventTargetKinesisTarget? KinesisTarget
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#role_arn CloudwatchEventTarget#role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoleArn
        {
            get;
            set;
        }

        /// <summary>run_command_targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#run_command_targets CloudwatchEventTarget#run_command_targets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runCommandTargets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRunCommandTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RunCommandTargets
        {
            get;
            set;
        }

        /// <summary>sqs_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#sqs_target CloudwatchEventTarget#sqs_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqsTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetSqsTarget\"}", isOptional: true)]
        public aws.Eventbridge.ICloudwatchEventTargetSqsTarget? SqsTarget
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#target_id CloudwatchEventTarget#target_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetId
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
