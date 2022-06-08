using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    /// <summary>AWS EC2 Container Service.</summary>
    [JsiiInterface(nativeType: typeof(IEcsServiceConfig), fullyQualifiedName: "aws.ecs.EcsServiceConfig")]
    public interface IEcsServiceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#name EcsService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>capacity_provider_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#capacity_provider_strategy EcsService#capacity_provider_strategy}
        /// </remarks>
        [JsiiProperty(name: "capacityProviderStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceCapacityProviderStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CapacityProviderStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#cluster EcsService#cluster}.</summary>
        [JsiiProperty(name: "cluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>deployment_controller block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#deployment_controller EcsService#deployment_controller}
        /// </remarks>
        [JsiiProperty(name: "deploymentController", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceDeploymentController\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ecs.IEcsServiceDeploymentController? DeploymentController
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#deployment_maximum_percent EcsService#deployment_maximum_percent}.</summary>
        [JsiiProperty(name: "deploymentMaximumPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeploymentMaximumPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#deployment_minimum_healthy_percent EcsService#deployment_minimum_healthy_percent}.</summary>
        [JsiiProperty(name: "deploymentMinimumHealthyPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeploymentMinimumHealthyPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#desired_count EcsService#desired_count}.</summary>
        [JsiiProperty(name: "desiredCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DesiredCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#enable_ecs_managed_tags EcsService#enable_ecs_managed_tags}.</summary>
        [JsiiProperty(name: "enableEcsManagedTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableEcsManagedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#force_new_deployment EcsService#force_new_deployment}.</summary>
        [JsiiProperty(name: "forceNewDeployment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForceNewDeployment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#health_check_grace_period_seconds EcsService#health_check_grace_period_seconds}.</summary>
        [JsiiProperty(name: "healthCheckGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HealthCheckGracePeriodSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#iam_role EcsService#iam_role}.</summary>
        [JsiiProperty(name: "iamRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IamRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#launch_type EcsService#launch_type}.</summary>
        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LaunchType
        {
            get
            {
                return null;
            }
        }

        /// <summary>load_balancer block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#load_balancer EcsService#load_balancer}
        /// </remarks>
        [JsiiProperty(name: "loadBalancer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceLoadBalancer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LoadBalancer
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#network_configuration EcsService#network_configuration}
        /// </remarks>
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceNetworkConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ecs.IEcsServiceNetworkConfiguration? NetworkConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>ordered_placement_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#ordered_placement_strategy EcsService#ordered_placement_strategy}
        /// </remarks>
        [JsiiProperty(name: "orderedPlacementStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceOrderedPlacementStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OrderedPlacementStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>placement_constraints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#placement_constraints EcsService#placement_constraints}
        /// </remarks>
        [JsiiProperty(name: "placementConstraints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServicePlacementConstraints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PlacementConstraints
        {
            get
            {
                return null;
            }
        }

        /// <summary>placement_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#placement_strategy EcsService#placement_strategy}
        /// </remarks>
        [JsiiProperty(name: "placementStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServicePlacementStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PlacementStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#platform_version EcsService#platform_version}.</summary>
        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlatformVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#propagate_tags EcsService#propagate_tags}.</summary>
        [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PropagateTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#scheduling_strategy EcsService#scheduling_strategy}.</summary>
        [JsiiProperty(name: "schedulingStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SchedulingStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_registries block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#service_registries EcsService#service_registries}
        /// </remarks>
        [JsiiProperty(name: "serviceRegistries", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceServiceRegistries\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ecs.IEcsServiceServiceRegistries? ServiceRegistries
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#tags EcsService#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#task_definition EcsService#task_definition}.</summary>
        [JsiiProperty(name: "taskDefinition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaskDefinition
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#timeouts EcsService#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ecs.IEcsServiceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EC2 Container Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IEcsServiceConfig), fullyQualifiedName: "aws.ecs.EcsServiceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ecs.IEcsServiceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#name EcsService#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>capacity_provider_strategy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#capacity_provider_strategy EcsService#capacity_provider_strategy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacityProviderStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceCapacityProviderStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CapacityProviderStrategy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#cluster EcsService#cluster}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cluster
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>deployment_controller block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#deployment_controller EcsService#deployment_controller}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentController", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceDeploymentController\"}", isOptional: true)]
            public aws.Ecs.IEcsServiceDeploymentController? DeploymentController
            {
                get => GetInstanceProperty<aws.Ecs.IEcsServiceDeploymentController?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#deployment_maximum_percent EcsService#deployment_maximum_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentMaximumPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeploymentMaximumPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#deployment_minimum_healthy_percent EcsService#deployment_minimum_healthy_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentMinimumHealthyPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeploymentMinimumHealthyPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#desired_count EcsService#desired_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "desiredCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DesiredCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#enable_ecs_managed_tags EcsService#enable_ecs_managed_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableEcsManagedTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableEcsManagedTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#force_new_deployment EcsService#force_new_deployment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forceNewDeployment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ForceNewDeployment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#health_check_grace_period_seconds EcsService#health_check_grace_period_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HealthCheckGracePeriodSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#iam_role EcsService#iam_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iamRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IamRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#launch_type EcsService#launch_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LaunchType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>load_balancer block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#load_balancer EcsService#load_balancer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceLoadBalancer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LoadBalancer
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#network_configuration EcsService#network_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceNetworkConfiguration\"}", isOptional: true)]
            public aws.Ecs.IEcsServiceNetworkConfiguration? NetworkConfiguration
            {
                get => GetInstanceProperty<aws.Ecs.IEcsServiceNetworkConfiguration?>();
            }

            /// <summary>ordered_placement_strategy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#ordered_placement_strategy EcsService#ordered_placement_strategy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "orderedPlacementStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceOrderedPlacementStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OrderedPlacementStrategy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>placement_constraints block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#placement_constraints EcsService#placement_constraints}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placementConstraints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServicePlacementConstraints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PlacementConstraints
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>placement_strategy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#placement_strategy EcsService#placement_strategy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placementStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServicePlacementStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PlacementStrategy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#platform_version EcsService#platform_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlatformVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#propagate_tags EcsService#propagate_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PropagateTags
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#scheduling_strategy EcsService#scheduling_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schedulingStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SchedulingStrategy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>service_registries block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#service_registries EcsService#service_registries}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceRegistries", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceServiceRegistries\"}", isOptional: true)]
            public aws.Ecs.IEcsServiceServiceRegistries? ServiceRegistries
            {
                get => GetInstanceProperty<aws.Ecs.IEcsServiceServiceRegistries?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#tags EcsService#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#task_definition EcsService#task_definition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taskDefinition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaskDefinition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#timeouts EcsService#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceTimeouts\"}", isOptional: true)]
            public aws.Ecs.IEcsServiceTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Ecs.IEcsServiceTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
