using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig")]
    public interface IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#access_point_id EcsTaskDefinition#access_point_id}.</summary>
        [JsiiProperty(name: "accessPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessPointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#iam EcsTaskDefinition#iam}.</summary>
        [JsiiProperty(name: "iam", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Iam
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ecs.IEcsTaskDefinitionVolumeEfsVolumeConfigurationAuthorizationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#access_point_id EcsTaskDefinition#access_point_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessPointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessPointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#iam EcsTaskDefinition#iam}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iam", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Iam
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
