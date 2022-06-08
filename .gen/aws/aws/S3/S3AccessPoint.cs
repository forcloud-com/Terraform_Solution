using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point aws_s3_access_point}.</summary>
    [JsiiClass(nativeType: typeof(aws.S3.S3AccessPoint), fullyQualifiedName: "aws.s3.S3AccessPoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.s3.S3AccessPointConfig\"}}]")]
    public class S3AccessPoint : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point aws_s3_access_point} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public S3AccessPoint(Constructs.Construct scope, string id, aws.S3.IS3AccessPointConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3AccessPoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3AccessPoint(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPublicAccessBlockConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3AccessPointPublicAccessBlockConfiguration\"}}]")]
        public virtual void PutPublicAccessBlockConfiguration(aws.S3.IS3AccessPointPublicAccessBlockConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3AccessPointPublicAccessBlockConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3AccessPointVpcConfiguration\"}}]")]
        public virtual void PutVpcConfiguration(aws.S3.IS3AccessPointVpcConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3AccessPointVpcConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicy")]
        public virtual void ResetPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicAccessBlockConfiguration")]
        public virtual void ResetPublicAccessBlockConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcConfiguration")]
        public virtual void ResetVpcConfiguration()
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
        = GetStaticProperty<string>(typeof(aws.S3.S3AccessPoint))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hasPublicAccessPolicy", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable HasPublicAccessPolicy
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkOrigin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkOrigin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicAccessBlockConfiguration", typeJson: "{\"fqn\":\"aws.s3.S3AccessPointPublicAccessBlockConfigurationOutputReference\"}")]
        public virtual aws.S3.S3AccessPointPublicAccessBlockConfigurationOutputReference PublicAccessBlockConfiguration
        {
            get => GetInstanceProperty<aws.S3.S3AccessPointPublicAccessBlockConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "vpcConfiguration", typeJson: "{\"fqn\":\"aws.s3.S3AccessPointVpcConfigurationOutputReference\"}")]
        public virtual aws.S3.S3AccessPointVpcConfigurationOutputReference VpcConfiguration
        {
            get => GetInstanceProperty<aws.S3.S3AccessPointVpcConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicAccessBlockConfigurationInput", typeJson: "{\"fqn\":\"aws.s3.S3AccessPointPublicAccessBlockConfiguration\"}", isOptional: true)]
        public virtual aws.S3.IS3AccessPointPublicAccessBlockConfiguration? PublicAccessBlockConfigurationInput
        {
            get => GetInstanceProperty<aws.S3.IS3AccessPointPublicAccessBlockConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigurationInput", typeJson: "{\"fqn\":\"aws.s3.S3AccessPointVpcConfiguration\"}", isOptional: true)]
        public virtual aws.S3.IS3AccessPointVpcConfiguration? VpcConfigurationInput
        {
            get => GetInstanceProperty<aws.S3.IS3AccessPointVpcConfiguration?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
