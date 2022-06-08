using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionVolume), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionVolume")]
    public interface IEcsTaskDefinitionVolume
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#name EcsTaskDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>docker_volume_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#docker_volume_configuration EcsTaskDefinition#docker_volume_configuration}
        /// </remarks>
        [JsiiProperty(name: "dockerVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeDockerVolumeConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ecs.IEcsTaskDefinitionVolumeDockerVolumeConfiguration? DockerVolumeConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>efs_volume_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#efs_volume_configuration EcsTaskDefinition#efs_volume_configuration}
        /// </remarks>
        [JsiiProperty(name: "efsVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfiguration? EfsVolumeConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#host_path EcsTaskDefinition#host_path}.</summary>
        [JsiiProperty(name: "hostPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionVolume), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionVolume")]
        internal sealed class _Proxy : DeputyBase, aws.Ecs.IEcsTaskDefinitionVolume
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#name EcsTaskDefinition#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>docker_volume_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#docker_volume_configuration EcsTaskDefinition#docker_volume_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dockerVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeDockerVolumeConfiguration\"}", isOptional: true)]
            public aws.Ecs.IEcsTaskDefinitionVolumeDockerVolumeConfiguration? DockerVolumeConfiguration
            {
                get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionVolumeDockerVolumeConfiguration?>();
            }

            /// <summary>efs_volume_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#efs_volume_configuration EcsTaskDefinition#efs_volume_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "efsVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfiguration\"}", isOptional: true)]
            public aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfiguration? EfsVolumeConfiguration
            {
                get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#host_path EcsTaskDefinition#host_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
