using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    /// <summary>AWS Batch.</summary>
    [JsiiInterface(nativeType: typeof(IBatchJobDefinitionConfig), fullyQualifiedName: "aws.batch.BatchJobDefinitionConfig")]
    public interface IBatchJobDefinitionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#name BatchJobDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#type BatchJobDefinition#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#container_properties BatchJobDefinition#container_properties}.</summary>
        [JsiiProperty(name: "containerProperties", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainerProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#parameters BatchJobDefinition#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>retry_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#retry_strategy BatchJobDefinition#retry_strategy}
        /// </remarks>
        [JsiiProperty(name: "retryStrategy", typeJson: "{\"fqn\":\"aws.batch.BatchJobDefinitionRetryStrategy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Batch.IBatchJobDefinitionRetryStrategy? RetryStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#timeout BatchJobDefinition#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.batch.BatchJobDefinitionTimeout\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Batch.IBatchJobDefinitionTimeout? Timeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Batch.</summary>
        [JsiiTypeProxy(nativeType: typeof(IBatchJobDefinitionConfig), fullyQualifiedName: "aws.batch.BatchJobDefinitionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Batch.IBatchJobDefinitionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#name BatchJobDefinition#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#type BatchJobDefinition#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#container_properties BatchJobDefinition#container_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerProperties", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerProperties
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#parameters BatchJobDefinition#parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Parameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>retry_strategy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#retry_strategy BatchJobDefinition#retry_strategy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryStrategy", typeJson: "{\"fqn\":\"aws.batch.BatchJobDefinitionRetryStrategy\"}", isOptional: true)]
            public aws.Batch.IBatchJobDefinitionRetryStrategy? RetryStrategy
            {
                get => GetInstanceProperty<aws.Batch.IBatchJobDefinitionRetryStrategy?>();
            }

            /// <summary>timeout block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#timeout BatchJobDefinition#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.batch.BatchJobDefinitionTimeout\"}", isOptional: true)]
            public aws.Batch.IBatchJobDefinitionTimeout? Timeout
            {
                get => GetInstanceProperty<aws.Batch.IBatchJobDefinitionTimeout?>();
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
