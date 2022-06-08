using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iam
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/iam_user_login_profile aws_iam_user_login_profile}.</summary>
    [JsiiClass(nativeType: typeof(aws.Iam.IamUserLoginProfile), fullyQualifiedName: "aws.iam.IamUserLoginProfile", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.iam.IamUserLoginProfileConfig\"}}]")]
    public class IamUserLoginProfile : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/iam_user_login_profile aws_iam_user_login_profile} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IamUserLoginProfile(Constructs.Construct scope, string id, aws.Iam.IIamUserLoginProfileConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IamUserLoginProfile(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IamUserLoginProfile(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPasswordLength")]
        public virtual void ResetPasswordLength()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPasswordResetRequired")]
        public virtual void ResetPasswordResetRequired()
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
        = GetStaticProperty<string>(typeof(aws.Iam.IamUserLoginProfile))!;

        [JsiiProperty(name: "encryptedPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptedPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyFingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyFingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordLengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PasswordLengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordResetRequiredInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PasswordResetRequiredInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pgpKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PgpKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "passwordLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PasswordLength
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "passwordResetRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PasswordResetRequired
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pgpKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PgpKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string User
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
