using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportOutputReference), fullyQualifiedName: "aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination\"}}]")]
        public virtual void PutDestination(aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOutputSchemaVersion")]
        public virtual void ResetOutputSchemaVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationOutputReference\"}")]
        public virtual aws.S3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationOutputReference Destination
        {
            get => GetInstanceProperty<aws.S3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestinationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination? DestinationInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExportDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputSchemaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputSchemaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "outputSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport?>();
            set => SetInstanceProperty(value);
        }
    }
}
