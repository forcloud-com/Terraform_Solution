using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/instance aws_instance}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2.DataAwsInstance), fullyQualifiedName: "aws.ec2.DataAwsInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.ec2.DataAwsInstanceConfig\"}}]")]
    public class DataAwsInstance : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/instance aws_instance} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsInstance(Constructs.Construct scope, string id, aws.Ec2.IDataAwsInstanceConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsInstance(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFetchPasswordData")]
        public virtual void ResetFetchPasswordData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFetchUserData")]
        public virtual void ResetFetchUserData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceId")]
        public virtual void ResetInstanceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceTags")]
        public virtual void ResetInstanceTags()
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
        = GetStaticProperty<string>(typeof(aws.Ec2.DataAwsInstance))!;

        [JsiiProperty(name: "ami", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ami
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AssociatePublicIpAddress
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creditSpecification", typeJson: "{\"fqn\":\"aws.ec2.DataAwsInstanceCreditSpecificationList\"}")]
        public virtual aws.Ec2.DataAwsInstanceCreditSpecificationList CreditSpecification
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsInstanceCreditSpecificationList>()!;
        }

        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DisableApiTermination
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"fqn\":\"aws.ec2.DataAwsInstanceEbsBlockDeviceList\"}")]
        public virtual aws.Ec2.DataAwsInstanceEbsBlockDeviceList EbsBlockDevice
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsInstanceEbsBlockDeviceList>()!;
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable EbsOptimized
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"fqn\":\"aws.ec2.DataAwsInstanceEphemeralBlockDeviceList\"}")]
        public virtual aws.Ec2.DataAwsInstanceEphemeralBlockDeviceList EphemeralBlockDevice
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsInstanceEphemeralBlockDeviceList>()!;
        }

        [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamInstanceProfile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadataOptions", typeJson: "{\"fqn\":\"aws.ec2.DataAwsInstanceMetadataOptionsList\"}")]
        public virtual aws.Ec2.DataAwsInstanceMetadataOptionsList MetadataOptions
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsInstanceMetadataOptionsList>()!;
        }

        [JsiiProperty(name: "monitoring", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Monitoring
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkInterfaceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outpostArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutpostArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateDns
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicDns
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"fqn\":\"aws.ec2.DataAwsInstanceRootBlockDeviceList\"}")]
        public virtual aws.Ec2.DataAwsInstanceRootBlockDeviceList RootBlockDevice
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsInstanceRootBlockDeviceList>()!;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sourceDestCheck", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable SourceDestCheck
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tenancy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userDataBase64", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserDataBase64
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fetchPasswordDataInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FetchPasswordDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fetchUserDataInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FetchUserDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsInstanceFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? InstanceTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "fetchPasswordData", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object FetchPasswordData
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fetchUserData", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object FetchUserData
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsInstanceFilter\"},\"kind\":\"array\"}}]}}")]
        public virtual object Filter
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> InstanceTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
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
