using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    #pragma warning disable CS8618

    /// <summary>AWS Lambda.</summary>
    [JsiiByValue(fqn: "aws.lambdafunction.LambdaProvisionedConcurrencyConfigConfig")]
    public class LambdaProvisionedConcurrencyConfigConfig : aws.Lambdafunction.ILambdaProvisionedConcurrencyConfigConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_provisioned_concurrency_config#function_name LambdaProvisionedConcurrencyConfig#function_name}.</summary>
        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public string FunctionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_provisioned_concurrency_config#provisioned_concurrent_executions LambdaProvisionedConcurrencyConfig#provisioned_concurrent_executions}.</summary>
        [JsiiProperty(name: "provisionedConcurrentExecutions", typeJson: "{\"primitive\":\"number\"}")]
        public double ProvisionedConcurrentExecutions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_provisioned_concurrency_config#qualifier LambdaProvisionedConcurrencyConfig#qualifier}.</summary>
        [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}")]
        public string Qualifier
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_provisioned_concurrency_config#timeouts LambdaProvisionedConcurrencyConfig#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaProvisionedConcurrencyConfigTimeouts\"}", isOptional: true)]
        public aws.Lambdafunction.ILambdaProvisionedConcurrencyConfigTimeouts? Timeouts
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
