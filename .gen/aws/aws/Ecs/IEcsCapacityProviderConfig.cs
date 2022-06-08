using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    /// <summary>AWS EC2 Container Service.</summary>
    [JsiiInterface(nativeType: typeof(IEcsCapacityProviderConfig), fullyQualifiedName: "aws.ecs.EcsCapacityProviderConfig")]
    public interface IEcsCapacityProviderConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>auto_scaling_group_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#auto_scaling_group_provider EcsCapacityProvider#auto_scaling_group_provider}
        /// </remarks>
        [JsiiProperty(name: "autoScalingGroupProvider", typeJson: "{\"fqn\":\"aws.ecs.EcsCapacityProviderAutoScalingGroupProvider\"}")]
        aws.Ecs.IEcsCapacityProviderAutoScalingGroupProvider AutoScalingGroupProvider
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#name EcsCapacityProvider#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#tags EcsCapacityProvider#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EC2 Container Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IEcsCapacityProviderConfig), fullyQualifiedName: "aws.ecs.EcsCapacityProviderConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ecs.IEcsCapacityProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>auto_scaling_group_provider block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#auto_scaling_group_provider EcsCapacityProvider#auto_scaling_group_provider}
            /// </remarks>
            [JsiiProperty(name: "autoScalingGroupProvider", typeJson: "{\"fqn\":\"aws.ecs.EcsCapacityProviderAutoScalingGroupProvider\"}")]
            public aws.Ecs.IEcsCapacityProviderAutoScalingGroupProvider AutoScalingGroupProvider
            {
                get => GetInstanceProperty<aws.Ecs.IEcsCapacityProviderAutoScalingGroupProvider>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#name EcsCapacityProvider#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider#tags EcsCapacityProvider#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
