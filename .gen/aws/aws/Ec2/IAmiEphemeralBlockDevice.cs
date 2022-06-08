using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(IAmiEphemeralBlockDevice), fullyQualifiedName: "aws.ec2.AmiEphemeralBlockDevice")]
    public interface IAmiEphemeralBlockDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#device_name Ami#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        string DeviceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#virtual_name Ami#virtual_name}.</summary>
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAmiEphemeralBlockDevice), fullyQualifiedName: "aws.ec2.AmiEphemeralBlockDevice")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IAmiEphemeralBlockDevice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#device_name Ami#device_name}.</summary>
            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeviceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ami#virtual_name Ami#virtual_name}.</summary>
            [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
