using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    /// <summary>AWS CodeDeploy.</summary>
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupConfig), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupConfig")]
    public interface ICodedeployDeploymentGroupConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#app_name CodedeployDeploymentGroup#app_name}.</summary>
        [JsiiProperty(name: "appName", typeJson: "{\"primitive\":\"string\"}")]
        string AppName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#deployment_group_name CodedeployDeploymentGroup#deployment_group_name}.</summary>
        [JsiiProperty(name: "deploymentGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string DeploymentGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#service_role_arn CodedeployDeploymentGroup#service_role_arn}.</summary>
        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceRoleArn
        {
            get;
        }

        /// <summary>alarm_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#alarm_configuration CodedeployDeploymentGroup#alarm_configuration}
        /// </remarks>
        [JsiiProperty(name: "alarmConfiguration", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupAlarmConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codedeploy.ICodedeployDeploymentGroupAlarmConfiguration? AlarmConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>auto_rollback_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#auto_rollback_configuration CodedeployDeploymentGroup#auto_rollback_configuration}
        /// </remarks>
        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupAutoRollbackConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codedeploy.ICodedeployDeploymentGroupAutoRollbackConfiguration? AutoRollbackConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#autoscaling_groups CodedeployDeploymentGroup#autoscaling_groups}.</summary>
        [JsiiProperty(name: "autoscalingGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AutoscalingGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>blue_green_deployment_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#blue_green_deployment_config CodedeployDeploymentGroup#blue_green_deployment_config}
        /// </remarks>
        [JsiiProperty(name: "blueGreenDeploymentConfig", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfig? BlueGreenDeploymentConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#deployment_config_name CodedeployDeploymentGroup#deployment_config_name}.</summary>
        [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeploymentConfigName
        {
            get
            {
                return null;
            }
        }

        /// <summary>deployment_style block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#deployment_style CodedeployDeploymentGroup#deployment_style}
        /// </remarks>
        [JsiiProperty(name: "deploymentStyle", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupDeploymentStyle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codedeploy.ICodedeployDeploymentGroupDeploymentStyle? DeploymentStyle
        {
            get
            {
                return null;
            }
        }

        /// <summary>ec2_tag_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#ec2_tag_filter CodedeployDeploymentGroup#ec2_tag_filter}
        /// </remarks>
        [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEc2TagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ec2TagFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>ec2_tag_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#ec2_tag_set CodedeployDeploymentGroup#ec2_tag_set}
        /// </remarks>
        [JsiiProperty(name: "ec2TagSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEc2TagSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ec2TagSet
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecs_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#ecs_service CodedeployDeploymentGroup#ecs_service}
        /// </remarks>
        [JsiiProperty(name: "ecsService", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEcsService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codedeploy.ICodedeployDeploymentGroupEcsService? EcsService
        {
            get
            {
                return null;
            }
        }

        /// <summary>load_balancer_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#load_balancer_info CodedeployDeploymentGroup#load_balancer_info}
        /// </remarks>
        [JsiiProperty(name: "loadBalancerInfo", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfo? LoadBalancerInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>on_premises_instance_tag_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#on_premises_instance_tag_filter CodedeployDeploymentGroup#on_premises_instance_tag_filter}
        /// </remarks>
        [JsiiProperty(name: "onPremisesInstanceTagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupOnPremisesInstanceTagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OnPremisesInstanceTagFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>trigger_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#trigger_configuration CodedeployDeploymentGroup#trigger_configuration}
        /// </remarks>
        [JsiiProperty(name: "triggerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupTriggerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TriggerConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS CodeDeploy.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupConfig), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#app_name CodedeployDeploymentGroup#app_name}.</summary>
            [JsiiProperty(name: "appName", typeJson: "{\"primitive\":\"string\"}")]
            public string AppName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#deployment_group_name CodedeployDeploymentGroup#deployment_group_name}.</summary>
            [JsiiProperty(name: "deploymentGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeploymentGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#service_role_arn CodedeployDeploymentGroup#service_role_arn}.</summary>
            [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>alarm_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#alarm_configuration CodedeployDeploymentGroup#alarm_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alarmConfiguration", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupAlarmConfiguration\"}", isOptional: true)]
            public aws.Codedeploy.ICodedeployDeploymentGroupAlarmConfiguration? AlarmConfiguration
            {
                get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupAlarmConfiguration?>();
            }

            /// <summary>auto_rollback_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#auto_rollback_configuration CodedeployDeploymentGroup#auto_rollback_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupAutoRollbackConfiguration\"}", isOptional: true)]
            public aws.Codedeploy.ICodedeployDeploymentGroupAutoRollbackConfiguration? AutoRollbackConfiguration
            {
                get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupAutoRollbackConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#autoscaling_groups CodedeployDeploymentGroup#autoscaling_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoscalingGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AutoscalingGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>blue_green_deployment_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#blue_green_deployment_config CodedeployDeploymentGroup#blue_green_deployment_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blueGreenDeploymentConfig", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfig\"}", isOptional: true)]
            public aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfig? BlueGreenDeploymentConfig
            {
                get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#deployment_config_name CodedeployDeploymentGroup#deployment_config_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeploymentConfigName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>deployment_style block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#deployment_style CodedeployDeploymentGroup#deployment_style}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentStyle", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupDeploymentStyle\"}", isOptional: true)]
            public aws.Codedeploy.ICodedeployDeploymentGroupDeploymentStyle? DeploymentStyle
            {
                get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupDeploymentStyle?>();
            }

            /// <summary>ec2_tag_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#ec2_tag_filter CodedeployDeploymentGroup#ec2_tag_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEc2TagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ec2TagFilter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ec2_tag_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#ec2_tag_set CodedeployDeploymentGroup#ec2_tag_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ec2TagSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEc2TagSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ec2TagSet
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ecs_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#ecs_service CodedeployDeploymentGroup#ecs_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecsService", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEcsService\"}", isOptional: true)]
            public aws.Codedeploy.ICodedeployDeploymentGroupEcsService? EcsService
            {
                get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupEcsService?>();
            }

            /// <summary>load_balancer_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#load_balancer_info CodedeployDeploymentGroup#load_balancer_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerInfo", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfo\"}", isOptional: true)]
            public aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfo? LoadBalancerInfo
            {
                get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfo?>();
            }

            /// <summary>on_premises_instance_tag_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#on_premises_instance_tag_filter CodedeployDeploymentGroup#on_premises_instance_tag_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onPremisesInstanceTagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupOnPremisesInstanceTagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OnPremisesInstanceTagFilter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>trigger_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#trigger_configuration CodedeployDeploymentGroup#trigger_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "triggerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupTriggerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TriggerConfiguration
            {
                get => GetInstanceProperty<object?>();
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
