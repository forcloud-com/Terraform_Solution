using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/ecr_authorization_token aws_ecr_authorization_token}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ecr.DataAwsEcrAuthorizationToken), fullyQualifiedName: "aws.ecr.DataAwsEcrAuthorizationToken", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.ecr.DataAwsEcrAuthorizationTokenConfig\"}}]")]
    public class DataAwsEcrAuthorizationToken : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/ecr_authorization_token aws_ecr_authorization_token} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsEcrAuthorizationToken(Constructs.Construct scope, string id, aws.Ecr.IDataAwsEcrAuthorizationTokenConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcrAuthorizationToken(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcrAuthorizationToken(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRegistryId")]
        public virtual void ResetRegistryId()
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
        = GetStaticProperty<string>(typeof(aws.Ecr.DataAwsEcrAuthorizationToken))!;

        [JsiiProperty(name: "authorizationToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpiresAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proxyEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProxyEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "registryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegistryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
