using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateBlockDeviceMappings), fullyQualifiedName: "aws.ec2.LaunchTemplateBlockDeviceMappings")]
    public interface ILaunchTemplateBlockDeviceMappings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#device_name LaunchTemplate#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeviceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#ebs LaunchTemplate#ebs}
        /// </remarks>
        [JsiiProperty(name: "ebs", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateBlockDeviceMappingsEbs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ILaunchTemplateBlockDeviceMappingsEbs? Ebs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#no_device LaunchTemplate#no_device}.</summary>
        [JsiiProperty(name: "noDevice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NoDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#virtual_name LaunchTemplate#virtual_name}.</summary>
        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateBlockDeviceMappings), fullyQualifiedName: "aws.ec2.LaunchTemplateBlockDeviceMappings")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ILaunchTemplateBlockDeviceMappings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#device_name LaunchTemplate#device_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeviceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ebs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#ebs LaunchTemplate#ebs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ebs", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateBlockDeviceMappingsEbs\"}", isOptional: true)]
            public aws.Ec2.ILaunchTemplateBlockDeviceMappingsEbs? Ebs
            {
                get => GetInstanceProperty<aws.Ec2.ILaunchTemplateBlockDeviceMappingsEbs?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#no_device LaunchTemplate#no_device}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "noDevice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NoDevice
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#virtual_name LaunchTemplate#virtual_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
