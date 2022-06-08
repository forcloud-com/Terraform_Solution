using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationOutputReference), fullyQualifiedName: "aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3BucketDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination\"}}]")]
        public virtual void PutS3BucketDestination(aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination)}, new object[]{@value});
        }

        [JsiiProperty(name: "s3BucketDestination", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestinationOutputReference\"}")]
        public virtual aws.S3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestinationOutputReference S3BucketDestination
        {
            get => GetInstanceProperty<aws.S3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestinationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BucketDestinationInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination? S3BucketDestinationInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination?>();
            set => SetInstanceProperty(value);
        }
    }
}
