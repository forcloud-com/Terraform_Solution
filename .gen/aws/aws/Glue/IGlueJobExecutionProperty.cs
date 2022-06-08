using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueJobExecutionProperty), fullyQualifiedName: "aws.glue.GlueJobExecutionProperty")]
    public interface IGlueJobExecutionProperty
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#max_concurrent_runs GlueJob#max_concurrent_runs}.</summary>
        [JsiiProperty(name: "maxConcurrentRuns", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConcurrentRuns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueJobExecutionProperty), fullyQualifiedName: "aws.glue.GlueJobExecutionProperty")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueJobExecutionProperty
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_job#max_concurrent_runs GlueJob#max_concurrent_runs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrentRuns", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConcurrentRuns
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
