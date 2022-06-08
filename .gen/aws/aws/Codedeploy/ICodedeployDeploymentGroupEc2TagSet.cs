using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupEc2TagSet), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupEc2TagSet")]
    public interface ICodedeployDeploymentGroupEc2TagSet
    {
        /// <summary>ec2_tag_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#ec2_tag_filter CodedeployDeploymentGroup#ec2_tag_filter}
        /// </remarks>
        [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEc2TagSetEc2TagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ec2TagFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupEc2TagSet), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupEc2TagSet")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentGroupEc2TagSet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ec2_tag_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#ec2_tag_filter CodedeployDeploymentGroup#ec2_tag_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ec2TagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupEc2TagSetEc2TagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ec2TagFilter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
