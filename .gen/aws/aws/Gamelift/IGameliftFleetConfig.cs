using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Gamelift
{
    /// <summary>AWS GameLift.</summary>
    [JsiiInterface(nativeType: typeof(IGameliftFleetConfig), fullyQualifiedName: "aws.gamelift.GameliftFleetConfig")]
    public interface IGameliftFleetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#build_id GameliftFleet#build_id}.</summary>
        [JsiiProperty(name: "buildId", typeJson: "{\"primitive\":\"string\"}")]
        string BuildId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#ec2_instance_type GameliftFleet#ec2_instance_type}.</summary>
        [JsiiProperty(name: "ec2InstanceType", typeJson: "{\"primitive\":\"string\"}")]
        string Ec2InstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#name GameliftFleet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#description GameliftFleet#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>ec2_inbound_permission block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#ec2_inbound_permission GameliftFleet#ec2_inbound_permission}
        /// </remarks>
        [JsiiProperty(name: "ec2InboundPermission", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gamelift.GameliftFleetEc2InboundPermission\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ec2InboundPermission
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#fleet_type GameliftFleet#fleet_type}.</summary>
        [JsiiProperty(name: "fleetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FleetType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#instance_role_arn GameliftFleet#instance_role_arn}.</summary>
        [JsiiProperty(name: "instanceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#metric_groups GameliftFleet#metric_groups}.</summary>
        [JsiiProperty(name: "metricGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MetricGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#new_game_session_protection_policy GameliftFleet#new_game_session_protection_policy}.</summary>
        [JsiiProperty(name: "newGameSessionProtectionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NewGameSessionProtectionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_creation_limit_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#resource_creation_limit_policy GameliftFleet#resource_creation_limit_policy}
        /// </remarks>
        [JsiiProperty(name: "resourceCreationLimitPolicy", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetResourceCreationLimitPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Gamelift.IGameliftFleetResourceCreationLimitPolicy? ResourceCreationLimitPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>runtime_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#runtime_configuration GameliftFleet#runtime_configuration}
        /// </remarks>
        [JsiiProperty(name: "runtimeConfiguration", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetRuntimeConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Gamelift.IGameliftFleetRuntimeConfiguration? RuntimeConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#tags GameliftFleet#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#timeouts GameliftFleet#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Gamelift.IGameliftFleetTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS GameLift.</summary>
        [JsiiTypeProxy(nativeType: typeof(IGameliftFleetConfig), fullyQualifiedName: "aws.gamelift.GameliftFleetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Gamelift.IGameliftFleetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#build_id GameliftFleet#build_id}.</summary>
            [JsiiProperty(name: "buildId", typeJson: "{\"primitive\":\"string\"}")]
            public string BuildId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#ec2_instance_type GameliftFleet#ec2_instance_type}.</summary>
            [JsiiProperty(name: "ec2InstanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string Ec2InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#name GameliftFleet#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#description GameliftFleet#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ec2_inbound_permission block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#ec2_inbound_permission GameliftFleet#ec2_inbound_permission}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ec2InboundPermission", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gamelift.GameliftFleetEc2InboundPermission\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ec2InboundPermission
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#fleet_type GameliftFleet#fleet_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fleetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FleetType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#instance_role_arn GameliftFleet#instance_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#metric_groups GameliftFleet#metric_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MetricGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#new_game_session_protection_policy GameliftFleet#new_game_session_protection_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "newGameSessionProtectionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NewGameSessionProtectionPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>resource_creation_limit_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#resource_creation_limit_policy GameliftFleet#resource_creation_limit_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceCreationLimitPolicy", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetResourceCreationLimitPolicy\"}", isOptional: true)]
            public aws.Gamelift.IGameliftFleetResourceCreationLimitPolicy? ResourceCreationLimitPolicy
            {
                get => GetInstanceProperty<aws.Gamelift.IGameliftFleetResourceCreationLimitPolicy?>();
            }

            /// <summary>runtime_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#runtime_configuration GameliftFleet#runtime_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeConfiguration", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetRuntimeConfiguration\"}", isOptional: true)]
            public aws.Gamelift.IGameliftFleetRuntimeConfiguration? RuntimeConfiguration
            {
                get => GetInstanceProperty<aws.Gamelift.IGameliftFleetRuntimeConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#tags GameliftFleet#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#timeouts GameliftFleet#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetTimeouts\"}", isOptional: true)]
            public aws.Gamelift.IGameliftFleetTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Gamelift.IGameliftFleetTimeouts?>();
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
