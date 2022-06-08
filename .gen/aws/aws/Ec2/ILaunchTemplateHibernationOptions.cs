using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateHibernationOptions), fullyQualifiedName: "aws.ec2.LaunchTemplateHibernationOptions")]
    public interface ILaunchTemplateHibernationOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#configured LaunchTemplate#configured}.</summary>
        [JsiiProperty(name: "configured", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Configured
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateHibernationOptions), fullyQualifiedName: "aws.ec2.LaunchTemplateHibernationOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ILaunchTemplateHibernationOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/launch_template#configured LaunchTemplate#configured}.</summary>
            [JsiiProperty(name: "configured", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Configured
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
