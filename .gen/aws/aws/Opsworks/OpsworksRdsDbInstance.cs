using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/opsworks_rds_db_instance aws_opsworks_rds_db_instance}.</summary>
    [JsiiClass(nativeType: typeof(aws.Opsworks.OpsworksRdsDbInstance), fullyQualifiedName: "aws.opsworks.OpsworksRdsDbInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.opsworks.OpsworksRdsDbInstanceConfig\"}}]")]
    public class OpsworksRdsDbInstance : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/opsworks_rds_db_instance aws_opsworks_rds_db_instance} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OpsworksRdsDbInstance(Constructs.Construct scope, string id, aws.Opsworks.IOpsworksRdsDbInstanceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksRdsDbInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksRdsDbInstance(DeputyProps props): base(props)
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
        = GetStaticProperty<string>(typeof(aws.Opsworks.OpsworksRdsDbInstance))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbUserInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbUserInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rdsDbInstanceArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RdsDbInstanceArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stackIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StackIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dbPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbUser
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rdsDbInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RdsDbInstanceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
