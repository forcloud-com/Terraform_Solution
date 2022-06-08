using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config aws_codedeploy_deployment_config}.</summary>
    [JsiiClass(nativeType: typeof(aws.Codedeploy.CodedeployDeploymentConfig), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigConfig\"}}]")]
    public class CodedeployDeploymentConfig : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config aws_codedeploy_deployment_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CodedeployDeploymentConfig(Constructs.Construct scope, string id, aws.Codedeploy.ICodedeployDeploymentConfigConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentConfig(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMinimumHealthyHosts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigMinimumHealthyHosts\"}}]")]
        public virtual void PutMinimumHealthyHosts(aws.Codedeploy.ICodedeployDeploymentConfigMinimumHealthyHosts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentConfigMinimumHealthyHosts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrafficRoutingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfig\"}}]")]
        public virtual void PutTrafficRoutingConfig(aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetComputePlatform")]
        public virtual void ResetComputePlatform()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumHealthyHosts")]
        public virtual void ResetMinimumHealthyHosts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrafficRoutingConfig")]
        public virtual void ResetTrafficRoutingConfig()
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
        = GetStaticProperty<string>(typeof(aws.Codedeploy.CodedeployDeploymentConfig))!;

        [JsiiProperty(name: "deploymentConfigId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentConfigId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "minimumHealthyHosts", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigMinimumHealthyHostsOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentConfigMinimumHealthyHostsOutputReference MinimumHealthyHosts
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentConfigMinimumHealthyHostsOutputReference>()!;
        }

        [JsiiProperty(name: "trafficRoutingConfig", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigOutputReference TrafficRoutingConfig
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "computePlatformInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputePlatformInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentConfigNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentConfigNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumHealthyHostsInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigMinimumHealthyHosts\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentConfigMinimumHealthyHosts? MinimumHealthyHostsInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentConfigMinimumHealthyHosts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficRoutingConfigInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfig\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfig? TrafficRoutingConfigInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfig?>();
        }

        [JsiiProperty(name: "computePlatform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputePlatform
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentConfigName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
