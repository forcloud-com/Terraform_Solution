using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclDefaultActionOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclDefaultActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclDefaultActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclDefaultActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclDefaultActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclDefaultActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionAllow\"}}]")]
        public virtual void PutAllow(aws.Wafv2.IWafv2WebAclDefaultActionAllow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclDefaultActionAllow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionBlock\"}}]")]
        public virtual void PutBlock(aws.Wafv2.IWafv2WebAclDefaultActionBlock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclDefaultActionBlock)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllow")]
        public virtual void ResetAllow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlock")]
        public virtual void ResetBlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionAllowOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclDefaultActionAllowOutputReference Allow
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclDefaultActionAllowOutputReference>()!;
        }

        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionBlockOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclDefaultActionBlockOutputReference Block
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclDefaultActionBlockOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionAllow\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclDefaultActionAllow? AllowInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclDefaultActionAllow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionBlock\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclDefaultActionBlock? BlockInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclDefaultActionBlock?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultAction\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclDefaultAction? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclDefaultAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
