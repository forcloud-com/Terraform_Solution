using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Acm
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate_validation aws_acm_certificate_validation}.</summary>
    [JsiiClass(nativeType: typeof(aws.Acm.AcmCertificateValidation), fullyQualifiedName: "aws.acm.AcmCertificateValidation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.acm.AcmCertificateValidationConfig\"}}]")]
    public class AcmCertificateValidation : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/acm_certificate_validation aws_acm_certificate_validation} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AcmCertificateValidation(Constructs.Construct scope, string id, aws.Acm.IAcmCertificateValidationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmCertificateValidation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AcmCertificateValidation(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.acm.AcmCertificateValidationTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Acm.IAcmCertificateValidationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Acm.IAcmCertificateValidationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidationRecordFqdns")]
        public virtual void ResetValidationRecordFqdns()
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
        = GetStaticProperty<string>(typeof(aws.Acm.AcmCertificateValidation))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.acm.AcmCertificateValidationTimeoutsOutputReference\"}")]
        public virtual aws.Acm.AcmCertificateValidationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Acm.AcmCertificateValidationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.acm.AcmCertificateValidationTimeouts\"}", isOptional: true)]
        public virtual aws.Acm.IAcmCertificateValidationTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Acm.IAcmCertificateValidationTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validationRecordFqdnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ValidationRecordFqdnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "validationRecordFqdns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ValidationRecordFqdns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
