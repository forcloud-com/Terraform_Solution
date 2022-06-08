using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfiguration")]
    public class EcsTaskDefinitionVolumeEfsVolumeConfiguration : aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#file_system_id EcsTaskDefinition#file_system_id}.</summary>
        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public string FileSystemId
        {
            get;
            set;
        }

        /// <summary>authorization_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#authorization_config EcsTaskDefinition#authorization_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authorizationConfig", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig\"}", isOptional: true)]
        public aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig? AuthorizationConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#root_directory EcsTaskDefinition#root_directory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootDirectory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RootDirectory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#transit_encryption EcsTaskDefinition#transit_encryption}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transitEncryption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransitEncryption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#transit_encryption_port EcsTaskDefinition#transit_encryption_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transitEncryptionPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TransitEncryptionPort
        {
            get;
            set;
        }
    }
}
