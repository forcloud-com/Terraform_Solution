using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    [JsiiInterface(nativeType: typeof(IEcrRepositoryImageScanningConfiguration), fullyQualifiedName: "aws.ecr.EcrRepositoryImageScanningConfiguration")]
    public interface IEcrRepositoryImageScanningConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#scan_on_push EcrRepository#scan_on_push}.</summary>
        [JsiiProperty(name: "scanOnPush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object ScanOnPush
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrRepositoryImageScanningConfiguration), fullyQualifiedName: "aws.ecr.EcrRepositoryImageScanningConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Ecr.IEcrRepositoryImageScanningConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#scan_on_push EcrRepository#scan_on_push}.</summary>
            [JsiiProperty(name: "scanOnPush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object ScanOnPush
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
