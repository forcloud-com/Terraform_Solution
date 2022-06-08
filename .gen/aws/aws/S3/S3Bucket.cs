using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket aws_s3_bucket}.</summary>
    [JsiiClass(nativeType: typeof(aws.S3.S3Bucket), fullyQualifiedName: "aws.s3.S3Bucket", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.s3.S3BucketConfig\"}}]")]
    public class S3Bucket : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket aws_s3_bucket} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public S3Bucket(Constructs.Construct scope, string id, aws.S3.IS3BucketConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3Bucket(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3Bucket(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putObjectLockConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketObjectLockConfiguration\"}}]")]
        public virtual void PutObjectLockConfiguration(aws.S3.IS3BucketObjectLockConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketObjectLockConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReplicationConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketReplicationConfiguration\"}}]")]
        public virtual void PutReplicationConfiguration(aws.S3.IS3BucketReplicationConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketReplicationConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServerSideEncryptionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketServerSideEncryptionConfiguration\"}}]")]
        public virtual void PutServerSideEncryptionConfiguration(aws.S3.IS3BucketServerSideEncryptionConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketServerSideEncryptionConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVersioning", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketVersioning\"}}]")]
        public virtual void PutVersioning(aws.S3.IS3BucketVersioning @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketVersioning)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebsite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketWebsite\"}}]")]
        public virtual void PutWebsite(aws.S3.IS3BucketWebsite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketWebsite)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccelerationStatus")]
        public virtual void ResetAccelerationStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAcl")]
        public virtual void ResetAcl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetArn")]
        public virtual void ResetArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBucket")]
        public virtual void ResetBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBucketPrefix")]
        public virtual void ResetBucketPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCorsRule")]
        public virtual void ResetCorsRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceDestroy")]
        public virtual void ResetForceDestroy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrant")]
        public virtual void ResetGrant()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostedZoneId")]
        public virtual void ResetHostedZoneId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLifecycleRule")]
        public virtual void ResetLifecycleRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogging")]
        public virtual void ResetLogging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectLockConfiguration")]
        public virtual void ResetObjectLockConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicy")]
        public virtual void ResetPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationConfiguration")]
        public virtual void ResetReplicationConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestPayer")]
        public virtual void ResetRequestPayer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerSideEncryptionConfiguration")]
        public virtual void ResetServerSideEncryptionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersioning")]
        public virtual void ResetVersioning()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebsite")]
        public virtual void ResetWebsite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebsiteDomain")]
        public virtual void ResetWebsiteDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebsiteEndpoint")]
        public virtual void ResetWebsiteEndpoint()
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
        = GetStaticProperty<string>(typeof(aws.S3.S3Bucket))!;

        [JsiiProperty(name: "bucketDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bucketRegionalDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketRegionalDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectLockConfiguration", typeJson: "{\"fqn\":\"aws.s3.S3BucketObjectLockConfigurationOutputReference\"}")]
        public virtual aws.S3.S3BucketObjectLockConfigurationOutputReference ObjectLockConfiguration
        {
            get => GetInstanceProperty<aws.S3.S3BucketObjectLockConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "replicationConfiguration", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationOutputReference\"}")]
        public virtual aws.S3.S3BucketReplicationConfigurationOutputReference ReplicationConfiguration
        {
            get => GetInstanceProperty<aws.S3.S3BucketReplicationConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "serverSideEncryptionConfiguration", typeJson: "{\"fqn\":\"aws.s3.S3BucketServerSideEncryptionConfigurationOutputReference\"}")]
        public virtual aws.S3.S3BucketServerSideEncryptionConfigurationOutputReference ServerSideEncryptionConfiguration
        {
            get => GetInstanceProperty<aws.S3.S3BucketServerSideEncryptionConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "versioning", typeJson: "{\"fqn\":\"aws.s3.S3BucketVersioningOutputReference\"}")]
        public virtual aws.S3.S3BucketVersioningOutputReference Versioning
        {
            get => GetInstanceProperty<aws.S3.S3BucketVersioningOutputReference>()!;
        }

        [JsiiProperty(name: "website", typeJson: "{\"fqn\":\"aws.s3.S3BucketWebsiteOutputReference\"}")]
        public virtual aws.S3.S3BucketWebsiteOutputReference Website
        {
            get => GetInstanceProperty<aws.S3.S3BucketWebsiteOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accelerationStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccelerationStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "aclInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AclInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "arnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArnInput
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
        [JsiiProperty(name: "bucketPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "corsRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CorsRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDestroyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceDestroyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketGrant\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GrantInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostedZoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostedZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifecycleRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketLifecycleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LifecycleRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketLogging\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LoggingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectLockConfigurationInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketObjectLockConfiguration\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketObjectLockConfiguration? ObjectLockConfigurationInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketObjectLockConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationConfigurationInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfiguration\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketReplicationConfiguration? ReplicationConfigurationInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestPayerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequestPayerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionConfigurationInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketServerSideEncryptionConfiguration\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketServerSideEncryptionConfiguration? ServerSideEncryptionConfigurationInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketServerSideEncryptionConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versioningInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketVersioning\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketVersioning? VersioningInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketVersioning?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "websiteDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WebsiteDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "websiteEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WebsiteEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "websiteInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketWebsite\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketWebsite? WebsiteInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketWebsite?>();
        }

        [JsiiProperty(name: "accelerationStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccelerationStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "acl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Acl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
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

        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "corsRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketCorsRule\"},\"kind\":\"array\"}}]}}")]
        public virtual object CorsRule
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceDestroy
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "grant", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketGrant\"},\"kind\":\"array\"}}]}}")]
        public virtual object Grant
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostedZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lifecycleRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketLifecycleRule\"},\"kind\":\"array\"}}]}}")]
        public virtual object LifecycleRule
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logging", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketLogging\"},\"kind\":\"array\"}}]}}")]
        public virtual object Logging
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requestPayer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestPayer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "websiteDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebsiteDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "websiteEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebsiteEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
