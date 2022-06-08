using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecs.EcsTaskDefinitionVolume")]
    public class EcsTaskDefinitionVolume : aws.Ecs.IEcsTaskDefinitionVolume
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#name EcsTaskDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>docker_volume_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#docker_volume_configuration EcsTaskDefinition#docker_volume_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dockerVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeDockerVolumeConfiguration\"}", isOptional: true)]
        public aws.Ecs.IEcsTaskDefinitionVolumeDockerVolumeConfiguration? DockerVolumeConfiguration
        {
            get;
            set;
        }

        /// <summary>efs_volume_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#efs_volume_configuration EcsTaskDefinition#efs_volume_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "efsVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfiguration\"}", isOptional: true)]
        public aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfiguration? EfsVolumeConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#host_path EcsTaskDefinition#host_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostPath
        {
            get;
            set;
        }
    }
}
