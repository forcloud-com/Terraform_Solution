using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiByValue(fqn: "aws.ecs.EcsTaskDefinitionVolumeDockerVolumeConfiguration")]
    public class EcsTaskDefinitionVolumeDockerVolumeConfiguration : aws.Ecs.IEcsTaskDefinitionVolumeDockerVolumeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#autoprovision EcsTaskDefinition#autoprovision}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoprovision", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Autoprovision
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#driver EcsTaskDefinition#driver}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Driver
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#driver_opts EcsTaskDefinition#driver_opts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "driverOpts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DriverOpts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#labels EcsTaskDefinition#labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#scope EcsTaskDefinition#scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Scope
        {
            get;
            set;
        }
    }
}
