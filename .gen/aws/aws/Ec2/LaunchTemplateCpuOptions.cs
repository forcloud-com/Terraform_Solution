using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.LaunchTemplateCpuOptions")]
    public class LaunchTemplateCpuOptions : aws.Ec2.ILaunchTemplateCpuOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#core_count LaunchTemplate#core_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CoreCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#threads_per_core LaunchTemplate#threads_per_core}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadsPerCore
        {
            get;
            set;
        }
    }
}
