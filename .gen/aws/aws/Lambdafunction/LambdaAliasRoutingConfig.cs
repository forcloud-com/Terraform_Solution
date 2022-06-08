using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiByValue(fqn: "aws.lambdafunction.LambdaAliasRoutingConfig")]
    public class LambdaAliasRoutingConfig : aws.Lambdafunction.ILambdaAliasRoutingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_alias#additional_version_weights LambdaAlias#additional_version_weights}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalVersionWeights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, double>? AdditionalVersionWeights
        {
            get;
            set;
        }
    }
}
