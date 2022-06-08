using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/dms_certificate aws_dms_certificate}.</summary>
    [JsiiClass(nativeType: typeof(aws.Dms.DmsCertificate), fullyQualifiedName: "aws.dms.DmsCertificate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dms.DmsCertificateConfig\"}}]")]
    public class DmsCertificate : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/dms_certificate aws_dms_certificate} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DmsCertificate(Constructs.Construct scope, string id, aws.Dms.IDmsCertificateConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsCertificate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsCertificate(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCertificatePem")]
        public virtual void ResetCertificatePem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateWallet")]
        public virtual void ResetCertificateWallet()
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
        = GetStaticProperty<string>(typeof(aws.Dms.DmsCertificate))!;

        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificatePemInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificatePemInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateWalletInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateWalletInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificatePem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificatePem
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateWallet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateWallet
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
