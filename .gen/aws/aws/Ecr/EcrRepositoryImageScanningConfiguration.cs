using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecr.EcrRepositoryImageScanningConfiguration")]
    public class EcrRepositoryImageScanningConfiguration : aws.Ecr.IEcrRepositoryImageScanningConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#scan_on_push EcrRepository#scan_on_push}.</summary>
        [JsiiProperty(name: "scanOnPush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object ScanOnPush
        {
            get;
            set;
        }
    }
}
