using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api aws_appsync_graphql_api}.</summary>
    [JsiiClass(nativeType: typeof(aws.Appsync.AppsyncGraphqlApi), fullyQualifiedName: "aws.appsync.AppsyncGraphqlApi", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.appsync.AppsyncGraphqlApiConfig\"}}]")]
    public class AppsyncGraphqlApi : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api aws_appsync_graphql_api} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AppsyncGraphqlApi(Constructs.Construct scope, string id, aws.Appsync.IAppsyncGraphqlApiConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncGraphqlApi(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncGraphqlApi(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLogConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsync.AppsyncGraphqlApiLogConfig\"}}]")]
        public virtual void PutLogConfig(aws.Appsync.IAppsyncGraphqlApiLogConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appsync.IAppsyncGraphqlApiLogConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenidConnectConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsync.AppsyncGraphqlApiOpenidConnectConfig\"}}]")]
        public virtual void PutOpenidConnectConfig(aws.Appsync.IAppsyncGraphqlApiOpenidConnectConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appsync.IAppsyncGraphqlApiOpenidConnectConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserPoolConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsync.AppsyncGraphqlApiUserPoolConfig\"}}]")]
        public virtual void PutUserPoolConfig(aws.Appsync.IAppsyncGraphqlApiUserPoolConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appsync.IAppsyncGraphqlApiUserPoolConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalAuthenticationProvider")]
        public virtual void ResetAdditionalAuthenticationProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogConfig")]
        public virtual void ResetLogConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenidConnectConfig")]
        public virtual void ResetOpenidConnectConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchema")]
        public virtual void ResetSchema()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserPoolConfig")]
        public virtual void ResetUserPoolConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXrayEnabled")]
        public virtual void ResetXrayEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "uris", returnsJson: "{\"type\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"cdktf.IResolvable\"}]}}}", parametersJson: "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual object Uris(string key)
        {
            return InvokeInstanceMethod<object>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Appsync.AppsyncGraphqlApi))!;

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

        [JsiiProperty(name: "logConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiLogConfigOutputReference\"}")]
        public virtual aws.Appsync.AppsyncGraphqlApiLogConfigOutputReference LogConfig
        {
            get => GetInstanceProperty<aws.Appsync.AppsyncGraphqlApiLogConfigOutputReference>()!;
        }

        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiOpenidConnectConfigOutputReference\"}")]
        public virtual aws.Appsync.AppsyncGraphqlApiOpenidConnectConfigOutputReference OpenidConnectConfig
        {
            get => GetInstanceProperty<aws.Appsync.AppsyncGraphqlApiOpenidConnectConfigOutputReference>()!;
        }

        [JsiiProperty(name: "userPoolConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiUserPoolConfigOutputReference\"}")]
        public virtual aws.Appsync.AppsyncGraphqlApiUserPoolConfigOutputReference UserPoolConfig
        {
            get => GetInstanceProperty<aws.Appsync.AppsyncGraphqlApiUserPoolConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalAuthenticationProviderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProvider\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AdditionalAuthenticationProviderInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthenticationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logConfigInput", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiLogConfig\"}", isOptional: true)]
        public virtual aws.Appsync.IAppsyncGraphqlApiLogConfig? LogConfigInput
        {
            get => GetInstanceProperty<aws.Appsync.IAppsyncGraphqlApiLogConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openidConnectConfigInput", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiOpenidConnectConfig\"}", isOptional: true)]
        public virtual aws.Appsync.IAppsyncGraphqlApiOpenidConnectConfig? OpenidConnectConfigInput
        {
            get => GetInstanceProperty<aws.Appsync.IAppsyncGraphqlApiOpenidConnectConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchemaInput
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
        [JsiiProperty(name: "userPoolConfigInput", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiUserPoolConfig\"}", isOptional: true)]
        public virtual aws.Appsync.IAppsyncGraphqlApiUserPoolConfig? UserPoolConfigInput
        {
            get => GetInstanceProperty<aws.Appsync.IAppsyncGraphqlApiUserPoolConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xrayEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? XrayEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "additionalAuthenticationProvider", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProvider\"},\"kind\":\"array\"}}]}}")]
        public virtual object AdditionalAuthenticationProvider
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationType
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

        [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Schema
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

        [JsiiProperty(name: "xrayEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object XrayEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
