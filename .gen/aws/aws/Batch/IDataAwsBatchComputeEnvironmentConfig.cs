using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    /// <summary>AWS Batch.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsBatchComputeEnvironmentConfig), fullyQualifiedName: "aws.batch.DataAwsBatchComputeEnvironmentConfig")]
    public interface IDataAwsBatchComputeEnvironmentConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/batch_compute_environment#compute_environment_name DataAwsBatchComputeEnvironment#compute_environment_name}.</summary>
        [JsiiProperty(name: "computeEnvironmentName", typeJson: "{\"primitive\":\"string\"}")]
        string ComputeEnvironmentName
        {
            get;
        }

        /// <summary>AWS Batch.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsBatchComputeEnvironmentConfig), fullyQualifiedName: "aws.batch.DataAwsBatchComputeEnvironmentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Batch.IDataAwsBatchComputeEnvironmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/batch_compute_environment#compute_environment_name DataAwsBatchComputeEnvironment#compute_environment_name}.</summary>
            [JsiiProperty(name: "computeEnvironmentName", typeJson: "{\"primitive\":\"string\"}")]
            public string ComputeEnvironmentName
            {
                get => GetInstanceProperty<string>()!;
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
