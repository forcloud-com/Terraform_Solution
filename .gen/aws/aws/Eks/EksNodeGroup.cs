using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group aws_eks_node_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.Eks.EksNodeGroup), fullyQualifiedName: "aws.eks.EksNodeGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.eks.EksNodeGroupConfig\"}}]")]
    public class EksNodeGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group aws_eks_node_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EksNodeGroup(Constructs.Construct scope, string id, aws.Eks.IEksNodeGroupConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksNodeGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksNodeGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRemoteAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eks.EksNodeGroupRemoteAccess\"}}]")]
        public virtual void PutRemoteAccess(aws.Eks.IEksNodeGroupRemoteAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eks.IEksNodeGroupRemoteAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScalingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eks.EksNodeGroupScalingConfig\"}}]")]
        public virtual void PutScalingConfig(aws.Eks.IEksNodeGroupScalingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eks.IEksNodeGroupScalingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eks.EksNodeGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Eks.IEksNodeGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eks.IEksNodeGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmiType")]
        public virtual void ResetAmiType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiskSize")]
        public virtual void ResetDiskSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceUpdateVersion")]
        public virtual void ResetForceUpdateVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceTypes")]
        public virtual void ResetInstanceTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabels")]
        public virtual void ResetLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReleaseVersion")]
        public virtual void ResetReleaseVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRemoteAccess")]
        public virtual void ResetRemoteAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
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
        = GetStaticProperty<string>(typeof(aws.Eks.EksNodeGroup))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remoteAccess", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupRemoteAccessOutputReference\"}")]
        public virtual aws.Eks.EksNodeGroupRemoteAccessOutputReference RemoteAccess
        {
            get => GetInstanceProperty<aws.Eks.EksNodeGroupRemoteAccessOutputReference>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupResourcesList\"}")]
        public virtual aws.Eks.EksNodeGroupResourcesList Resources
        {
            get => GetInstanceProperty<aws.Eks.EksNodeGroupResourcesList>()!;
        }

        [JsiiProperty(name: "scalingConfig", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupScalingConfigOutputReference\"}")]
        public virtual aws.Eks.EksNodeGroupScalingConfigOutputReference ScalingConfig
        {
            get => GetInstanceProperty<aws.Eks.EksNodeGroupScalingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupTimeoutsOutputReference\"}")]
        public virtual aws.Eks.EksNodeGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Eks.EksNodeGroupTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amiTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AmiTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DiskSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceUpdateVersionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceUpdateVersionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? InstanceTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? LabelsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "releaseVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReleaseVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "remoteAccessInput", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupRemoteAccess\"}", isOptional: true)]
        public virtual aws.Eks.IEksNodeGroupRemoteAccess? RemoteAccessInput
        {
            get => GetInstanceProperty<aws.Eks.IEksNodeGroupRemoteAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalingConfigInput", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupScalingConfig\"}", isOptional: true)]
        public virtual aws.Eks.IEksNodeGroupScalingConfig? ScalingConfigInput
        {
            get => GetInstanceProperty<aws.Eks.IEksNodeGroupScalingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SubnetIdsInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.eks.EksNodeGroupTimeouts\"}", isOptional: true)]
        public virtual aws.Eks.IEksNodeGroupTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Eks.IEksNodeGroupTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "amiType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AmiType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DiskSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceUpdateVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceUpdateVersion
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InstanceTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "releaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
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

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
