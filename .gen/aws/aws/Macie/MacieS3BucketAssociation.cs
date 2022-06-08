using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/macie_s3_bucket_association aws_macie_s3_bucket_association}.</summary>
    [JsiiClass(nativeType: typeof(aws.Macie.MacieS3BucketAssociation), fullyQualifiedName: "aws.macie.MacieS3BucketAssociation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.macie.MacieS3BucketAssociationConfig\"}}]")]
    public class MacieS3BucketAssociation : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/macie_s3_bucket_association aws_macie_s3_bucket_association} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MacieS3BucketAssociation(Constructs.Construct scope, string id, aws.Macie.IMacieS3BucketAssociationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MacieS3BucketAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MacieS3BucketAssociation(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClassificationType", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.macie.MacieS3BucketAssociationClassificationType\"}}]")]
        public virtual void PutClassificationType(aws.Macie.IMacieS3BucketAssociationClassificationType @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Macie.IMacieS3BucketAssociationClassificationType)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClassificationType")]
        public virtual void ResetClassificationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemberAccountId")]
        public virtual void ResetMemberAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefix")]
        public virtual void ResetPrefix()
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
        = GetStaticProperty<string>(typeof(aws.Macie.MacieS3BucketAssociation))!;

        [JsiiProperty(name: "classificationType", typeJson: "{\"fqn\":\"aws.macie.MacieS3BucketAssociationClassificationTypeOutputReference\"}")]
        public virtual aws.Macie.MacieS3BucketAssociationClassificationTypeOutputReference ClassificationType
        {
            get => GetInstanceProperty<aws.Macie.MacieS3BucketAssociationClassificationTypeOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "classificationTypeInput", typeJson: "{\"fqn\":\"aws.macie.MacieS3BucketAssociationClassificationType\"}", isOptional: true)]
        public virtual aws.Macie.IMacieS3BucketAssociationClassificationType? ClassificationTypeInput
        {
            get => GetInstanceProperty<aws.Macie.IMacieS3BucketAssociationClassificationType?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memberAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MemberAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memberAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemberAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
