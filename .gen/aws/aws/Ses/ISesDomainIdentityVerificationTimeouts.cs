using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    [JsiiInterface(nativeType: typeof(ISesDomainIdentityVerificationTimeouts), fullyQualifiedName: "aws.ses.SesDomainIdentityVerificationTimeouts")]
    public interface ISesDomainIdentityVerificationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_domain_identity_verification#create SesDomainIdentityVerification#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesDomainIdentityVerificationTimeouts), fullyQualifiedName: "aws.ses.SesDomainIdentityVerificationTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Ses.ISesDomainIdentityVerificationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_domain_identity_verification#create SesDomainIdentityVerification#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
