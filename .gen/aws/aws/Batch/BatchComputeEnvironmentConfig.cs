using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    #pragma warning disable CS8618

    /// <summary>AWS Batch.</summary>
    [JsiiByValue(fqn: "aws.batch.BatchComputeEnvironmentConfig")]
    public class BatchComputeEnvironmentConfig : aws.Batch.IBatchComputeEnvironmentConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#service_role BatchComputeEnvironment#service_role}.</summary>
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#type BatchComputeEnvironment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#compute_environment_name BatchComputeEnvironment#compute_environment_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeEnvironmentName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputeEnvironmentName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#compute_environment_name_prefix BatchComputeEnvironment#compute_environment_name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeEnvironmentNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputeEnvironmentNamePrefix
        {
            get;
            set;
        }

        /// <summary>compute_resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#compute_resources BatchComputeEnvironment#compute_resources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "computeResources", typeJson: "{\"fqn\":\"aws.batch.BatchComputeEnvironmentComputeResources\"}", isOptional: true)]
        public aws.Batch.IBatchComputeEnvironmentComputeResources? ComputeResources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#state BatchComputeEnvironment#state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? State
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
