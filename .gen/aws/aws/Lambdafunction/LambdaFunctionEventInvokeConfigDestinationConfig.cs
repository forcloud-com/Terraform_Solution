using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiByValue(fqn: "aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfig")]
    public class LambdaFunctionEventInvokeConfigDestinationConfig : aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfig
    {
        /// <summary>on_failure block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function_event_invoke_config#on_failure LambdaFunctionEventInvokeConfig#on_failure}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure\"}", isOptional: true)]
        public aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure? OnFailure
        {
            get;
            set;
        }

        /// <summary>on_success block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function_event_invoke_config#on_success LambdaFunctionEventInvokeConfig#on_success}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onSuccess", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess\"}", isOptional: true)]
        public aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess? OnSuccess
        {
            get;
            set;
        }
    }
}
