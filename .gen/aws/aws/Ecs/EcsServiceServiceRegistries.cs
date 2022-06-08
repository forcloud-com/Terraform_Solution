using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecs.EcsServiceServiceRegistries")]
    public class EcsServiceServiceRegistries : aws.Ecs.IEcsServiceServiceRegistries
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#registry_arn EcsService#registry_arn}.</summary>
        [JsiiProperty(name: "registryArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RegistryArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#container_name EcsService#container_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#container_port EcsService#container_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ContainerPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#port EcsService#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }
    }
}
