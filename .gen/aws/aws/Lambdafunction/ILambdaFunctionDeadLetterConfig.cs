using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionDeadLetterConfig), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionDeadLetterConfig")]
    public interface ILambdaFunctionDeadLetterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#target_arn LambdaFunction#target_arn}.</summary>
        [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
        string TargetArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionDeadLetterConfig), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionDeadLetterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.ILambdaFunctionDeadLetterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#target_arn LambdaFunction#target_arn}.</summary>
            [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
