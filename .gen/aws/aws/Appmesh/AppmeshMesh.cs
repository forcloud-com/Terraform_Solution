using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/appmesh_mesh aws_appmesh_mesh}.</summary>
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshMesh), fullyQualifiedName: "aws.appmesh.AppmeshMesh", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshMeshConfig\"}}]")]
    public class AppmeshMesh : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/appmesh_mesh aws_appmesh_mesh} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AppmeshMesh(Constructs.Construct scope, string id, aws.Appmesh.IAppmeshMeshConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshMesh(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshMesh(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshMeshSpec\"}}]")]
        public virtual void PutSpec(aws.Appmesh.IAppmeshMeshSpec @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshMeshSpec)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSpec")]
        public virtual void ResetSpec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(aws.Appmesh.AppmeshMesh))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastUpdatedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastUpdatedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshMeshSpecOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshMeshSpecOutputReference Spec
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshMeshSpecOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "specInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshMeshSpec\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshMeshSpec? SpecInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshMeshSpec?>();
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
