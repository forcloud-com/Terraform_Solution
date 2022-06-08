using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiByValue(fqn: "aws.lambdafunction.LambdaEventSourceMappingDestinationConfig")]
    public class LambdaEventSourceMappingDestinationConfig : aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfig
    {
        /// <summary>on_failure block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#on_failure LambdaEventSourceMapping#on_failure}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfigOnFailure\"}", isOptional: true)]
        public aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfigOnFailure? OnFailure
        {
            get;
            set;
        }
    }
}
