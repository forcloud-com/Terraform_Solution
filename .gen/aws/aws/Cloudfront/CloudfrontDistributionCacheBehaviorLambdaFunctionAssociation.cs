using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionCacheBehaviorLambdaFunctionAssociation")]
    public class CloudfrontDistributionCacheBehaviorLambdaFunctionAssociation : aws.Cloudfront.ICloudfrontDistributionCacheBehaviorLambdaFunctionAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#event_type CloudfrontDistribution#event_type}.</summary>
        [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}")]
        public string EventType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#lambda_arn CloudfrontDistribution#lambda_arn}.</summary>
        [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LambdaArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#include_body CloudfrontDistribution#include_body}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeBody", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeBody
        {
            get;
            set;
        }
    }
}
