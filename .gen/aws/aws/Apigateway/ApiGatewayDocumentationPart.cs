using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_documentation_part aws_api_gateway_documentation_part}.</summary>
    [JsiiClass(nativeType: typeof(aws.Apigateway.ApiGatewayDocumentationPart), fullyQualifiedName: "aws.apigateway.ApiGatewayDocumentationPart", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apigateway.ApiGatewayDocumentationPartConfig\"}}]")]
    public class ApiGatewayDocumentationPart : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_documentation_part aws_api_gateway_documentation_part} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApiGatewayDocumentationPart(Constructs.Construct scope, string id, aws.Apigateway.IApiGatewayDocumentationPartConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayDocumentationPart(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayDocumentationPart(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigateway.ApiGatewayDocumentationPartLocation\"}}]")]
        public virtual void PutLocation(aws.Apigateway.IApiGatewayDocumentationPartLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigateway.IApiGatewayDocumentationPartLocation)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Apigateway.ApiGatewayDocumentationPart))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayDocumentationPartLocationOutputReference\"}")]
        public virtual aws.Apigateway.ApiGatewayDocumentationPartLocationOutputReference Location
        {
            get => GetInstanceProperty<aws.Apigateway.ApiGatewayDocumentationPartLocationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayDocumentationPartLocation\"}", isOptional: true)]
        public virtual aws.Apigateway.IApiGatewayDocumentationPartLocation? LocationInput
        {
            get => GetInstanceProperty<aws.Apigateway.IApiGatewayDocumentationPartLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propertiesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PropertiesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restApiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RestApiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "properties", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Properties
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
