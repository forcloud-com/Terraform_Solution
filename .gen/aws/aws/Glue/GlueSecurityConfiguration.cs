using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration aws_glue_security_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.Glue.GlueSecurityConfiguration), fullyQualifiedName: "aws.glue.GlueSecurityConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.glue.GlueSecurityConfigurationConfig\"}}]")]
    public class GlueSecurityConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration aws_glue_security_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GlueSecurityConfiguration(Constructs.Construct scope, string id, aws.Glue.IGlueSecurityConfigurationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueSecurityConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueSecurityConfiguration(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEncryptionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfiguration\"}}]")]
        public virtual void PutEncryptionConfiguration(aws.Glue.IGlueSecurityConfigurationEncryptionConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueSecurityConfigurationEncryptionConfiguration)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Glue.GlueSecurityConfiguration))!;

        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationOutputReference\"}")]
        public virtual aws.Glue.GlueSecurityConfigurationEncryptionConfigurationOutputReference EncryptionConfiguration
        {
            get => GetInstanceProperty<aws.Glue.GlueSecurityConfigurationEncryptionConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfigurationInput", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfiguration\"}", isOptional: true)]
        public virtual aws.Glue.IGlueSecurityConfigurationEncryptionConfiguration? EncryptionConfigurationInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueSecurityConfigurationEncryptionConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
