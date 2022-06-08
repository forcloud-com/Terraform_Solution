using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateCpuOptions), fullyQualifiedName: "aws.ec2.LaunchTemplateCpuOptions")]
    public interface ILaunchTemplateCpuOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#core_count LaunchTemplate#core_count}.</summary>
        [JsiiProperty(name: "coreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CoreCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#threads_per_core LaunchTemplate#threads_per_core}.</summary>
        [JsiiProperty(name: "threadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadsPerCore
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateCpuOptions), fullyQualifiedName: "aws.ec2.LaunchTemplateCpuOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ILaunchTemplateCpuOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#core_count LaunchTemplate#core_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "coreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CoreCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#threads_per_core LaunchTemplate#threads_per_core}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadsPerCore
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
