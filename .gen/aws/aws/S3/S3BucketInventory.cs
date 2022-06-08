using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory aws_s3_bucket_inventory}.</summary>
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketInventory), fullyQualifiedName: "aws.s3.S3BucketInventory", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.s3.S3BucketInventoryConfig\"}}]")]
    public class S3BucketInventory : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory aws_s3_bucket_inventory} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public S3BucketInventory(Constructs.Construct scope, string id, aws.S3.IS3BucketInventoryConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketInventory(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketInventory(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketInventoryDestination\"}}]")]
        public virtual void PutDestination(aws.S3.IS3BucketInventoryDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketInventoryDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketInventoryFilter\"}}]")]
        public virtual void PutFilter(aws.S3.IS3BucketInventoryFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketInventoryFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketInventorySchedule\"}}]")]
        public virtual void PutSchedule(aws.S3.IS3BucketInventorySchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketInventorySchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOptionalFields")]
        public virtual void ResetOptionalFields()
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
        = GetStaticProperty<string>(typeof(aws.S3.S3BucketInventory))!;

        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestinationOutputReference\"}")]
        public virtual aws.S3.S3BucketInventoryDestinationOutputReference Destination
        {
            get => GetInstanceProperty<aws.S3.S3BucketInventoryDestinationOutputReference>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryFilterOutputReference\"}")]
        public virtual aws.S3.S3BucketInventoryFilterOutputReference Filter
        {
            get => GetInstanceProperty<aws.S3.S3BucketInventoryFilterOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryScheduleOutputReference\"}")]
        public virtual aws.S3.S3BucketInventoryScheduleOutputReference Schedule
        {
            get => GetInstanceProperty<aws.S3.S3BucketInventoryScheduleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestination\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketInventoryDestination? DestinationInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketInventoryDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryFilter\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketInventoryFilter? FilterInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketInventoryFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includedObjectVersionsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IncludedObjectVersionsInput
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
        [JsiiProperty(name: "optionalFieldsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? OptionalFieldsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventorySchedule\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketInventorySchedule? ScheduleInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketInventorySchedule?>();
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includedObjectVersions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IncludedObjectVersions
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

        [JsiiProperty(name: "optionalFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OptionalFields
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
