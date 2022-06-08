using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Redshift
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.redshift.RedshiftClusterLogging")]
    public class RedshiftClusterLogging : aws.Redshift.IRedshiftClusterLogging
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#enable RedshiftCluster#enable}.</summary>
        [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#bucket_name RedshiftCluster#bucket_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/redshift_cluster#s3_key_prefix RedshiftCluster#s3_key_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3KeyPrefix
        {
            get;
            set;
        }
    }
}
