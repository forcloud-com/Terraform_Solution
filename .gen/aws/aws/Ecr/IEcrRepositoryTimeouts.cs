using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    [JsiiInterface(nativeType: typeof(IEcrRepositoryTimeouts), fullyQualifiedName: "aws.ecr.EcrRepositoryTimeouts")]
    public interface IEcrRepositoryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#delete EcrRepository#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrRepositoryTimeouts), fullyQualifiedName: "aws.ecr.EcrRepositoryTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Ecr.IEcrRepositoryTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#delete EcrRepository#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
