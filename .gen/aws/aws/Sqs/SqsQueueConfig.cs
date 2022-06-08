using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sqs
{
    /// <summary>AWS Simple Queue Service.</summary>
    [JsiiByValue(fqn: "aws.sqs.SqsQueueConfig")]
    public class SqsQueueConfig : aws.Sqs.ISqsQueueConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue#content_based_deduplication SqsQueue#content_based_deduplication}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contentBasedDeduplication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ContentBasedDeduplication
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue#delay_seconds SqsQueue#delay_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delaySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DelaySeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue#fifo_queue SqsQueue#fifo_queue}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fifoQueue", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? FifoQueue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue#kms_data_key_reuse_period_seconds SqsQueue#kms_data_key_reuse_period_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsDataKeyReusePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? KmsDataKeyReusePeriodSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue#kms_master_key_id SqsQueue#kms_master_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsMasterKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue#max_message_size SqsQueue#max_message_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxMessageSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxMessageSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue#message_retention_seconds SqsQueue#message_retention_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageRetentionSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MessageRetentionSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue#name SqsQueue#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue#name_prefix SqsQueue#name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NamePrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue#policy SqsQueue#policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Policy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue#receive_wait_time_seconds SqsQueue#receive_wait_time_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "receiveWaitTimeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReceiveWaitTimeSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue#redrive_policy SqsQueue#redrive_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redrivePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RedrivePolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue#tags SqsQueue#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue#visibility_timeout_seconds SqsQueue#visibility_timeout_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "visibilityTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VisibilityTimeoutSeconds
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
