using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiByValue(fqn: "aws.lambdafunction.LambdaProvisionedConcurrencyConfigTimeouts")]
    public class LambdaProvisionedConcurrencyConfigTimeouts : aws.Lambdafunction.ILambdaProvisionedConcurrencyConfigTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_provisioned_concurrency_config#create LambdaProvisionedConcurrencyConfig#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_provisioned_concurrency_config#update LambdaProvisionedConcurrencyConfig#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
