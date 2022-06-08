using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionTimeouts), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionTimeouts")]
    public interface ILambdaFunctionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#create LambdaFunction#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionTimeouts), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.ILambdaFunctionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function#create LambdaFunction#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
