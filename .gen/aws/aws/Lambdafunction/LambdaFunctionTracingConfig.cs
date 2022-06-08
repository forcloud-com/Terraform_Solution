using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdafunction.LambdaFunctionTracingConfig")]
    public class LambdaFunctionTracingConfig : aws.Lambdafunction.ILambdaFunctionTracingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#mode LambdaFunction#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }
    }
}
