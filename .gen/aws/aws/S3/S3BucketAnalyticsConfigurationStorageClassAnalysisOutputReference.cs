using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketAnalyticsConfigurationStorageClassAnalysisOutputReference), fullyQualifiedName: "aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketAnalyticsConfigurationStorageClassAnalysisOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketAnalyticsConfigurationStorageClassAnalysisOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketAnalyticsConfigurationStorageClassAnalysisOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketAnalyticsConfigurationStorageClassAnalysisOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataExport", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport\"}}]")]
        public virtual void PutDataExport(aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport)}, new object[]{@value});
        }

        [JsiiProperty(name: "dataExport", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportOutputReference\"}")]
        public virtual aws.S3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportOutputReference DataExport
        {
            get => GetInstanceProperty<aws.S3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExportOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataExportInput", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysisDataExport\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport? DataExportInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysisDataExport?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysis\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysis? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysis?>();
            set => SetInstanceProperty(value);
        }
    }
}
