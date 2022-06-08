using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route aws_appmesh_route}.</summary>
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshRoute), fullyQualifiedName: "aws.appmesh.AppmeshRoute", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteConfig\"}}]")]
    public class AppmeshRoute : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route aws_appmesh_route} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AppmeshRoute(Constructs.Construct scope, string id, aws.Appmesh.IAppmeshRouteConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRoute(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRoute(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpec\"}}]")]
        public virtual void PutSpec(aws.Appmesh.IAppmeshRouteSpec @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpec)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Appmesh.AppmeshRoute))!;

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

        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecOutputReference Spec
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "meshNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MeshNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "specInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpec\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpec? SpecInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpec?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualRouterNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualRouterNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "meshName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MeshName
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "virtualRouterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualRouterName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
