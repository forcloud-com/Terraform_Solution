using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    /// <summary>AWS Glue.</summary>
    [JsiiByValue(fqn: "aws.glue.GlueJobConfig")]
    public class GlueJobConfig : aws.Glue.IGlueJobConfig
    {
        /// <summary>command block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#command GlueJob#command}
        /// </remarks>
        [JsiiProperty(name: "command", typeJson: "{\"fqn\":\"aws.glue.GlueJobCommand\"}")]
        public aws.Glue.IGlueJobCommand Command
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#name GlueJob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#role_arn GlueJob#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#allocated_capacity GlueJob#allocated_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allocatedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AllocatedCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#connections GlueJob#connections}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connections", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Connections
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#default_arguments GlueJob#default_arguments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefaultArguments
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#description GlueJob#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>execution_property block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#execution_property GlueJob#execution_property}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "executionProperty", typeJson: "{\"fqn\":\"aws.glue.GlueJobExecutionProperty\"}", isOptional: true)]
        public aws.Glue.IGlueJobExecutionProperty? ExecutionProperty
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#glue_version GlueJob#glue_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "glueVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GlueVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#max_capacity GlueJob#max_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#max_retries GlueJob#max_retries}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRetries
        {
            get;
            set;
        }

        /// <summary>notification_property block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#notification_property GlueJob#notification_property}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notificationProperty", typeJson: "{\"fqn\":\"aws.glue.GlueJobNotificationProperty\"}", isOptional: true)]
        public aws.Glue.IGlueJobNotificationProperty? NotificationProperty
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#number_of_workers GlueJob#number_of_workers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numberOfWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumberOfWorkers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#security_configuration GlueJob#security_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#tags GlueJob#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#timeout GlueJob#timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Timeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#worker_type GlueJob#worker_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkerType
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
