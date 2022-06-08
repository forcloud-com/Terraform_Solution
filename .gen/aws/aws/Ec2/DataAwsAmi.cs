using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/ami aws_ami}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2.DataAwsAmi), fullyQualifiedName: "aws.ec2.DataAwsAmi", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ec2.DataAwsAmiConfig\"}}]")]
    public class DataAwsAmi : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/ami aws_ami} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsAmi(Constructs.Construct scope, string id, aws.Ec2.IDataAwsAmiConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAmi(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAmi(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetExecutableUsers")]
        public virtual void ResetExecutableUsers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMostRecent")]
        public virtual void ResetMostRecent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNameRegex")]
        public virtual void ResetNameRegex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "stateReason", returnsJson: "{\"type\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"cdktf.IResolvable\"}]}}}", parametersJson: "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual object StateReason(string key)
        {
            return InvokeInstanceMethod<object>(new System.Type[]{typeof(string)}, new object[]{key})!;
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
        = GetStaticProperty<string>(typeof(aws.Ec2.DataAwsAmi))!;

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockDeviceMappings", typeJson: "{\"fqn\":\"aws.ec2.DataAwsAmiBlockDeviceMappingsList\"}")]
        public virtual aws.Ec2.DataAwsAmiBlockDeviceMappingsList BlockDeviceMappings
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsAmiBlockDeviceMappingsList>()!;
        }

        [JsiiProperty(name: "creationDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hypervisor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hypervisor
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageOwnerAlias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageOwnerAlias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KernelId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Platform
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productCodes", typeJson: "{\"fqn\":\"aws.ec2.DataAwsAmiProductCodesList\"}")]
        public virtual aws.Ec2.DataAwsAmiProductCodesList ProductCodes
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsAmiProductCodesList>()!;
        }

        [JsiiProperty(name: "public", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Public
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "ramdiskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RamdiskId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootDeviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDeviceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootDeviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDeviceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootSnapshotId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootSnapshotId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sriovNetSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SriovNetSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualizationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualizationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "executableUsersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ExecutableUsersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsAmiFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mostRecentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? MostRecentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameRegexInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameRegexInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? OwnersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "executableUsers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExecutableUsers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsAmiFilter\"},\"kind\":\"array\"}}]}}")]
        public virtual object Filter
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mostRecent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object MostRecent
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nameRegex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameRegex
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "owners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Owners
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
