using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOriginCustomOriginConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOriginCustomOriginConfig")]
    public interface ICloudfrontDistributionOriginCustomOriginConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#http_port CloudfrontDistribution#http_port}.</summary>
        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}")]
        double HttpPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#https_port CloudfrontDistribution#https_port}.</summary>
        [JsiiProperty(name: "httpsPort", typeJson: "{\"primitive\":\"number\"}")]
        double HttpsPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_protocol_policy CloudfrontDistribution#origin_protocol_policy}.</summary>
        [JsiiProperty(name: "originProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string OriginProtocolPolicy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_ssl_protocols CloudfrontDistribution#origin_ssl_protocols}.</summary>
        [JsiiProperty(name: "originSslProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] OriginSslProtocols
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_keepalive_timeout CloudfrontDistribution#origin_keepalive_timeout}.</summary>
        [JsiiProperty(name: "originKeepaliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OriginKeepaliveTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_read_timeout CloudfrontDistribution#origin_read_timeout}.</summary>
        [JsiiProperty(name: "originReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OriginReadTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOriginCustomOriginConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOriginCustomOriginConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontDistributionOriginCustomOriginConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#http_port CloudfrontDistribution#http_port}.</summary>
            [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}")]
            public double HttpPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#https_port CloudfrontDistribution#https_port}.</summary>
            [JsiiProperty(name: "httpsPort", typeJson: "{\"primitive\":\"number\"}")]
            public double HttpsPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_protocol_policy CloudfrontDistribution#origin_protocol_policy}.</summary>
            [JsiiProperty(name: "originProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string OriginProtocolPolicy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_ssl_protocols CloudfrontDistribution#origin_ssl_protocols}.</summary>
            [JsiiProperty(name: "originSslProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] OriginSslProtocols
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_keepalive_timeout CloudfrontDistribution#origin_keepalive_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originKeepaliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OriginKeepaliveTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_read_timeout CloudfrontDistribution#origin_read_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OriginReadTimeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
