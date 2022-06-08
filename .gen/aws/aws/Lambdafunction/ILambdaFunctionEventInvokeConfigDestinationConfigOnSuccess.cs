using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess")]
    public interface ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function_event_invoke_config#destination LambdaFunctionEventInvokeConfig#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function_event_invoke_config#destination LambdaFunctionEventInvokeConfig#destination}.</summary>
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
