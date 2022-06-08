using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(ILbSubnetMapping), fullyQualifiedName: "aws.elb.LbSubnetMapping")]
    public interface ILbSubnetMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb#subnet_id Lb#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb#allocation_id Lb#allocation_id}.</summary>
        [JsiiProperty(name: "allocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllocationId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbSubnetMapping), fullyQualifiedName: "aws.elb.LbSubnetMapping")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.ILbSubnetMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb#subnet_id Lb#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb#allocation_id Lb#allocation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllocationId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
