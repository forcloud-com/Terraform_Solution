using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(IEc2FleetOnDemandOptions), fullyQualifiedName: "aws.ec2.Ec2FleetOnDemandOptions")]
    public interface IEc2FleetOnDemandOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#allocation_strategy Ec2Fleet#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllocationStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetOnDemandOptions), fullyQualifiedName: "aws.ec2.Ec2FleetOnDemandOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IEc2FleetOnDemandOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#allocation_strategy Ec2Fleet#allocation_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllocationStrategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
