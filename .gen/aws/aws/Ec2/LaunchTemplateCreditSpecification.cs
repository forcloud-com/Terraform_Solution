using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.LaunchTemplateCreditSpecification")]
    public class LaunchTemplateCreditSpecification : aws.Ec2.ILaunchTemplateCreditSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#cpu_credits LaunchTemplate#cpu_credits}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuCredits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CpuCredits
        {
            get;
            set;
        }
    }
}
