using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudformation
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/cloudformation_stack aws_cloudformation_stack}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cloudformation.DataAwsCloudformationStack), fullyQualifiedName: "aws.cloudformation.DataAwsCloudformationStack", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudformation.DataAwsCloudformationStackConfig\"}}]")]
    public class DataAwsCloudformationStack : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/cloudformation_stack aws_cloudformation_stack} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsCloudformationStack(Constructs.Construct scope, string id, aws.Cloudformation.IDataAwsCloudformationStackConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudformationStack(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudformationStack(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "outputs", returnsJson: "{\"type\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"cdktf.IResolvable\"}]}}}", parametersJson: "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual object Outputs(string key)
        {
            return InvokeInstanceMethod<object>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }

        [JsiiMethod(name: "parameters", returnsJson: "{\"type\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"cdktf.IResolvable\"}]}}}", parametersJson: "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual object Parameters(string key)
        {
            return InvokeInstanceMethod<object>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(aws.Cloudformation.DataAwsCloudformationStack))!;

        [JsiiProperty(name: "capabilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Capabilities
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disableRollback", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DisableRollback
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamRoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NotificationArns
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "templateBody", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TemplateBody
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeoutInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutInMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
