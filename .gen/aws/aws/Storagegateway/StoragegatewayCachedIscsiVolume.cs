using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_cached_iscsi_volume aws_storagegateway_cached_iscsi_volume}.</summary>
    [JsiiClass(nativeType: typeof(aws.Storagegateway.StoragegatewayCachedIscsiVolume), fullyQualifiedName: "aws.storagegateway.StoragegatewayCachedIscsiVolume", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.storagegateway.StoragegatewayCachedIscsiVolumeConfig\"}}]")]
    public class StoragegatewayCachedIscsiVolume : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_cached_iscsi_volume aws_storagegateway_cached_iscsi_volume} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StoragegatewayCachedIscsiVolume(Constructs.Construct scope, string id, aws.Storagegateway.IStoragegatewayCachedIscsiVolumeConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayCachedIscsiVolume(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayCachedIscsiVolume(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSnapshotId")]
        public virtual void ResetSnapshotId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceVolumeArn")]
        public virtual void ResetSourceVolumeArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.Storagegateway.StoragegatewayCachedIscsiVolume))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "chapEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ChapEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lunNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LunNumber
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "networkInterfacePort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetworkInterfacePort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "volumeArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkInterfaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SnapshotIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceVolumeArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceVolumeArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeSizeInBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VolumeSizeInBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "gatewayArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkInterfaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceVolumeArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceVolumeArn
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

        [JsiiProperty(name: "targetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeSizeInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VolumeSizeInBytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
