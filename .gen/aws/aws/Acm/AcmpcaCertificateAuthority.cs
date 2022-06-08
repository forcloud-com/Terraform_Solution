using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority aws_acmpca_certificate_authority}.</summary>
    [JsiiClass(nativeType: typeof(aws.Acm.AcmpcaCertificateAuthority), fullyQualifiedName: "aws.acm.AcmpcaCertificateAuthority", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityConfig\"}}]")]
    public class AcmpcaCertificateAuthority : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/acmpca_certificate_authority aws_acmpca_certificate_authority} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AcmpcaCertificateAuthority(Constructs.Construct scope, string id, aws.Acm.IAcmpcaCertificateAuthorityConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmpcaCertificateAuthority(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmpcaCertificateAuthority(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCertificateAuthorityConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration\"}}]")]
        public virtual void PutCertificateAuthorityConfiguration(aws.Acm.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Acm.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRevocationConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityRevocationConfiguration\"}}]")]
        public virtual void PutRevocationConfiguration(aws.Acm.IAcmpcaCertificateAuthorityRevocationConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Acm.IAcmpcaCertificateAuthorityRevocationConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Acm.IAcmpcaCertificateAuthorityTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Acm.IAcmpcaCertificateAuthorityTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPermanentDeletionTimeInDays")]
        public virtual void ResetPermanentDeletionTimeInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRevocationConfiguration")]
        public virtual void ResetRevocationConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
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
        = GetStaticProperty<string>(typeof(aws.Acm.AcmpcaCertificateAuthority))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Certificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateAuthorityConfiguration", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationOutputReference\"}")]
        public virtual aws.Acm.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationOutputReference CertificateAuthorityConfiguration
        {
            get => GetInstanceProperty<aws.Acm.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateChain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateSigningRequest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateSigningRequest
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notAfter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotAfter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notBefore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotBefore
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revocationConfiguration", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityRevocationConfigurationOutputReference\"}")]
        public virtual aws.Acm.AcmpcaCertificateAuthorityRevocationConfigurationOutputReference RevocationConfiguration
        {
            get => GetInstanceProperty<aws.Acm.AcmpcaCertificateAuthorityRevocationConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "serial", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Serial
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityTimeoutsOutputReference\"}")]
        public virtual aws.Acm.AcmpcaCertificateAuthorityTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Acm.AcmpcaCertificateAuthorityTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateAuthorityConfigurationInput", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration\"}", isOptional: true)]
        public virtual aws.Acm.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration? CertificateAuthorityConfigurationInput
        {
            get => GetInstanceProperty<aws.Acm.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permanentDeletionTimeInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PermanentDeletionTimeInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "revocationConfigurationInput", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityRevocationConfiguration\"}", isOptional: true)]
        public virtual aws.Acm.IAcmpcaCertificateAuthorityRevocationConfiguration? RevocationConfigurationInput
        {
            get => GetInstanceProperty<aws.Acm.IAcmpcaCertificateAuthorityRevocationConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityTimeouts\"}", isOptional: true)]
        public virtual aws.Acm.IAcmpcaCertificateAuthorityTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Acm.IAcmpcaCertificateAuthorityTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "permanentDeletionTimeInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PermanentDeletionTimeInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
