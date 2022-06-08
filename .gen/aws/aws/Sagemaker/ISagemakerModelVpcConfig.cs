using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelVpcConfig), fullyQualifiedName: "aws.sagemaker.SagemakerModelVpcConfig")]
    public interface ISagemakerModelVpcConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#security_group_ids SagemakerModel#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroupIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#subnets SagemakerModel#subnets}.</summary>
        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Subnets
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelVpcConfig), fullyQualifiedName: "aws.sagemaker.SagemakerModelVpcConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerModelVpcConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#security_group_ids SagemakerModel#security_group_ids}.</summary>
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroupIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#subnets SagemakerModel#subnets}.</summary>
            [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Subnets
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
