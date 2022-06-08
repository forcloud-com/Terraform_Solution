using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionTracingConfig), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionTracingConfig")]
    public interface ILambdaFunctionTracingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#mode LambdaFunction#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionTracingConfig), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionTracingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.ILambdaFunctionTracingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#mode LambdaFunction#mode}.</summary>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
