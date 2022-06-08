using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2.LaunchTemplateHibernationOptions")]
    public class LaunchTemplateHibernationOptions : aws.Ec2.ILaunchTemplateHibernationOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#configured LaunchTemplate#configured}.</summary>
        [JsiiProperty(name: "configured", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Configured
        {
            get;
            set;
        }
    }
}
