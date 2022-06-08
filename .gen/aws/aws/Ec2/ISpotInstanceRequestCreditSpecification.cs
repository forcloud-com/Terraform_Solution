using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ISpotInstanceRequestCreditSpecification), fullyQualifiedName: "aws.ec2.SpotInstanceRequestCreditSpecification")]
    public interface ISpotInstanceRequestCreditSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#cpu_credits SpotInstanceRequest#cpu_credits}.</summary>
        [JsiiProperty(name: "cpuCredits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CpuCredits
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotInstanceRequestCreditSpecification), fullyQualifiedName: "aws.ec2.SpotInstanceRequestCreditSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ISpotInstanceRequestCreditSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#cpu_credits SpotInstanceRequest#cpu_credits}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuCredits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CpuCredits
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
