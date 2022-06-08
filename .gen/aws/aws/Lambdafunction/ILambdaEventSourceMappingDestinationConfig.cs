using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiInterface(nativeType: typeof(ILambdaEventSourceMappingDestinationConfig), fullyQualifiedName: "aws.lambdafunction.LambdaEventSourceMappingDestinationConfig")]
    public interface ILambdaEventSourceMappingDestinationConfig
    {
        /// <summary>on_failure block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#on_failure LambdaEventSourceMapping#on_failure}
        /// </remarks>
        [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfigOnFailure\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfigOnFailure? OnFailure
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaEventSourceMappingDestinationConfig), fullyQualifiedName: "aws.lambdafunction.LambdaEventSourceMappingDestinationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>on_failure block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#on_failure LambdaEventSourceMapping#on_failure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onFailure", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfigOnFailure\"}", isOptional: true)]
            public aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfigOnFailure? OnFailure
            {
                get => GetInstanceProperty<aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfigOnFailure?>();
            }
        }
    }
}
