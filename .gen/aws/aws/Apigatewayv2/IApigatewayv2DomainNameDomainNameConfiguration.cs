using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2DomainNameDomainNameConfiguration), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2DomainNameDomainNameConfiguration")]
    public interface IApigatewayv2DomainNameDomainNameConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name#certificate_arn Apigatewayv2DomainName#certificate_arn}.</summary>
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name#endpoint_type Apigatewayv2DomainName#endpoint_type}.</summary>
        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name#security_policy Apigatewayv2DomainName#security_policy}.</summary>
        [JsiiProperty(name: "securityPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string SecurityPolicy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2DomainNameDomainNameConfiguration), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2DomainNameDomainNameConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2.IApigatewayv2DomainNameDomainNameConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name#certificate_arn Apigatewayv2DomainName#certificate_arn}.</summary>
            [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name#endpoint_type Apigatewayv2DomainName#endpoint_type}.</summary>
            [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name#security_policy Apigatewayv2DomainName#security_policy}.</summary>
            [JsiiProperty(name: "securityPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string SecurityPolicy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
