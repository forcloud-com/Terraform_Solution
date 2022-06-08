using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datasync.DatasyncLocationS3S3Config")]
    public class DatasyncLocationS3S3Config : aws.Datasync.IDatasyncLocationS3S3Config
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_s3#bucket_access_role_arn DatasyncLocationS3#bucket_access_role_arn}.</summary>
        [JsiiProperty(name: "bucketAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketAccessRoleArn
        {
            get;
            set;
        }
    }
}
