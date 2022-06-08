using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan aws_api_gateway_usage_plan}.</summary>
    [JsiiClass(nativeType: typeof(aws.Apigateway.ApiGatewayUsagePlan), fullyQualifiedName: "aws.apigateway.ApiGatewayUsagePlan", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanConfig\"}}]")]
    public class ApiGatewayUsagePlan : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan aws_api_gateway_usage_plan} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApiGatewayUsagePlan(Constructs.Construct scope, string id, aws.Apigateway.IApiGatewayUsagePlanConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayUsagePlan(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayUsagePlan(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putQuotaSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanQuotaSettings\"}}]")]
        public virtual void PutQuotaSettings(aws.Apigateway.IApiGatewayUsagePlanQuotaSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigateway.IApiGatewayUsagePlanQuotaSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThrottleSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanThrottleSettings\"}}]")]
        public virtual void PutThrottleSettings(aws.Apigateway.IApiGatewayUsagePlanThrottleSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigateway.IApiGatewayUsagePlanThrottleSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiStages")]
        public virtual void ResetApiStages()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProductCode")]
        public virtual void ResetProductCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuotaSettings")]
        public virtual void ResetQuotaSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThrottleSettings")]
        public virtual void ResetThrottleSettings()
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
        = GetStaticProperty<string>(typeof(aws.Apigateway.ApiGatewayUsagePlan))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "quotaSettings", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanQuotaSettingsOutputReference\"}")]
        public virtual aws.Apigateway.ApiGatewayUsagePlanQuotaSettingsOutputReference QuotaSettings
        {
            get => GetInstanceProperty<aws.Apigateway.ApiGatewayUsagePlanQuotaSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "throttleSettings", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanThrottleSettingsOutputReference\"}")]
        public virtual aws.Apigateway.ApiGatewayUsagePlanThrottleSettingsOutputReference ThrottleSettings
        {
            get => GetInstanceProperty<aws.Apigateway.ApiGatewayUsagePlanThrottleSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiStagesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanApiStages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ApiStagesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProductCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "quotaSettingsInput", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanQuotaSettings\"}", isOptional: true)]
        public virtual aws.Apigateway.IApiGatewayUsagePlanQuotaSettings? QuotaSettingsInput
        {
            get => GetInstanceProperty<aws.Apigateway.IApiGatewayUsagePlanQuotaSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "throttleSettingsInput", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanThrottleSettings\"}", isOptional: true)]
        public virtual aws.Apigateway.IApiGatewayUsagePlanThrottleSettings? ThrottleSettingsInput
        {
            get => GetInstanceProperty<aws.Apigateway.IApiGatewayUsagePlanThrottleSettings?>();
        }

        [JsiiProperty(name: "apiStages", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanApiStages\"},\"kind\":\"array\"}}]}}")]
        public virtual object ApiStages
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "productCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductCode
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
