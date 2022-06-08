using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_rest_api aws_api_gateway_rest_api}.</summary>
    [JsiiClass(nativeType: typeof(aws.Apigateway.ApiGatewayRestApi), fullyQualifiedName: "aws.apigateway.ApiGatewayRestApi", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apigateway.ApiGatewayRestApiConfig\"}}]")]
    public class ApiGatewayRestApi : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_rest_api aws_api_gateway_rest_api} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApiGatewayRestApi(Constructs.Construct scope, string id, aws.Apigateway.IApiGatewayRestApiConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayRestApi(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayRestApi(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEndpointConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigateway.ApiGatewayRestApiEndpointConfiguration\"}}]")]
        public virtual void PutEndpointConfiguration(aws.Apigateway.IApiGatewayRestApiEndpointConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigateway.IApiGatewayRestApiEndpointConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiKeySource")]
        public virtual void ResetApiKeySource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBinaryMediaTypes")]
        public virtual void ResetBinaryMediaTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBody")]
        public virtual void ResetBody()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndpointConfiguration")]
        public virtual void ResetEndpointConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumCompressionSize")]
        public virtual void ResetMinimumCompressionSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicy")]
        public virtual void ResetPolicy()
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
        = GetStaticProperty<string>(typeof(aws.Apigateway.ApiGatewayRestApi))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointConfiguration", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayRestApiEndpointConfigurationOutputReference\"}")]
        public virtual aws.Apigateway.ApiGatewayRestApiEndpointConfigurationOutputReference EndpointConfiguration
        {
            get => GetInstanceProperty<aws.Apigateway.ApiGatewayRestApiEndpointConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "executionArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiKeySourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiKeySourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "binaryMediaTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? BinaryMediaTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bodyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BodyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointConfigurationInput", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayRestApiEndpointConfiguration\"}", isOptional: true)]
        public virtual aws.Apigateway.IApiGatewayRestApiEndpointConfiguration? EndpointConfigurationInput
        {
            get => GetInstanceProperty<aws.Apigateway.IApiGatewayRestApiEndpointConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumCompressionSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinimumCompressionSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "apiKeySource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiKeySource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "binaryMediaTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BinaryMediaTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Body
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumCompressionSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumCompressionSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
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
