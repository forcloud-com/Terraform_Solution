using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name aws_api_gateway_domain_name}.</summary>
    [JsiiClass(nativeType: typeof(aws.Apigateway.ApiGatewayDomainName), fullyQualifiedName: "aws.apigateway.ApiGatewayDomainName", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apigateway.ApiGatewayDomainNameConfig\"}}]")]
    public class ApiGatewayDomainName : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_domain_name aws_api_gateway_domain_name} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApiGatewayDomainName(Constructs.Construct scope, string id, aws.Apigateway.IApiGatewayDomainNameConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayDomainName(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayDomainName(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEndpointConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigateway.ApiGatewayDomainNameEndpointConfiguration\"}}]")]
        public virtual void PutEndpointConfiguration(aws.Apigateway.IApiGatewayDomainNameEndpointConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigateway.IApiGatewayDomainNameEndpointConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCertificateArn")]
        public virtual void ResetCertificateArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateBody")]
        public virtual void ResetCertificateBody()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateChain")]
        public virtual void ResetCertificateChain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateName")]
        public virtual void ResetCertificateName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificatePrivateKey")]
        public virtual void ResetCertificatePrivateKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndpointConfiguration")]
        public virtual void ResetEndpointConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegionalCertificateArn")]
        public virtual void ResetRegionalCertificateArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegionalCertificateName")]
        public virtual void ResetRegionalCertificateName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityPolicy")]
        public virtual void ResetSecurityPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Apigateway.ApiGatewayDomainName))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateUploadDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateUploadDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudfrontDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudfrontDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudfrontZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudfrontZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointConfiguration", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayDomainNameEndpointConfigurationOutputReference\"}")]
        public virtual aws.Apigateway.ApiGatewayDomainNameEndpointConfigurationOutputReference EndpointConfiguration
        {
            get => GetInstanceProperty<aws.Apigateway.ApiGatewayDomainNameEndpointConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "regionalDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionalDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "regionalZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionalZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateBodyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateBodyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateChainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateChainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificatePrivateKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificatePrivateKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointConfigurationInput", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayDomainNameEndpointConfiguration\"}", isOptional: true)]
        public virtual aws.Apigateway.IApiGatewayDomainNameEndpointConfiguration? EndpointConfigurationInput
        {
            get => GetInstanceProperty<aws.Apigateway.IApiGatewayDomainNameEndpointConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionalCertificateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionalCertificateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionalCertificateNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionalCertificateNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateBody", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateBody
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateChain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificatePrivateKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificatePrivateKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "regionalCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionalCertificateArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "regionalCertificateName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionalCertificateName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
