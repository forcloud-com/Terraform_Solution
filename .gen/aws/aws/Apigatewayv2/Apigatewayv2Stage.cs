using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage aws_apigatewayv2_stage}.</summary>
    [JsiiClass(nativeType: typeof(aws.Apigatewayv2.Apigatewayv2Stage), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2Stage", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apigatewayv2.Apigatewayv2StageConfig\"}}]")]
    public class Apigatewayv2Stage : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage aws_apigatewayv2_stage} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Apigatewayv2Stage(Constructs.Construct scope, string id, aws.Apigatewayv2.IApigatewayv2StageConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2Stage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2Stage(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccessLogSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigatewayv2.Apigatewayv2StageAccessLogSettings\"}}]")]
        public virtual void PutAccessLogSettings(aws.Apigatewayv2.IApigatewayv2StageAccessLogSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigatewayv2.IApigatewayv2StageAccessLogSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDefaultRouteSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigatewayv2.Apigatewayv2StageDefaultRouteSettings\"}}]")]
        public virtual void PutDefaultRouteSettings(aws.Apigatewayv2.IApigatewayv2StageDefaultRouteSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigatewayv2.IApigatewayv2StageDefaultRouteSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessLogSettings")]
        public virtual void ResetAccessLogSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoDeploy")]
        public virtual void ResetAutoDeploy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificateId")]
        public virtual void ResetClientCertificateId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultRouteSettings")]
        public virtual void ResetDefaultRouteSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentId")]
        public virtual void ResetDeploymentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRouteSettings")]
        public virtual void ResetRouteSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStageVariables")]
        public virtual void ResetStageVariables()
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
        = GetStaticProperty<string>(typeof(aws.Apigatewayv2.Apigatewayv2Stage))!;

        [JsiiProperty(name: "accessLogSettings", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2StageAccessLogSettingsOutputReference\"}")]
        public virtual aws.Apigatewayv2.Apigatewayv2StageAccessLogSettingsOutputReference AccessLogSettings
        {
            get => GetInstanceProperty<aws.Apigatewayv2.Apigatewayv2StageAccessLogSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultRouteSettings", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2StageDefaultRouteSettingsOutputReference\"}")]
        public virtual aws.Apigatewayv2.Apigatewayv2StageDefaultRouteSettingsOutputReference DefaultRouteSettings
        {
            get => GetInstanceProperty<aws.Apigatewayv2.Apigatewayv2StageDefaultRouteSettingsOutputReference>()!;
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
        [JsiiProperty(name: "accessLogSettingsInput", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2StageAccessLogSettings\"}", isOptional: true)]
        public virtual aws.Apigatewayv2.IApigatewayv2StageAccessLogSettings? AccessLogSettingsInput
        {
            get => GetInstanceProperty<aws.Apigatewayv2.IApigatewayv2StageAccessLogSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoDeployInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoDeployInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCertificateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultRouteSettingsInput", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2StageDefaultRouteSettings\"}", isOptional: true)]
        public virtual aws.Apigatewayv2.IApigatewayv2StageDefaultRouteSettings? DefaultRouteSettingsInput
        {
            get => GetInstanceProperty<aws.Apigatewayv2.IApigatewayv2StageDefaultRouteSettings?>();
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2.Apigatewayv2StageRouteSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RouteSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stageVariablesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? StageVariablesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoDeploy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutoDeploy
        {
            get => GetInstanceProperty<object>()!;
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routeSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2.Apigatewayv2StageRouteSettings\"},\"kind\":\"array\"}}]}}")]
        public virtual object RouteSettings
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stageVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> StageVariables
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
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
