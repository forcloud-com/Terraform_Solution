using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/launch_template aws_launch_template}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2.DataAwsLaunchTemplate), fullyQualifiedName: "aws.ec2.DataAwsLaunchTemplate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateConfig\"}}]")]
    public class DataAwsLaunchTemplate : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/launch_template aws_launch_template} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsLaunchTemplate(Constructs.Construct scope, string id, aws.Ec2.IDataAwsLaunchTemplateConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchTemplate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchTemplate(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
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
        = GetStaticProperty<string>(typeof(aws.Ec2.DataAwsLaunchTemplate))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockDeviceMappings", typeJson: "{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateBlockDeviceMappingsList\"}")]
        public virtual aws.Ec2.DataAwsLaunchTemplateBlockDeviceMappingsList BlockDeviceMappings
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsLaunchTemplateBlockDeviceMappingsList>()!;
        }

        [JsiiProperty(name: "creditSpecification", typeJson: "{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateCreditSpecificationList\"}")]
        public virtual aws.Ec2.DataAwsLaunchTemplateCreditSpecificationList CreditSpecification
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsLaunchTemplateCreditSpecificationList>()!;
        }

        [JsiiProperty(name: "defaultVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DisableApiTermination
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbsOptimized
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "elasticGpuSpecifications", typeJson: "{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateElasticGpuSpecificationsList\"}")]
        public virtual aws.Ec2.DataAwsLaunchTemplateElasticGpuSpecificationsList ElasticGpuSpecifications
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsLaunchTemplateElasticGpuSpecificationsList>()!;
        }

        [JsiiProperty(name: "hibernationOptions", typeJson: "{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateHibernationOptionsList\"}")]
        public virtual aws.Ec2.DataAwsLaunchTemplateHibernationOptionsList HibernationOptions
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsLaunchTemplateHibernationOptionsList>()!;
        }

        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateIamInstanceProfileList\"}")]
        public virtual aws.Ec2.DataAwsLaunchTemplateIamInstanceProfileList IamInstanceProfile
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsLaunchTemplateIamInstanceProfileList>()!;
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

        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceInitiatedShutdownBehavior
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceMarketOptions", typeJson: "{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateInstanceMarketOptionsList\"}")]
        public virtual aws.Ec2.DataAwsLaunchTemplateInstanceMarketOptionsList InstanceMarketOptions
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsLaunchTemplateInstanceMarketOptionsList>()!;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KernelId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latestVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LatestVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "metadataOptions", typeJson: "{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateMetadataOptionsList\"}")]
        public virtual aws.Ec2.DataAwsLaunchTemplateMetadataOptionsList MetadataOptions
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsLaunchTemplateMetadataOptionsList>()!;
        }

        [JsiiProperty(name: "monitoring", typeJson: "{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateMonitoringList\"}")]
        public virtual aws.Ec2.DataAwsLaunchTemplateMonitoringList Monitoring
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsLaunchTemplateMonitoringList>()!;
        }

        [JsiiProperty(name: "networkInterfaces", typeJson: "{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateNetworkInterfacesList\"}")]
        public virtual aws.Ec2.DataAwsLaunchTemplateNetworkInterfacesList NetworkInterfaces
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsLaunchTemplateNetworkInterfacesList>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"aws.ec2.DataAwsLaunchTemplatePlacementList\"}")]
        public virtual aws.Ec2.DataAwsLaunchTemplatePlacementList Placement
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsLaunchTemplatePlacementList>()!;
        }

        [JsiiProperty(name: "ramDiskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RamDiskId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tagSpecifications", typeJson: "{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateTagSpecificationsList\"}")]
        public virtual aws.Ec2.DataAwsLaunchTemplateTagSpecificationsList TagSpecifications
        {
            get => GetInstanceProperty<aws.Ec2.DataAwsLaunchTemplateTagSpecificationsList>()!;
        }

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateFilter\"},\"kind\":\"array\"}}]}}")]
        public virtual object Filter
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
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
    }
}
