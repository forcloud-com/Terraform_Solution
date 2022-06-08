using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/launch_template aws_launch_template}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2.LaunchTemplate), fullyQualifiedName: "aws.ec2.LaunchTemplate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.ec2.LaunchTemplateConfig\"}}]")]
    public class LaunchTemplate : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/launch_template aws_launch_template} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LaunchTemplate(Constructs.Construct scope, string id, aws.Ec2.ILaunchTemplateConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplate(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCapacityReservationSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.LaunchTemplateCapacityReservationSpecification\"}}]")]
        public virtual void PutCapacityReservationSpecification(aws.Ec2.ILaunchTemplateCapacityReservationSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.ILaunchTemplateCapacityReservationSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCpuOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.LaunchTemplateCpuOptions\"}}]")]
        public virtual void PutCpuOptions(aws.Ec2.ILaunchTemplateCpuOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.ILaunchTemplateCpuOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCreditSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.LaunchTemplateCreditSpecification\"}}]")]
        public virtual void PutCreditSpecification(aws.Ec2.ILaunchTemplateCreditSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.ILaunchTemplateCreditSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putElasticInferenceAccelerator", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.LaunchTemplateElasticInferenceAccelerator\"}}]")]
        public virtual void PutElasticInferenceAccelerator(aws.Ec2.ILaunchTemplateElasticInferenceAccelerator @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.ILaunchTemplateElasticInferenceAccelerator)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHibernationOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.LaunchTemplateHibernationOptions\"}}]")]
        public virtual void PutHibernationOptions(aws.Ec2.ILaunchTemplateHibernationOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.ILaunchTemplateHibernationOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIamInstanceProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.LaunchTemplateIamInstanceProfile\"}}]")]
        public virtual void PutIamInstanceProfile(aws.Ec2.ILaunchTemplateIamInstanceProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.ILaunchTemplateIamInstanceProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInstanceMarketOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.LaunchTemplateInstanceMarketOptions\"}}]")]
        public virtual void PutInstanceMarketOptions(aws.Ec2.ILaunchTemplateInstanceMarketOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.ILaunchTemplateInstanceMarketOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetadataOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.LaunchTemplateMetadataOptions\"}}]")]
        public virtual void PutMetadataOptions(aws.Ec2.ILaunchTemplateMetadataOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.ILaunchTemplateMetadataOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonitoring", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.LaunchTemplateMonitoring\"}}]")]
        public virtual void PutMonitoring(aws.Ec2.ILaunchTemplateMonitoring @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.ILaunchTemplateMonitoring)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.LaunchTemplatePlacement\"}}]")]
        public virtual void PutPlacement(aws.Ec2.ILaunchTemplatePlacement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.ILaunchTemplatePlacement)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBlockDeviceMappings")]
        public virtual void ResetBlockDeviceMappings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityReservationSpecification")]
        public virtual void ResetCapacityReservationSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuOptions")]
        public virtual void ResetCpuOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreditSpecification")]
        public virtual void ResetCreditSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultVersion")]
        public virtual void ResetDefaultVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisableApiTermination")]
        public virtual void ResetDisableApiTermination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbsOptimized")]
        public virtual void ResetEbsOptimized()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticGpuSpecifications")]
        public virtual void ResetElasticGpuSpecifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticInferenceAccelerator")]
        public virtual void ResetElasticInferenceAccelerator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHibernationOptions")]
        public virtual void ResetHibernationOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIamInstanceProfile")]
        public virtual void ResetIamInstanceProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageId")]
        public virtual void ResetImageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceInitiatedShutdownBehavior")]
        public virtual void ResetInstanceInitiatedShutdownBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceMarketOptions")]
        public virtual void ResetInstanceMarketOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceType")]
        public virtual void ResetInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKernelId")]
        public virtual void ResetKernelId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyName")]
        public virtual void ResetKeyName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicenseSpecification")]
        public virtual void ResetLicenseSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadataOptions")]
        public virtual void ResetMetadataOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitoring")]
        public virtual void ResetMonitoring()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamePrefix")]
        public virtual void ResetNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkInterfaces")]
        public virtual void ResetNetworkInterfaces()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacement")]
        public virtual void ResetPlacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRamDiskId")]
        public virtual void ResetRamDiskId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroupNames")]
        public virtual void ResetSecurityGroupNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagSpecifications")]
        public virtual void ResetTagSpecifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdateDefaultVersion")]
        public virtual void ResetUpdateDefaultVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserData")]
        public virtual void ResetUserData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcSecurityGroupIds")]
        public virtual void ResetVpcSecurityGroupIds()
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
        = GetStaticProperty<string>(typeof(aws.Ec2.LaunchTemplate))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capacityReservationSpecification", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCapacityReservationSpecificationOutputReference\"}")]
        public virtual aws.Ec2.LaunchTemplateCapacityReservationSpecificationOutputReference CapacityReservationSpecification
        {
            get => GetInstanceProperty<aws.Ec2.LaunchTemplateCapacityReservationSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "cpuOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCpuOptionsOutputReference\"}")]
        public virtual aws.Ec2.LaunchTemplateCpuOptionsOutputReference CpuOptions
        {
            get => GetInstanceProperty<aws.Ec2.LaunchTemplateCpuOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "creditSpecification", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCreditSpecificationOutputReference\"}")]
        public virtual aws.Ec2.LaunchTemplateCreditSpecificationOutputReference CreditSpecification
        {
            get => GetInstanceProperty<aws.Ec2.LaunchTemplateCreditSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "elasticInferenceAccelerator", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateElasticInferenceAcceleratorOutputReference\"}")]
        public virtual aws.Ec2.LaunchTemplateElasticInferenceAcceleratorOutputReference ElasticInferenceAccelerator
        {
            get => GetInstanceProperty<aws.Ec2.LaunchTemplateElasticInferenceAcceleratorOutputReference>()!;
        }

        [JsiiProperty(name: "hibernationOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateHibernationOptionsOutputReference\"}")]
        public virtual aws.Ec2.LaunchTemplateHibernationOptionsOutputReference HibernationOptions
        {
            get => GetInstanceProperty<aws.Ec2.LaunchTemplateHibernationOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateIamInstanceProfileOutputReference\"}")]
        public virtual aws.Ec2.LaunchTemplateIamInstanceProfileOutputReference IamInstanceProfile
        {
            get => GetInstanceProperty<aws.Ec2.LaunchTemplateIamInstanceProfileOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceMarketOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateInstanceMarketOptionsOutputReference\"}")]
        public virtual aws.Ec2.LaunchTemplateInstanceMarketOptionsOutputReference InstanceMarketOptions
        {
            get => GetInstanceProperty<aws.Ec2.LaunchTemplateInstanceMarketOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "latestVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LatestVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "metadataOptions", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateMetadataOptionsOutputReference\"}")]
        public virtual aws.Ec2.LaunchTemplateMetadataOptionsOutputReference MetadataOptions
        {
            get => GetInstanceProperty<aws.Ec2.LaunchTemplateMetadataOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "monitoring", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateMonitoringOutputReference\"}")]
        public virtual aws.Ec2.LaunchTemplateMonitoringOutputReference Monitoring
        {
            get => GetInstanceProperty<aws.Ec2.LaunchTemplateMonitoringOutputReference>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplatePlacementOutputReference\"}")]
        public virtual aws.Ec2.LaunchTemplatePlacementOutputReference Placement
        {
            get => GetInstanceProperty<aws.Ec2.LaunchTemplatePlacementOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockDeviceMappingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateBlockDeviceMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BlockDeviceMappingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationSpecificationInput", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCapacityReservationSpecification\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplateCapacityReservationSpecification? CapacityReservationSpecificationInput
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplateCapacityReservationSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuOptionsInput", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCpuOptions\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplateCpuOptions? CpuOptionsInput
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplateCpuOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "creditSpecificationInput", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCreditSpecification\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplateCreditSpecification? CreditSpecificationInput
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplateCreditSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableApiTerminationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisableApiTerminationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsOptimizedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EbsOptimizedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticGpuSpecificationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateElasticGpuSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ElasticGpuSpecificationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticInferenceAcceleratorInput", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateElasticInferenceAccelerator\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplateElasticInferenceAccelerator? ElasticInferenceAcceleratorInput
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplateElasticInferenceAccelerator?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hibernationOptionsInput", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateHibernationOptions\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplateHibernationOptions? HibernationOptionsInput
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplateHibernationOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamInstanceProfileInput", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateIamInstanceProfile\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplateIamInstanceProfile? IamInstanceProfileInput
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplateIamInstanceProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceInitiatedShutdownBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceInitiatedShutdownBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceMarketOptionsInput", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateInstanceMarketOptions\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplateInstanceMarketOptions? InstanceMarketOptionsInput
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplateInstanceMarketOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KernelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licenseSpecificationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateLicenseSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LicenseSpecificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataOptionsInput", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateMetadataOptions\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplateMetadataOptions? MetadataOptionsInput
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplateMetadataOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringInput", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateMonitoring\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplateMonitoring? MonitoringInput
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplateMonitoring?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfacesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateNetworkInterfaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkInterfacesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementInput", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplatePlacement\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplatePlacement? PlacementInput
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplatePlacement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ramDiskIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RamDiskIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagSpecificationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateTagSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagSpecificationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateDefaultVersionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UpdateDefaultVersionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userDataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserDataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcSecurityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VpcSecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "blockDeviceMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateBlockDeviceMappings\"},\"kind\":\"array\"}}]}}")]
        public virtual object BlockDeviceMappings
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DisableApiTermination
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbsOptimized
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "elasticGpuSpecifications", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateElasticGpuSpecifications\"},\"kind\":\"array\"}}]}}")]
        public virtual object ElasticGpuSpecifications
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceInitiatedShutdownBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KernelId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "licenseSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateLicenseSpecification\"},\"kind\":\"array\"}}]}}")]
        public virtual object LicenseSpecification
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

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkInterfaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateNetworkInterfaces\"},\"kind\":\"array\"}}]}}")]
        public virtual object NetworkInterfaces
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ramDiskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RamDiskId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupNames
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

        [JsiiProperty(name: "tagSpecifications", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.LaunchTemplateTagSpecifications\"},\"kind\":\"array\"}}]}}")]
        public virtual object TagSpecifications
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "updateDefaultVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object UpdateDefaultVersion
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserData
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
