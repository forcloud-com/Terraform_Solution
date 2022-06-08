using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    #pragma warning disable CS8618

    /// <summary>AWS EC2 Container Service.</summary>
    [JsiiByValue(fqn: "aws.ecs.EcsServiceConfig")]
    public class EcsServiceConfig : aws.Ecs.IEcsServiceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#name EcsService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>capacity_provider_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#capacity_provider_strategy EcsService#capacity_provider_strategy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capacityProviderStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceCapacityProviderStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CapacityProviderStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#cluster EcsService#cluster}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cluster
        {
            get;
            set;
        }

        /// <summary>deployment_controller block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#deployment_controller EcsService#deployment_controller}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentController", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceDeploymentController\"}", isOptional: true)]
        public aws.Ecs.IEcsServiceDeploymentController? DeploymentController
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#deployment_maximum_percent EcsService#deployment_maximum_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentMaximumPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeploymentMaximumPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#deployment_minimum_healthy_percent EcsService#deployment_minimum_healthy_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentMinimumHealthyPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeploymentMinimumHealthyPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#desired_count EcsService#desired_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "desiredCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DesiredCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#enable_ecs_managed_tags EcsService#enable_ecs_managed_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableEcsManagedTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableEcsManagedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#force_new_deployment EcsService#force_new_deployment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forceNewDeployment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ForceNewDeployment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#health_check_grace_period_seconds EcsService#health_check_grace_period_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthCheckGracePeriodSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#iam_role EcsService#iam_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iamRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IamRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#launch_type EcsService#launch_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LaunchType
        {
            get;
            set;
        }

        /// <summary>load_balancer block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#load_balancer EcsService#load_balancer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceLoadBalancer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LoadBalancer
        {
            get;
            set;
        }

        /// <summary>network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#network_configuration EcsService#network_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceNetworkConfiguration\"}", isOptional: true)]
        public aws.Ecs.IEcsServiceNetworkConfiguration? NetworkConfiguration
        {
            get;
            set;
        }

        /// <summary>ordered_placement_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#ordered_placement_strategy EcsService#ordered_placement_strategy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "orderedPlacementStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServiceOrderedPlacementStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OrderedPlacementStrategy
        {
            get;
            set;
        }

        /// <summary>placement_constraints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#placement_constraints EcsService#placement_constraints}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placementConstraints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServicePlacementConstraints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PlacementConstraints
        {
            get;
            set;
        }

        /// <summary>placement_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#placement_strategy EcsService#placement_strategy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placementStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsServicePlacementStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PlacementStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#platform_version EcsService#platform_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlatformVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#propagate_tags EcsService#propagate_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PropagateTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#scheduling_strategy EcsService#scheduling_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schedulingStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SchedulingStrategy
        {
            get;
            set;
        }

        /// <summary>service_registries block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#service_registries EcsService#service_registries}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceRegistries", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceServiceRegistries\"}", isOptional: true)]
        public aws.Ecs.IEcsServiceServiceRegistries? ServiceRegistries
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#tags EcsService#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#task_definition EcsService#task_definition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskDefinition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaskDefinition
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#timeouts EcsService#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ecs.EcsServiceTimeouts\"}", isOptional: true)]
        public aws.Ecs.IEcsServiceTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
