using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    [JsiiInterface(nativeType: typeof(IDbOptionGroupTimeouts), fullyQualifiedName: "aws.rds.DbOptionGroupTimeouts")]
    public interface IDbOptionGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#delete DbOptionGroup#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbOptionGroupTimeouts), fullyQualifiedName: "aws.rds.DbOptionGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Rds.IDbOptionGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#delete DbOptionGroup#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
