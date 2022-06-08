using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ssm_resource_data_sync aws_ssm_resource_data_sync}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ssm.SsmResourceDataSync), fullyQualifiedName: "aws.ssm.SsmResourceDataSync", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ssm.SsmResourceDataSyncConfig\"}}]")]
    public class SsmResourceDataSync : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ssm_resource_data_sync aws_ssm_resource_data_sync} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SsmResourceDataSync(Constructs.Construct scope, string id, aws.Ssm.ISsmResourceDataSyncConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmResourceDataSync(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmResourceDataSync(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3Destination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssm.SsmResourceDataSyncS3Destination\"}}]")]
        public virtual void PutS3Destination(aws.Ssm.ISsmResourceDataSyncS3Destination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ssm.ISsmResourceDataSyncS3Destination)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Ssm.SsmResourceDataSync))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.ssm.SsmResourceDataSyncS3DestinationOutputReference\"}")]
        public virtual aws.Ssm.SsmResourceDataSyncS3DestinationOutputReference S3Destination
        {
            get => GetInstanceProperty<aws.Ssm.SsmResourceDataSyncS3DestinationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3DestinationInput", typeJson: "{\"fqn\":\"aws.ssm.SsmResourceDataSyncS3Destination\"}", isOptional: true)]
        public virtual aws.Ssm.ISsmResourceDataSyncS3Destination? S3DestinationInput
        {
            get => GetInstanceProperty<aws.Ssm.ISsmResourceDataSyncS3Destination?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
