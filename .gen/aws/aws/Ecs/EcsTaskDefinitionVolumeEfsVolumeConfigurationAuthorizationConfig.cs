using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiByValue(fqn: "aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig")]
    public class EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig : aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#access_point_id EcsTaskDefinition#access_point_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessPointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#iam EcsTaskDefinition#iam}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iam", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Iam
        {
            get;
            set;
        }
    }
}
