using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiInterface(nativeType: typeof(IEcsServiceServiceRegistries), fullyQualifiedName: "aws.ecs.EcsServiceServiceRegistries")]
    public interface IEcsServiceServiceRegistries
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#registry_arn EcsService#registry_arn}.</summary>
        [JsiiProperty(name: "registryArn", typeJson: "{\"primitive\":\"string\"}")]
        string RegistryArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#container_name EcsService#container_name}.</summary>
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#container_port EcsService#container_port}.</summary>
        [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ContainerPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#port EcsService#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceServiceRegistries), fullyQualifiedName: "aws.ecs.EcsServiceServiceRegistries")]
        internal sealed class _Proxy : DeputyBase, aws.Ecs.IEcsServiceServiceRegistries
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#registry_arn EcsService#registry_arn}.</summary>
            [JsiiProperty(name: "registryArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RegistryArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#container_name EcsService#container_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#container_port EcsService#container_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ContainerPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#port EcsService#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
