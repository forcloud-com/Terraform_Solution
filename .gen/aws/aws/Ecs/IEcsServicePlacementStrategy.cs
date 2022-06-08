using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiInterface(nativeType: typeof(IEcsServicePlacementStrategy), fullyQualifiedName: "aws.ecs.EcsServicePlacementStrategy")]
    public interface IEcsServicePlacementStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#type EcsService#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#field EcsService#field}.</summary>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Field
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServicePlacementStrategy), fullyQualifiedName: "aws.ecs.EcsServicePlacementStrategy")]
        internal sealed class _Proxy : DeputyBase, aws.Ecs.IEcsServicePlacementStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#type EcsService#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#field EcsService#field}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Field
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
