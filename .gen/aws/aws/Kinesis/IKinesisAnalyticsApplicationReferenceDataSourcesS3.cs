using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesS3), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesS3")]
    public interface IKinesisAnalyticsApplicationReferenceDataSourcesS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#bucket_arn KinesisAnalyticsApplication#bucket_arn}.</summary>
        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
        string BucketArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#file_key KinesisAnalyticsApplication#file_key}.</summary>
        [JsiiProperty(name: "fileKey", typeJson: "{\"primitive\":\"string\"}")]
        string FileKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#role_arn KinesisAnalyticsApplication#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesS3), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesS3")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#bucket_arn KinesisAnalyticsApplication#bucket_arn}.</summary>
            [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#file_key KinesisAnalyticsApplication#file_key}.</summary>
            [JsiiProperty(name: "fileKey", typeJson: "{\"primitive\":\"string\"}")]
            public string FileKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#role_arn KinesisAnalyticsApplication#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
