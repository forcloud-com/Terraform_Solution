using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiClass(nativeType: typeof(aws.Glue.GlueClassifierXmlClassifierOutputReference), fullyQualifiedName: "aws.glue.GlueClassifierXmlClassifierOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueClassifierXmlClassifierOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueClassifierXmlClassifierOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueClassifierXmlClassifierOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueClassifierXmlClassifierOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "classificationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClassificationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rowTagInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RowTagInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Classification
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rowTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RowTag
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glue.GlueClassifierXmlClassifier\"}", isOptional: true)]
        public virtual aws.Glue.IGlueClassifierXmlClassifier? InternalValue
        {
            get => GetInstanceProperty<aws.Glue.IGlueClassifierXmlClassifier?>();
            set => SetInstanceProperty(value);
        }
    }
}
