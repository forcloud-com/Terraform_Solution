using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    [JsiiByValue(fqn: "aws.apigatewayv2.Apigatewayv2DomainNameTimeouts")]
    public class Apigatewayv2DomainNameTimeouts : aws.Apigatewayv2.IApigatewayv2DomainNameTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name#update Apigatewayv2DomainName#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
