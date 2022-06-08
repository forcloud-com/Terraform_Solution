using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ISpotFleetRequestLaunchTemplateConfig), fullyQualifiedName: "aws.ec2.SpotFleetRequestLaunchTemplateConfig")]
    public interface ISpotFleetRequestLaunchTemplateConfig
    {
        /// <summary>launch_template_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#launch_template_specification SpotFleetRequest#launch_template_specification}
        /// </remarks>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.ec2.SpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification\"}")]
        aws.Ec2.ISpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification LaunchTemplateSpecification
        {
            get;
        }

        /// <summary>overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#overrides SpotFleetRequest#overrides}
        /// </remarks>
        [JsiiProperty(name: "overrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotFleetRequestLaunchTemplateConfigOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Overrides
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotFleetRequestLaunchTemplateConfig), fullyQualifiedName: "aws.ec2.SpotFleetRequestLaunchTemplateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ISpotFleetRequestLaunchTemplateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>launch_template_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#launch_template_specification SpotFleetRequest#launch_template_specification}
            /// </remarks>
            [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.ec2.SpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification\"}")]
            public aws.Ec2.ISpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification LaunchTemplateSpecification
            {
                get => GetInstanceProperty<aws.Ec2.ISpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification>()!;
            }

            /// <summary>overrides block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#overrides SpotFleetRequest#overrides}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotFleetRequestLaunchTemplateConfigOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Overrides
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
