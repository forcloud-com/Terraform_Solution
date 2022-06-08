using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    /// <summary>AWS Glue.</summary>
    [JsiiInterface(nativeType: typeof(IGlueJobConfig), fullyQualifiedName: "aws.glue.GlueJobConfig")]
    public interface IGlueJobConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>command block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#command GlueJob#command}
        /// </remarks>
        [JsiiProperty(name: "command", typeJson: "{\"fqn\":\"aws.glue.GlueJobCommand\"}")]
        aws.Glue.IGlueJobCommand Command
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#name GlueJob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#role_arn GlueJob#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#allocated_capacity GlueJob#allocated_capacity}.</summary>
        [JsiiProperty(name: "allocatedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AllocatedCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#connections GlueJob#connections}.</summary>
        [JsiiProperty(name: "connections", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Connections
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#default_arguments GlueJob#default_arguments}.</summary>
        [JsiiProperty(name: "defaultArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefaultArguments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#description GlueJob#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>execution_property block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#execution_property GlueJob#execution_property}
        /// </remarks>
        [JsiiProperty(name: "executionProperty", typeJson: "{\"fqn\":\"aws.glue.GlueJobExecutionProperty\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGlueJobExecutionProperty? ExecutionProperty
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#glue_version GlueJob#glue_version}.</summary>
        [JsiiProperty(name: "glueVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GlueVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#max_capacity GlueJob#max_capacity}.</summary>
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#max_retries GlueJob#max_retries}.</summary>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRetries
        {
            get
            {
                return null;
            }
        }

        /// <summary>notification_property block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#notification_property GlueJob#notification_property}
        /// </remarks>
        [JsiiProperty(name: "notificationProperty", typeJson: "{\"fqn\":\"aws.glue.GlueJobNotificationProperty\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGlueJobNotificationProperty? NotificationProperty
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#number_of_workers GlueJob#number_of_workers}.</summary>
        [JsiiProperty(name: "numberOfWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumberOfWorkers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#security_configuration GlueJob#security_configuration}.</summary>
        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#tags GlueJob#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#timeout GlueJob#timeout}.</summary>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#worker_type GlueJob#worker_type}.</summary>
        [JsiiProperty(name: "workerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkerType
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Glue.</summary>
        [JsiiTypeProxy(nativeType: typeof(IGlueJobConfig), fullyQualifiedName: "aws.glue.GlueJobConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueJobConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>command block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#command GlueJob#command}
            /// </remarks>
            [JsiiProperty(name: "command", typeJson: "{\"fqn\":\"aws.glue.GlueJobCommand\"}")]
            public aws.Glue.IGlueJobCommand Command
            {
                get => GetInstanceProperty<aws.Glue.IGlueJobCommand>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#name GlueJob#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#role_arn GlueJob#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#allocated_capacity GlueJob#allocated_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allocatedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AllocatedCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#connections GlueJob#connections}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connections", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Connections
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#default_arguments GlueJob#default_arguments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefaultArguments
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#description GlueJob#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>execution_property block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#execution_property GlueJob#execution_property}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "executionProperty", typeJson: "{\"fqn\":\"aws.glue.GlueJobExecutionProperty\"}", isOptional: true)]
            public aws.Glue.IGlueJobExecutionProperty? ExecutionProperty
            {
                get => GetInstanceProperty<aws.Glue.IGlueJobExecutionProperty?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#glue_version GlueJob#glue_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "glueVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GlueVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#max_capacity GlueJob#max_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#max_retries GlueJob#max_retries}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRetries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>notification_property block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#notification_property GlueJob#notification_property}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notificationProperty", typeJson: "{\"fqn\":\"aws.glue.GlueJobNotificationProperty\"}", isOptional: true)]
            public aws.Glue.IGlueJobNotificationProperty? NotificationProperty
            {
                get => GetInstanceProperty<aws.Glue.IGlueJobNotificationProperty?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#number_of_workers GlueJob#number_of_workers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numberOfWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumberOfWorkers
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#security_configuration GlueJob#security_configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityConfiguration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#tags GlueJob#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#timeout GlueJob#timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#worker_type GlueJob#worker_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkerType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
