using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.msk.MskClusterConfigurationInfo")]
    public class MskClusterConfigurationInfo : aws.Msk.IMskClusterConfigurationInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#arn MskCluster#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public string Arn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#revision MskCluster#revision}.</summary>
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
        public double Revision
        {
            get;
            set;
        }
    }
}
