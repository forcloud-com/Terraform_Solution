using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudwatch
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_metric_filter aws_cloudwatch_log_metric_filter}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cloudwatch.CloudwatchLogMetricFilter), fullyQualifiedName: "aws.cloudwatch.CloudwatchLogMetricFilter", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudwatch.CloudwatchLogMetricFilterConfig\"}}]")]
    public class CloudwatchLogMetricFilter : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_metric_filter aws_cloudwatch_log_metric_filter} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudwatchLogMetricFilter(Constructs.Construct scope, string id, aws.Cloudwatch.ICloudwatchLogMetricFilterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchLogMetricFilter(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchLogMetricFilter(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMetricTransformation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatch.CloudwatchLogMetricFilterMetricTransformation\"}}]")]
        public virtual void PutMetricTransformation(aws.Cloudwatch.ICloudwatchLogMetricFilterMetricTransformation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudwatch.ICloudwatchLogMetricFilterMetricTransformation)}, new object[]{@value});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Cloudwatch.CloudwatchLogMetricFilter))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metricTransformation", typeJson: "{\"fqn\":\"aws.cloudwatch.CloudwatchLogMetricFilterMetricTransformationOutputReference\"}")]
        public virtual aws.Cloudwatch.CloudwatchLogMetricFilterMetricTransformationOutputReference MetricTransformation
        {
            get => GetInstanceProperty<aws.Cloudwatch.CloudwatchLogMetricFilterMetricTransformationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "logGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricTransformationInput", typeJson: "{\"fqn\":\"aws.cloudwatch.CloudwatchLogMetricFilterMetricTransformation\"}", isOptional: true)]
        public virtual aws.Cloudwatch.ICloudwatchLogMetricFilterMetricTransformation? MetricTransformationInput
        {
            get => GetInstanceProperty<aws.Cloudwatch.ICloudwatchLogMetricFilterMetricTransformation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patternInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PatternInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Pattern
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
