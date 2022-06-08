using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Gamelift
{
    #pragma warning disable CS8618

    /// <summary>AWS GameLift.</summary>
    [JsiiByValue(fqn: "aws.gamelift.GameliftFleetConfig")]
    public class GameliftFleetConfig : aws.Gamelift.IGameliftFleetConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#build_id GameliftFleet#build_id}.</summary>
        [JsiiProperty(name: "buildId", typeJson: "{\"primitive\":\"string\"}")]
        public string BuildId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#ec2_instance_type GameliftFleet#ec2_instance_type}.</summary>
        [JsiiProperty(name: "ec2InstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public string Ec2InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#name GameliftFleet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#description GameliftFleet#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>ec2_inbound_permission block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#ec2_inbound_permission GameliftFleet#ec2_inbound_permission}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ec2InboundPermission", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.gamelift.GameliftFleetEc2InboundPermission\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ec2InboundPermission
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#fleet_type GameliftFleet#fleet_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fleetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FleetType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#instance_role_arn GameliftFleet#instance_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#metric_groups GameliftFleet#metric_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? MetricGroups
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#new_game_session_protection_policy GameliftFleet#new_game_session_protection_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "newGameSessionProtectionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NewGameSessionProtectionPolicy
        {
            get;
            set;
        }

        /// <summary>resource_creation_limit_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#resource_creation_limit_policy GameliftFleet#resource_creation_limit_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceCreationLimitPolicy", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetResourceCreationLimitPolicy\"}", isOptional: true)]
        public aws.Gamelift.IGameliftFleetResourceCreationLimitPolicy? ResourceCreationLimitPolicy
        {
            get;
            set;
        }

        /// <summary>runtime_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#runtime_configuration GameliftFleet#runtime_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runtimeConfiguration", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetRuntimeConfiguration\"}", isOptional: true)]
        public aws.Gamelift.IGameliftFleetRuntimeConfiguration? RuntimeConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#tags GameliftFleet#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#timeouts GameliftFleet#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.gamelift.GameliftFleetTimeouts\"}", isOptional: true)]
        public aws.Gamelift.IGameliftFleetTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
