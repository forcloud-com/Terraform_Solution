using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    [JsiiByValue(fqn: "aws.apigatewayv2.Apigatewayv2ApiCorsConfiguration")]
    public class Apigatewayv2ApiCorsConfiguration : aws.Apigatewayv2.IApigatewayv2ApiCorsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_api#allow_credentials Apigatewayv2Api#allow_credentials}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowCredentials
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_api#allow_headers Apigatewayv2Api#allow_headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowHeaders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_api#allow_methods Apigatewayv2Api#allow_methods}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowMethods
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_api#allow_origins Apigatewayv2Api#allow_origins}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowOrigins
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_api#expose_headers Apigatewayv2Api#expose_headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exposeHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExposeHeaders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_api#max_age Apigatewayv2Api#max_age}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAge
        {
            get;
            set;
        }
    }
}
