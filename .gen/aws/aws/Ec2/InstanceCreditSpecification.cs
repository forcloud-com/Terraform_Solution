using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.InstanceCreditSpecification")]
    public class InstanceCreditSpecification : aws.Ec2.IInstanceCreditSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#cpu_credits Instance#cpu_credits}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuCredits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CpuCredits
        {
            get;
            set;
        }
    }
}
