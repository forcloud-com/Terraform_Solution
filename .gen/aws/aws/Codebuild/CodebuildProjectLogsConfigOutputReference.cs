using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiClass(nativeType: typeof(aws.Codebuild.CodebuildProjectLogsConfigOutputReference), fullyQualifiedName: "aws.codebuild.CodebuildProjectLogsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodebuildProjectLogsConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodebuildProjectLogsConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectLogsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectLogsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfigCloudwatchLogs\"}}]")]
        public virtual void PutCloudwatchLogs(aws.Codebuild.ICodebuildProjectLogsConfigCloudwatchLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codebuild.ICodebuildProjectLogsConfigCloudwatchLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Logs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfigS3Logs\"}}]")]
        public virtual void PutS3Logs(aws.Codebuild.ICodebuildProjectLogsConfigS3Logs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codebuild.ICodebuildProjectLogsConfigS3Logs)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLogs")]
        public virtual void ResetCloudwatchLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Logs")]
        public virtual void ResetS3Logs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfigCloudwatchLogsOutputReference\"}")]
        public virtual aws.Codebuild.CodebuildProjectLogsConfigCloudwatchLogsOutputReference CloudwatchLogs
        {
            get => GetInstanceProperty<aws.Codebuild.CodebuildProjectLogsConfigCloudwatchLogsOutputReference>()!;
        }

        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfigS3LogsOutputReference\"}")]
        public virtual aws.Codebuild.CodebuildProjectLogsConfigS3LogsOutputReference S3Logs
        {
            get => GetInstanceProperty<aws.Codebuild.CodebuildProjectLogsConfigS3LogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsInput", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfigCloudwatchLogs\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectLogsConfigCloudwatchLogs? CloudwatchLogsInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectLogsConfigCloudwatchLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3LogsInput", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfigS3Logs\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectLogsConfigS3Logs? S3LogsInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectLogsConfigS3Logs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfig\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectLogsConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectLogsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
