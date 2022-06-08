using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiInterface(nativeType: typeof(IMskClusterConfigurationInfo), fullyQualifiedName: "aws.msk.MskClusterConfigurationInfo")]
    public interface IMskClusterConfigurationInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#arn MskCluster#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#revision MskCluster#revision}.</summary>
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
        double Revision
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterConfigurationInfo), fullyQualifiedName: "aws.msk.MskClusterConfigurationInfo")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskClusterConfigurationInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#arn MskCluster#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#revision MskCluster#revision}.</summary>
            [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
            public double Revision
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
