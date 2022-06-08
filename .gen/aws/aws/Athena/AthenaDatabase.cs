using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/athena_database aws_athena_database}.</summary>
    [JsiiClass(nativeType: typeof(aws.Athena.AthenaDatabase), fullyQualifiedName: "aws.athena.AthenaDatabase", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.athena.AthenaDatabaseConfig\"}}]")]
    public class AthenaDatabase : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/athena_database aws_athena_database} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AthenaDatabase(Constructs.Construct scope, string id, aws.Athena.IAthenaDatabaseConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AthenaDatabase(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AthenaDatabase(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEncryptionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athena.AthenaDatabaseEncryptionConfiguration\"}}]")]
        public virtual void PutEncryptionConfiguration(aws.Athena.IAthenaDatabaseEncryptionConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Athena.IAthenaDatabaseEncryptionConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEncryptionConfiguration")]
        public virtual void ResetEncryptionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceDestroy")]
        public virtual void ResetForceDestroy()
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
        = GetStaticProperty<string>(typeof(aws.Athena.AthenaDatabase))!;

        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.athena.AthenaDatabaseEncryptionConfigurationOutputReference\"}")]
        public virtual aws.Athena.AthenaDatabaseEncryptionConfigurationOutputReference EncryptionConfiguration
        {
            get => GetInstanceProperty<aws.Athena.AthenaDatabaseEncryptionConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfigurationInput", typeJson: "{\"fqn\":\"aws.athena.AthenaDatabaseEncryptionConfiguration\"}", isOptional: true)]
        public virtual aws.Athena.IAthenaDatabaseEncryptionConfiguration? EncryptionConfigurationInput
        {
            get => GetInstanceProperty<aws.Athena.IAthenaDatabaseEncryptionConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDestroyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceDestroyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceDestroy
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
