using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    [JsiiClass(nativeType: typeof(aws.Acm.AcmpcaCertificateAuthorityRevocationConfigurationOutputReference), fullyQualifiedName: "aws.acm.AcmpcaCertificateAuthorityRevocationConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AcmpcaCertificateAuthorityRevocationConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AcmpcaCertificateAuthorityRevocationConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmpcaCertificateAuthorityRevocationConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmpcaCertificateAuthorityRevocationConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCrlConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"}}]")]
        public virtual void PutCrlConfiguration(aws.Acm.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Acm.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCrlConfiguration")]
        public virtual void ResetCrlConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "crlConfiguration", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfigurationOutputReference\"}")]
        public virtual aws.Acm.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfigurationOutputReference CrlConfiguration
        {
            get => GetInstanceProperty<aws.Acm.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "crlConfigurationInput", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration\"}", isOptional: true)]
        public virtual aws.Acm.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration? CrlConfigurationInput
        {
            get => GetInstanceProperty<aws.Acm.IAcmpcaCertificateAuthorityRevocationConfigurationCrlConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.acm.AcmpcaCertificateAuthorityRevocationConfiguration\"}", isOptional: true)]
        public virtual aws.Acm.IAcmpcaCertificateAuthorityRevocationConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Acm.IAcmpcaCertificateAuthorityRevocationConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
