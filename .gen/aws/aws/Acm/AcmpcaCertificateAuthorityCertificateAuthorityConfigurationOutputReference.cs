using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    [JsiiClass(nativeType: typeof(aws.Acm.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationOutputReference), fullyQualifiedName: "aws.acm.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AcmpcaCertificateAuthorityCertificateAuthorityConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AcmpcaCertificateAuthorityCertificateAuthorityConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmpcaCertificateAuthorityCertificateAuthorityConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmpcaCertificateAuthorityCertificateAuthorityConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSubject", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject\"}}]")]
        public virtual void PutSubject(aws.Acm.IAcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Acm.IAcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject)}, new object[]{@value});
        }

        [JsiiProperty(name: "subject", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubjectOutputReference\"}")]
        public virtual aws.Acm.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubjectOutputReference Subject
        {
            get => GetInstanceProperty<aws.Acm.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubjectOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signingAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SigningAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectInput", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject\"}", isOptional: true)]
        public virtual aws.Acm.IAcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject? SubjectInput
        {
            get => GetInstanceProperty<aws.Acm.IAcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject?>();
        }

        [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyAlgorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SigningAlgorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityCertificateAuthorityConfiguration\"}", isOptional: true)]
        public virtual aws.Acm.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Acm.IAcmpcaCertificateAuthorityCertificateAuthorityConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
