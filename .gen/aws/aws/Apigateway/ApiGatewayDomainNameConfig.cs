using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    #pragma warning disable CS8618

    /// <summary>API Gateway.</summary>
    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayDomainNameConfig")]
    public class ApiGatewayDomainNameConfig : aws.Apigateway.IApiGatewayDomainNameConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#domain_name ApiGatewayDomainName#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#certificate_arn ApiGatewayDomainName#certificate_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#certificate_body ApiGatewayDomainName#certificate_body}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateBody
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#certificate_chain ApiGatewayDomainName#certificate_chain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateChain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#certificate_name ApiGatewayDomainName#certificate_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#certificate_private_key ApiGatewayDomainName#certificate_private_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificatePrivateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificatePrivateKey
        {
            get;
            set;
        }

        /// <summary>endpoint_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#endpoint_configuration ApiGatewayDomainName#endpoint_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpointConfiguration", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayDomainNameEndpointConfiguration\"}", isOptional: true)]
        public aws.Apigateway.IApiGatewayDomainNameEndpointConfiguration? EndpointConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#regional_certificate_arn ApiGatewayDomainName#regional_certificate_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regionalCertificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegionalCertificateArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#regional_certificate_name ApiGatewayDomainName#regional_certificate_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regionalCertificateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegionalCertificateName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#security_policy ApiGatewayDomainName#security_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name#tags ApiGatewayDomainName#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
