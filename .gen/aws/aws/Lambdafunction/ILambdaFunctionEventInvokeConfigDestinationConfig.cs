using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionEventInvokeConfigDestinationConfig), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfig")]
    public interface ILambdaFunctionEventInvokeConfigDestinationConfig
    {
        /// <summary>on_failure block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function_event_invoke_config#on_failure LambdaFunctionEventInvokeConfig#on_failure}
        /// </remarks>
        [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure? OnFailure
        {
            get
            {
                return null;
            }
        }

        /// <summary>on_success block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function_event_invoke_config#on_success LambdaFunctionEventInvokeConfig#on_success}
        /// </remarks>
        [JsiiProperty(name: "onSuccess", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess? OnSuccess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionEventInvokeConfigDestinationConfig), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>on_failure block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function_event_invoke_config#on_failure LambdaFunctionEventInvokeConfig#on_failure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure\"}", isOptional: true)]
            public aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure? OnFailure
            {
                get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure?>();
            }

            /// <summary>on_success block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function_event_invoke_config#on_success LambdaFunctionEventInvokeConfig#on_success}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onSuccess", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess\"}", isOptional: true)]
            public aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess? OnSuccess
            {
                get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess?>();
            }
        }
    }
}
