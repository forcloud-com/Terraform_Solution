using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    [JsiiClass(nativeType: typeof(aws.Batch.BatchComputeEnvironmentComputeResourcesOutputReference), fullyQualifiedName: "aws.batch.BatchComputeEnvironmentComputeResourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BatchComputeEnvironmentComputeResourcesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BatchComputeEnvironmentComputeResourcesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchComputeEnvironmentComputeResourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchComputeEnvironmentComputeResourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLaunchTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.batch.BatchComputeEnvironmentComputeResourcesLaunchTemplate\"}}]")]
        public virtual void PutLaunchTemplate(aws.Batch.IBatchComputeEnvironmentComputeResourcesLaunchTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Batch.IBatchComputeEnvironmentComputeResourcesLaunchTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllocationStrategy")]
        public virtual void ResetAllocationStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBidPercentage")]
        public virtual void ResetBidPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDesiredVcpus")]
        public virtual void ResetDesiredVcpus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2KeyPair")]
        public virtual void ResetEc2KeyPair()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageId")]
        public virtual void ResetImageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchTemplate")]
        public virtual void ResetLaunchTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotIamFleetRole")]
        public virtual void ResetSpotIamFleetRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.batch.BatchComputeEnvironmentComputeResourcesLaunchTemplateOutputReference\"}")]
        public virtual aws.Batch.BatchComputeEnvironmentComputeResourcesLaunchTemplateOutputReference LaunchTemplate
        {
            get => GetInstanceProperty<aws.Batch.BatchComputeEnvironmentComputeResourcesLaunchTemplateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocationStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AllocationStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bidPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BidPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredVcpusInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DesiredVcpusInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2KeyPairInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ec2KeyPairInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? InstanceTypeInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateInput", typeJson: "{\"fqn\":\"aws.batch.BatchComputeEnvironmentComputeResourcesLaunchTemplate\"}", isOptional: true)]
        public virtual aws.Batch.IBatchComputeEnvironmentComputeResourcesLaunchTemplate? LaunchTemplateInput
        {
            get => GetInstanceProperty<aws.Batch.IBatchComputeEnvironmentComputeResourcesLaunchTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxVcpusInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxVcpusInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minVcpusInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinVcpusInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotIamFleetRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpotIamFleetRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SubnetsInput
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
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllocationStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bidPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BidPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "desiredVcpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredVcpus
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ec2KeyPair", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ec2KeyPair
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InstanceType
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxVcpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxVcpus
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minVcpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinVcpus
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spotIamFleetRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotIamFleetRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Subnets
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.batch.BatchComputeEnvironmentComputeResources\"}", isOptional: true)]
        public virtual aws.Batch.IBatchComputeEnvironmentComputeResources? InternalValue
        {
            get => GetInstanceProperty<aws.Batch.IBatchComputeEnvironmentComputeResources?>();
            set => SetInstanceProperty(value);
        }
    }
}
