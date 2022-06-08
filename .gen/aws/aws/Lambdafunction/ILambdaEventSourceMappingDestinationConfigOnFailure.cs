using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiInterface(nativeType: typeof(ILambdaEventSourceMappingDestinationConfigOnFailure), fullyQualifiedName: "aws.lambdafunction.LambdaEventSourceMappingDestinationConfigOnFailure")]
    public interface ILambdaEventSourceMappingDestinationConfigOnFailure
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#destination_arn LambdaEventSourceMapping#destination_arn}.</summary>
        [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaEventSourceMappingDestinationConfigOnFailure), fullyQualifiedName: "aws.lambdafunction.LambdaEventSourceMappingDestinationConfigOnFailure")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfigOnFailure
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#destination_arn LambdaEventSourceMapping#destination_arn}.</summary>
            [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
