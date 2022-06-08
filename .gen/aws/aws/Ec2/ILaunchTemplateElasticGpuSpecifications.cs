using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateElasticGpuSpecifications), fullyQualifiedName: "aws.ec2.LaunchTemplateElasticGpuSpecifications")]
    public interface ILaunchTemplateElasticGpuSpecifications
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#type LaunchTemplate#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateElasticGpuSpecifications), fullyQualifiedName: "aws.ec2.LaunchTemplateElasticGpuSpecifications")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ILaunchTemplateElasticGpuSpecifications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#type LaunchTemplate#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
