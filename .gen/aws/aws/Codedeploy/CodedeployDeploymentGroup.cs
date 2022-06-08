using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group aws_codedeploy_deployment_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.Codedeploy.CodedeployDeploymentGroup), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupConfig\"}}]")]
    public class CodedeployDeploymentGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group aws_codedeploy_deployment_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CodedeployDeploymentGroup(Constructs.Construct scope, string id, aws.Codedeploy.ICodedeployDeploymentGroupConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAlarmConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupAlarmConfiguration\"}}]")]
        public virtual void PutAlarmConfiguration(aws.Codedeploy.ICodedeployDeploymentGroupAlarmConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentGroupAlarmConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutoRollbackConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupAutoRollbackConfiguration\"}}]")]
        public virtual void PutAutoRollbackConfiguration(aws.Codedeploy.ICodedeployDeploymentGroupAutoRollbackConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentGroupAutoRollbackConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlueGreenDeploymentConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfig\"}}]")]
        public virtual void PutBlueGreenDeploymentConfig(aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeploymentStyle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupDeploymentStyle\"}}]")]
        public virtual void PutDeploymentStyle(aws.Codedeploy.ICodedeployDeploymentGroupDeploymentStyle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentGroupDeploymentStyle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEcsService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEcsService\"}}]")]
        public virtual void PutEcsService(aws.Codedeploy.ICodedeployDeploymentGroupEcsService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentGroupEcsService)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoadBalancerInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfo\"}}]")]
        public virtual void PutLoadBalancerInfo(aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlarmConfiguration")]
        public virtual void ResetAlarmConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoRollbackConfiguration")]
        public virtual void ResetAutoRollbackConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoscalingGroups")]
        public virtual void ResetAutoscalingGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlueGreenDeploymentConfig")]
        public virtual void ResetBlueGreenDeploymentConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentConfigName")]
        public virtual void ResetDeploymentConfigName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentStyle")]
        public virtual void ResetDeploymentStyle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2TagFilter")]
        public virtual void ResetEc2TagFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2TagSet")]
        public virtual void ResetEc2TagSet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcsService")]
        public virtual void ResetEcsService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancerInfo")]
        public virtual void ResetLoadBalancerInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnPremisesInstanceTagFilter")]
        public virtual void ResetOnPremisesInstanceTagFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTriggerConfiguration")]
        public virtual void ResetTriggerConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Codedeploy.CodedeployDeploymentGroup))!;

        [JsiiProperty(name: "alarmConfiguration", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupAlarmConfigurationOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentGroupAlarmConfigurationOutputReference AlarmConfiguration
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentGroupAlarmConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupAutoRollbackConfigurationOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentGroupAutoRollbackConfigurationOutputReference AutoRollbackConfiguration
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentGroupAutoRollbackConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "blueGreenDeploymentConfig", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference BlueGreenDeploymentConfig
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference>()!;
        }

        [JsiiProperty(name: "deploymentStyle", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupDeploymentStyleOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentGroupDeploymentStyleOutputReference DeploymentStyle
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentGroupDeploymentStyleOutputReference>()!;
        }

        [JsiiProperty(name: "ecsService", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEcsServiceOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentGroupEcsServiceOutputReference EcsService
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentGroupEcsServiceOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancerInfo", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentGroupLoadBalancerInfoOutputReference LoadBalancerInfo
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentGroupLoadBalancerInfoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alarmConfigurationInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupAlarmConfiguration\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupAlarmConfiguration? AlarmConfigurationInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupAlarmConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoRollbackConfigurationInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupAutoRollbackConfiguration\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupAutoRollbackConfiguration? AutoRollbackConfigurationInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupAutoRollbackConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AutoscalingGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blueGreenDeploymentConfigInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfig\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfig? BlueGreenDeploymentConfigInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentConfigNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentConfigNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentStyleInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupDeploymentStyle\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupDeploymentStyle? DeploymentStyleInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupDeploymentStyle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2TagFilterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEc2TagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ec2TagFilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2TagSetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEc2TagSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ec2TagSetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecsServiceInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEcsService\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupEcsService? EcsServiceInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupEcsService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerInfoInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfo\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfo? LoadBalancerInfoInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onPremisesInstanceTagFilterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupOnPremisesInstanceTagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OnPremisesInstanceTagFilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupTriggerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TriggerConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "appName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoscalingGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AutoscalingGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentConfigName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEc2TagFilter\"},\"kind\":\"array\"}}]}}")]
        public virtual object Ec2TagFilter
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ec2TagSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEc2TagSet\"},\"kind\":\"array\"}}]}}")]
        public virtual object Ec2TagSet
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onPremisesInstanceTagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupOnPremisesInstanceTagFilter\"},\"kind\":\"array\"}}]}}")]
        public virtual object OnPremisesInstanceTagFilter
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "triggerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupTriggerConfiguration\"},\"kind\":\"array\"}}]}}")]
        public virtual object TriggerConfiguration
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
