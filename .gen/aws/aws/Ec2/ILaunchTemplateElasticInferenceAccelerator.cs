using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateElasticInferenceAccelerator), fullyQualifiedName: "aws.ec2.LaunchTemplateElasticInferenceAccelerator")]
    public interface ILaunchTemplateElasticInferenceAccelerator
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#type LaunchTemplate#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateElasticInferenceAccelerator), fullyQualifiedName: "aws.ec2.LaunchTemplateElasticInferenceAccelerator")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ILaunchTemplateElasticInferenceAccelerator
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
