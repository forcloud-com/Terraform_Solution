using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    /// <summary>AWS Batch.</summary>
    [JsiiInterface(nativeType: typeof(IBatchComputeEnvironmentConfig), fullyQualifiedName: "aws.batch.BatchComputeEnvironmentConfig")]
    public interface IBatchComputeEnvironmentConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#service_role BatchComputeEnvironment#service_role}.</summary>
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceRole
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#type BatchComputeEnvironment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#compute_environment_name BatchComputeEnvironment#compute_environment_name}.</summary>
        [JsiiProperty(name: "computeEnvironmentName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeEnvironmentName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#compute_environment_name_prefix BatchComputeEnvironment#compute_environment_name_prefix}.</summary>
        [JsiiProperty(name: "computeEnvironmentNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeEnvironmentNamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>compute_resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#compute_resources BatchComputeEnvironment#compute_resources}
        /// </remarks>
        [JsiiProperty(name: "computeResources", typeJson: "{\"fqn\":\"aws.batch.BatchComputeEnvironmentComputeResources\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Batch.IBatchComputeEnvironmentComputeResources? ComputeResources
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#state BatchComputeEnvironment#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Batch.</summary>
        [JsiiTypeProxy(nativeType: typeof(IBatchComputeEnvironmentConfig), fullyQualifiedName: "aws.batch.BatchComputeEnvironmentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Batch.IBatchComputeEnvironmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#service_role BatchComputeEnvironment#service_role}.</summary>
            [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#type BatchComputeEnvironment#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#compute_environment_name BatchComputeEnvironment#compute_environment_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeEnvironmentName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeEnvironmentName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#compute_environment_name_prefix BatchComputeEnvironment#compute_environment_name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeEnvironmentNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeEnvironmentNamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>compute_resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#compute_resources BatchComputeEnvironment#compute_resources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "computeResources", typeJson: "{\"fqn\":\"aws.batch.BatchComputeEnvironmentComputeResources\"}", isOptional: true)]
            public aws.Batch.IBatchComputeEnvironmentComputeResources? ComputeResources
            {
                get => GetInstanceProperty<aws.Batch.IBatchComputeEnvironmentComputeResources?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#state BatchComputeEnvironment#state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
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
