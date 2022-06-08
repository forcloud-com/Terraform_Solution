using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(IInstanceEphemeralBlockDevice), fullyQualifiedName: "aws.ec2.InstanceEphemeralBlockDevice")]
    public interface IInstanceEphemeralBlockDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#device_name Instance#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        string DeviceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#no_device Instance#no_device}.</summary>
        [JsiiProperty(name: "noDevice", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NoDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#virtual_name Instance#virtual_name}.</summary>
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceEphemeralBlockDevice), fullyQualifiedName: "aws.ec2.InstanceEphemeralBlockDevice")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IInstanceEphemeralBlockDevice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#device_name Instance#device_name}.</summary>
            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeviceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#no_device Instance#no_device}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "noDevice", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? NoDevice
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/instance#virtual_name Instance#virtual_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
