using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateLicenseSpecification), fullyQualifiedName: "aws.ec2.LaunchTemplateLicenseSpecification")]
    public interface ILaunchTemplateLicenseSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#license_configuration_arn LaunchTemplate#license_configuration_arn}.</summary>
        [JsiiProperty(name: "licenseConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        string LicenseConfigurationArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateLicenseSpecification), fullyQualifiedName: "aws.ec2.LaunchTemplateLicenseSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ILaunchTemplateLicenseSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#license_configuration_arn LaunchTemplate#license_configuration_arn}.</summary>
            [JsiiProperty(name: "licenseConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LicenseConfigurationArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
