using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionInferenceAccelerator), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionInferenceAccelerator")]
    public interface IEcsTaskDefinitionInferenceAccelerator
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#device_name EcsTaskDefinition#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        string DeviceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#device_type EcsTaskDefinition#device_type}.</summary>
        [JsiiProperty(name: "deviceType", typeJson: "{\"primitive\":\"string\"}")]
        string DeviceType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionInferenceAccelerator), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionInferenceAccelerator")]
        internal sealed class _Proxy : DeputyBase, aws.Ecs.IEcsTaskDefinitionInferenceAccelerator
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#device_name EcsTaskDefinition#device_name}.</summary>
            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeviceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#device_type EcsTaskDefinition#device_type}.</summary>
            [JsiiProperty(name: "deviceType", typeJson: "{\"primitive\":\"string\"}")]
            public string DeviceType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
