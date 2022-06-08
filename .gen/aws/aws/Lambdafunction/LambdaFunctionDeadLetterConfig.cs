using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdafunction.LambdaFunctionDeadLetterConfig")]
    public class LambdaFunctionDeadLetterConfig : aws.Lambdafunction.ILambdaFunctionDeadLetterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#target_arn LambdaFunction#target_arn}.</summary>
        [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetArn
        {
            get;
            set;
        }
    }
}
