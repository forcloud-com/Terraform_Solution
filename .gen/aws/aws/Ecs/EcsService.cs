using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ecs_service aws_ecs_service}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ecs.EcsService), fullyQualifiedName: "aws.ecs.EcsService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ecs.EcsServiceConfig\"}}]")]
    public class EcsService : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ecs_service aws_ecs_service} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EcsService(Constructs.Construct scope, string id, aws.Ecs.IEcsServiceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsService(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDeploymentController", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsServiceDeploymentController\"}}]")]
        public virtual void PutDeploymentController(aws.Ecs.IEcsServiceDeploymentController @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsServiceDeploymentController)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsServiceNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(aws.Ecs.IEcsServiceNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsServiceNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceRegistries", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsServiceServiceRegistries\"}}]")]
        public virtual void PutServiceRegistries(aws.Ecs.IEcsServiceServiceRegistries @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsServiceServiceRegistries)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsServiceTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Ecs.IEcsServiceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsServiceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapacityProviderStrategy")]
        public virtual void ResetCapacityProviderStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCluster")]
        public virtual void ResetCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentController")]
        public virtual void ResetDeploymentController()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentMaximumPercent")]
        public virtual void ResetDeploymentMaximumPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentMinimumHealthyPercent")]
        public virtual void ResetDeploymentMinimumHealthyPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDesiredCount")]
        public virtual void ResetDesiredCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableEcsManagedTags")]
        public virtual void ResetEnableEcsManagedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceNewDeployment")]
        public virtual void ResetForceNewDeployment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckGracePeriodSeconds")]
        public virtual void ResetHealthCheckGracePeriodSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIamRole")]
        public virtual void ResetIamRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchType")]
        public virtual void ResetLaunchType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancer")]
        public virtual void ResetLoadBalancer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkConfiguration")]
        public virtual void ResetNetworkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrderedPlacementStrategy")]
        public virtual void ResetOrderedPlacementStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementConstraints")]
        public virtual void ResetPlacementConstraints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementStrategy")]
        public virtual void ResetPlacementStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatformVersion")]
        public virtual void ResetPlatformVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPropagateTags")]
        public virtual void ResetPropagateTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedulingStrategy")]
        public virtual void ResetSchedulingStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceRegistries")]
        public virtual void ResetServiceRegistries()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskDefinition")]
        public virtual void ResetTaskDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Ecs.EcsService))!;

        [JsiiProperty(name: "deploymentController", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceDeploymentControllerOutputReference\"}")]
        public virtual aws.Ecs.EcsServiceDeploymentControllerOutputReference DeploymentController
        {
            get => GetInstanceProperty<aws.Ecs.EcsServiceDeploymentControllerOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceNetworkConfigurationOutputReference\"}")]
        public virtual aws.Ecs.EcsServiceNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<aws.Ecs.EcsServiceNetworkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "serviceRegistries", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceServiceRegistriesOutputReference\"}")]
        public virtual aws.Ecs.EcsServiceServiceRegistriesOutputReference ServiceRegistries
        {
            get => GetInstanceProperty<aws.Ecs.EcsServiceServiceRegistriesOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceTimeoutsOutputReference\"}")]
        public virtual aws.Ecs.EcsServiceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Ecs.EcsServiceTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityProviderStrategyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceCapacityProviderStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CapacityProviderStrategyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentControllerInput", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceDeploymentController\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsServiceDeploymentController? DeploymentControllerInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsServiceDeploymentController?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentMaximumPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeploymentMaximumPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentMinimumHealthyPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeploymentMinimumHealthyPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DesiredCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableEcsManagedTagsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableEcsManagedTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceNewDeploymentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceNewDeploymentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckGracePeriodSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HealthCheckGracePeriodSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IamRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LaunchTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceLoadBalancer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LoadBalancerInput
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
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceNetworkConfiguration\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsServiceNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsServiceNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderedPlacementStrategyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceOrderedPlacementStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OrderedPlacementStrategyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementConstraintsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServicePlacementConstraints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PlacementConstraintsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementStrategyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServicePlacementStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PlacementStrategyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlatformVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propagateTagsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PropagateTagsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedulingStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchedulingStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRegistriesInput", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceServiceRegistries\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsServiceServiceRegistries? ServiceRegistriesInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsServiceServiceRegistries?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskDefinitionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskDefinitionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceTimeouts\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsServiceTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsServiceTimeouts?>();
        }

        [JsiiProperty(name: "capacityProviderStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceCapacityProviderStrategy\"},\"kind\":\"array\"}}]}}")]
        public virtual object CapacityProviderStrategy
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cluster", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cluster
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentMaximumPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeploymentMaximumPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentMinimumHealthyPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeploymentMinimumHealthyPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "desiredCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableEcsManagedTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableEcsManagedTags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceNewDeployment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceNewDeployment
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthCheckGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckGracePeriodSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iamRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceLoadBalancer\"},\"kind\":\"array\"}}]}}")]
        public virtual object LoadBalancer
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

        [JsiiProperty(name: "orderedPlacementStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceOrderedPlacementStrategy\"},\"kind\":\"array\"}}]}}")]
        public virtual object OrderedPlacementStrategy
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "placementConstraints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServicePlacementConstraints\"},\"kind\":\"array\"}}]}}")]
        public virtual object PlacementConstraints
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "placementStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServicePlacementStrategy\"},\"kind\":\"array\"}}]}}")]
        public virtual object PlacementStrategy
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PropagateTags
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schedulingStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchedulingStrategy
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

        [JsiiProperty(name: "taskDefinition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskDefinition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
