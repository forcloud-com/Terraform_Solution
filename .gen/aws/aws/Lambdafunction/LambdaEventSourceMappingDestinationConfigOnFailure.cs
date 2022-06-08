using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdafunction.LambdaEventSourceMappingDestinationConfigOnFailure")]
    public class LambdaEventSourceMappingDestinationConfigOnFailure : aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfigOnFailure
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#destination_arn LambdaEventSourceMapping#destination_arn}.</summary>
        [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationArn
        {
            get;
            set;
        }
    }
}
