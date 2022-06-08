using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiByValue(fqn: "aws.lambdafunction.LambdaFunctionEnvironment")]
    public class LambdaFunctionEnvironment : aws.Lambdafunction.ILambdaFunctionEnvironment
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#variables LambdaFunction#variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "variables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Variables
        {
            get;
            set;
        }
    }
}
