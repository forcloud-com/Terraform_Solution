using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudwatch
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_resource_policy aws_cloudwatch_log_resource_policy}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cloudwatch.CloudwatchLogResourcePolicy), fullyQualifiedName: "aws.cloudwatch.CloudwatchLogResourcePolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudwatch.CloudwatchLogResourcePolicyConfig\"}}]")]
    public class CloudwatchLogResourcePolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_resource_policy aws_cloudwatch_log_resource_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudwatchLogResourcePolicy(Constructs.Construct scope, string id, aws.Cloudwatch.ICloudwatchLogResourcePolicyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchLogResourcePolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchLogResourcePolicy(DeputyProps props): base(props)
        {
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
        = GetStaticProperty<string>(typeof(aws.Cloudwatch.CloudwatchLogResourcePolicy))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyDocumentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyDocumentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "policyDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyDocument
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
