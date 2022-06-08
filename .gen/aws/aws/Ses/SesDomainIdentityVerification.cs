using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ses_domain_identity_verification aws_ses_domain_identity_verification}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ses.SesDomainIdentityVerification), fullyQualifiedName: "aws.ses.SesDomainIdentityVerification", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ses.SesDomainIdentityVerificationConfig\"}}]")]
    public class SesDomainIdentityVerification : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ses_domain_identity_verification aws_ses_domain_identity_verification} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SesDomainIdentityVerification(Constructs.Construct scope, string id, aws.Ses.ISesDomainIdentityVerificationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesDomainIdentityVerification(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesDomainIdentityVerification(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ses.SesDomainIdentityVerificationTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Ses.ISesDomainIdentityVerificationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ses.ISesDomainIdentityVerificationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Ses.SesDomainIdentityVerification))!;

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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ses.SesDomainIdentityVerificationTimeoutsOutputReference\"}")]
        public virtual aws.Ses.SesDomainIdentityVerificationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Ses.SesDomainIdentityVerificationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.ses.SesDomainIdentityVerificationTimeouts\"}", isOptional: true)]
        public virtual aws.Ses.ISesDomainIdentityVerificationTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Ses.ISesDomainIdentityVerificationTimeouts?>();
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
