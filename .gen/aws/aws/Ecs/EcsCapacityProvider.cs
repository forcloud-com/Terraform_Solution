using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider aws_ecs_capacity_provider}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ecs.EcsCapacityProvider), fullyQualifiedName: "aws.ecs.EcsCapacityProvider", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ecs.EcsCapacityProviderConfig\"}}]")]
    public class EcsCapacityProvider : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ecs_capacity_provider aws_ecs_capacity_provider} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EcsCapacityProvider(Constructs.Construct scope, string id, aws.Ecs.IEcsCapacityProviderConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsCapacityProvider(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsCapacityProvider(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutoScalingGroupProvider", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsCapacityProviderAutoScalingGroupProvider\"}}]")]
        public virtual void PutAutoScalingGroupProvider(aws.Ecs.IEcsCapacityProviderAutoScalingGroupProvider @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsCapacityProviderAutoScalingGroupProvider)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Ecs.EcsCapacityProvider))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoScalingGroupProvider", typeJson: "{\"fqn\":\"aws.ecs.EcsCapacityProviderAutoScalingGroupProviderOutputReference\"}")]
        public virtual aws.Ecs.EcsCapacityProviderAutoScalingGroupProviderOutputReference AutoScalingGroupProvider
        {
            get => GetInstanceProperty<aws.Ecs.EcsCapacityProviderAutoScalingGroupProviderOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScalingGroupProviderInput", typeJson: "{\"fqn\":\"aws.ecs.EcsCapacityProviderAutoScalingGroupProvider\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsCapacityProviderAutoScalingGroupProvider? AutoScalingGroupProviderInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsCapacityProviderAutoScalingGroupProvider?>();
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
