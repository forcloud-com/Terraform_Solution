using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.LaunchTemplateCpuOptionsOutputReference), fullyQualifiedName: "aws.ec2.LaunchTemplateCpuOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LaunchTemplateCpuOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LaunchTemplateCpuOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplateCpuOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplateCpuOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCoreCount")]
        public virtual void ResetCoreCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreadsPerCore")]
        public virtual void ResetThreadsPerCore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "coreCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CoreCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threadsPerCoreInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThreadsPerCoreInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "coreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CoreCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threadsPerCore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThreadsPerCore
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2.LaunchTemplateCpuOptions\"}", isOptional: true)]
        public virtual aws.Ec2.ILaunchTemplateCpuOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2.ILaunchTemplateCpuOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
