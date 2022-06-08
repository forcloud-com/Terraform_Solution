using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage aws_api_gateway_stage}.</summary>
    [JsiiClass(nativeType: typeof(aws.Apigateway.ApiGatewayStage), fullyQualifiedName: "aws.apigateway.ApiGatewayStage", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apigateway.ApiGatewayStageConfig\"}}]")]
    public class ApiGatewayStage : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage aws_api_gateway_stage} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApiGatewayStage(Constructs.Construct scope, string id, aws.Apigateway.IApiGatewayStageConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayStage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayStage(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccessLogSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigateway.ApiGatewayStageAccessLogSettings\"}}]")]
        public virtual void PutAccessLogSettings(aws.Apigateway.IApiGatewayStageAccessLogSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigateway.IApiGatewayStageAccessLogSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessLogSettings")]
        public virtual void ResetAccessLogSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCacheClusterEnabled")]
        public virtual void ResetCacheClusterEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCacheClusterSize")]
        public virtual void ResetCacheClusterSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificateId")]
        public virtual void ResetClientCertificateId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDocumentationVersion")]
        public virtual void ResetDocumentationVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVariables")]
        public virtual void ResetVariables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXrayTracingEnabled")]
        public virtual void ResetXrayTracingEnabled()
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
        = GetStaticProperty<string>(typeof(aws.Apigateway.ApiGatewayStage))!;

        [JsiiProperty(name: "accessLogSettings", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayStageAccessLogSettingsOutputReference\"}")]
        public virtual aws.Apigateway.ApiGatewayStageAccessLogSettingsOutputReference AccessLogSettings
        {
            get => GetInstanceProperty<aws.Apigateway.ApiGatewayStageAccessLogSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "invokeUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvokeUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessLogSettingsInput", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayStageAccessLogSettings\"}", isOptional: true)]
        public virtual aws.Apigateway.IApiGatewayStageAccessLogSettings? AccessLogSettingsInput
        {
            get => GetInstanceProperty<aws.Apigateway.IApiGatewayStageAccessLogSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheClusterEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CacheClusterEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheClusterSizeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CacheClusterSizeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentIdInput
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
        [JsiiProperty(name: "documentationVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DocumentationVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restApiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RestApiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stageNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StageNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "variablesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? VariablesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xrayTracingEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? XrayTracingEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cacheClusterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CacheClusterEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cacheClusterSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CacheClusterSize
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientCertificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCertificateId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentId
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

        [JsiiProperty(name: "documentationVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentationVersion
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

        [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StageName
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

        [JsiiProperty(name: "variables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Variables
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "xrayTracingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object XrayTracingEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
