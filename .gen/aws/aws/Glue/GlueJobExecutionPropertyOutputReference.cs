using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiClass(nativeType: typeof(aws.Glue.GlueJobExecutionPropertyOutputReference), fullyQualifiedName: "aws.glue.GlueJobExecutionPropertyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueJobExecutionPropertyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueJobExecutionPropertyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueJobExecutionPropertyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueJobExecutionPropertyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxConcurrentRuns")]
        public virtual void ResetMaxConcurrentRuns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentRunsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxConcurrentRunsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxConcurrentRuns", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConcurrentRuns
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glue.GlueJobExecutionProperty\"}", isOptional: true)]
        public virtual aws.Glue.IGlueJobExecutionProperty? InternalValue
        {
            get => GetInstanceProperty<aws.Glue.IGlueJobExecutionProperty?>();
            set => SetInstanceProperty(value);
        }
    }
}
