using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration aws_s3_bucket_analytics_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketAnalyticsConfiguration), fullyQualifiedName: "aws.s3.S3BucketAnalyticsConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationConfig\"}}]")]
    public class S3BucketAnalyticsConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration aws_s3_bucket_analytics_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public S3BucketAnalyticsConfiguration(Constructs.Construct scope, string id, aws.S3.IS3BucketAnalyticsConfigurationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketAnalyticsConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketAnalyticsConfiguration(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationFilter\"}}]")]
        public virtual void PutFilter(aws.S3.IS3BucketAnalyticsConfigurationFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketAnalyticsConfigurationFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageClassAnalysis", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysis\"}}]")]
        public virtual void PutStorageClassAnalysis(aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysis @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysis)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageClassAnalysis")]
        public virtual void ResetStorageClassAnalysis()
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
        = GetStaticProperty<string>(typeof(aws.S3.S3BucketAnalyticsConfiguration))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationFilterOutputReference\"}")]
        public virtual aws.S3.S3BucketAnalyticsConfigurationFilterOutputReference Filter
        {
            get => GetInstanceProperty<aws.S3.S3BucketAnalyticsConfigurationFilterOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageClassAnalysis", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisOutputReference\"}")]
        public virtual aws.S3.S3BucketAnalyticsConfigurationStorageClassAnalysisOutputReference StorageClassAnalysis
        {
            get => GetInstanceProperty<aws.S3.S3BucketAnalyticsConfigurationStorageClassAnalysisOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationFilter\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketAnalyticsConfigurationFilter? FilterInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketAnalyticsConfigurationFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageClassAnalysisInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysis\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysis? StorageClassAnalysisInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysis?>();
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
    }
}
