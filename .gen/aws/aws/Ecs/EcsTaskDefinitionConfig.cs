using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    #pragma warning disable CS8618

    /// <summary>AWS EC2 Container Service.</summary>
    [JsiiByValue(fqn: "aws.ecs.EcsTaskDefinitionConfig")]
    public class EcsTaskDefinitionConfig : aws.Ecs.IEcsTaskDefinitionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#container_definitions EcsTaskDefinition#container_definitions}.</summary>
        [JsiiProperty(name: "containerDefinitions", typeJson: "{\"primitive\":\"string\"}")]
        public string ContainerDefinitions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#family EcsTaskDefinition#family}.</summary>
        [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}")]
        public string Family
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#cpu EcsTaskDefinition#cpu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cpu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#execution_role_arn EcsTaskDefinition#execution_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExecutionRoleArn
        {
            get;
            set;
        }

        /// <summary>inference_accelerator block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#inference_accelerator EcsTaskDefinition#inference_accelerator}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceAccelerator", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionInferenceAccelerator\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InferenceAccelerator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#ipc_mode EcsTaskDefinition#ipc_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipcMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpcMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#memory EcsTaskDefinition#memory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Memory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#network_mode EcsTaskDefinition#network_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#pid_mode EcsTaskDefinition#pid_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pidMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PidMode
        {
            get;
            set;
        }

        /// <summary>placement_constraints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#placement_constraints EcsTaskDefinition#placement_constraints}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placementConstraints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionPlacementConstraints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PlacementConstraints
        {
            get;
            set;
        }

        /// <summary>proxy_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#proxy_configuration EcsTaskDefinition#proxy_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "proxyConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionProxyConfiguration\"}", isOptional: true)]
        public aws.Ecs.IEcsTaskDefinitionProxyConfiguration? ProxyConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#requires_compatibilities EcsTaskDefinition#requires_compatibilities}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requiresCompatibilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RequiresCompatibilities
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#tags EcsTaskDefinition#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#task_role_arn EcsTaskDefinition#task_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaskRoleArn
        {
            get;
            set;
        }

        /// <summary>volume block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#volume EcsTaskDefinition#volume}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volume", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolume\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Volume
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
