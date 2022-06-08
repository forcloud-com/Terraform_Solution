using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionDefaultCacheBehaviorLambdaFunctionAssociation), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorLambdaFunctionAssociation")]
    public interface ICloudfrontDistributionDefaultCacheBehaviorLambdaFunctionAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#event_type CloudfrontDistribution#event_type}.</summary>
        [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}")]
        string EventType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#lambda_arn CloudfrontDistribution#lambda_arn}.</summary>
        [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        string LambdaArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#include_body CloudfrontDistribution#include_body}.</summary>
        [JsiiProperty(name: "includeBody", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeBody
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionDefaultCacheBehaviorLambdaFunctionAssociation), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorLambdaFunctionAssociation")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorLambdaFunctionAssociation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#event_type CloudfrontDistribution#event_type}.</summary>
            [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}")]
            public string EventType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#lambda_arn CloudfrontDistribution#lambda_arn}.</summary>
            [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LambdaArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#include_body CloudfrontDistribution#include_body}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeBody", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeBody
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
