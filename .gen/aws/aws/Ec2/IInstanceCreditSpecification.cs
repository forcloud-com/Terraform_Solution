using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(IInstanceCreditSpecification), fullyQualifiedName: "aws.ec2.InstanceCreditSpecification")]
    public interface IInstanceCreditSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#cpu_credits Instance#cpu_credits}.</summary>
        [JsiiProperty(name: "cpuCredits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CpuCredits
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceCreditSpecification), fullyQualifiedName: "aws.ec2.InstanceCreditSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IInstanceCreditSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#cpu_credits Instance#cpu_credits}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuCredits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CpuCredits
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
