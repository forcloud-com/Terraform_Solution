using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2.LaunchTemplateLicenseSpecification")]
    public class LaunchTemplateLicenseSpecification : aws.Ec2.ILaunchTemplateLicenseSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#license_configuration_arn LaunchTemplate#license_configuration_arn}.</summary>
        [JsiiProperty(name: "licenseConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LicenseConfigurationArn
        {
            get;
            set;
        }
    }
}
