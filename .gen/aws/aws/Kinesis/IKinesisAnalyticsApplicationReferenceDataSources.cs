using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSources), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSources")]
    public interface IKinesisAnalyticsApplicationReferenceDataSources
    {
        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#s3 KinesisAnalyticsApplication#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesS3\"}")]
        aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesS3 S3
        {
            get;
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#schema KinesisAnalyticsApplication#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchema\"}")]
        aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchema Schema
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#table_name KinesisAnalyticsApplication#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        string TableName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSources), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSources")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#s3 KinesisAnalyticsApplication#s3}
            /// </remarks>
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesS3\"}")]
            public aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesS3 S3
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesS3>()!;
            }

            /// <summary>schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#schema KinesisAnalyticsApplication#schema}
            /// </remarks>
            [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchema\"}")]
            public aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchema Schema
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchema>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#table_name KinesisAnalyticsApplication#table_name}.</summary>
            [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
            public string TableName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
