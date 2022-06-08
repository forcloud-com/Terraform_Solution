using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionVolumeEfsVolumeConfiguration), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfiguration")]
    public interface IEcsTaskDefinitionVolumeEfsVolumeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#file_system_id EcsTaskDefinition#file_system_id}.</summary>
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        string FileSystemId
        {
            get;
        }

        /// <summary>authorization_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#authorization_config EcsTaskDefinition#authorization_config}
        /// </remarks>
        [JsiiProperty(name: "authorizationConfig", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig? AuthorizationConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#root_directory EcsTaskDefinition#root_directory}.</summary>
        [JsiiProperty(name: "rootDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RootDirectory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#transit_encryption EcsTaskDefinition#transit_encryption}.</summary>
        [JsiiProperty(name: "transitEncryption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransitEncryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#transit_encryption_port EcsTaskDefinition#transit_encryption_port}.</summary>
        [JsiiProperty(name: "transitEncryptionPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TransitEncryptionPort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionVolumeEfsVolumeConfiguration), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#file_system_id EcsTaskDefinition#file_system_id}.</summary>
            [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
            public string FileSystemId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authorization_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#authorization_config EcsTaskDefinition#authorization_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authorizationConfig", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig\"}", isOptional: true)]
            public aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig? AuthorizationConfig
            {
                get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#root_directory EcsTaskDefinition#root_directory}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rootDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RootDirectory
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#transit_encryption EcsTaskDefinition#transit_encryption}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transitEncryption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransitEncryption
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#transit_encryption_port EcsTaskDefinition#transit_encryption_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transitEncryptionPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TransitEncryptionPort
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
