using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codecommit
{
    /// <summary>AWS CodeCommit.</summary>
    [JsiiInterface(nativeType: typeof(ICodecommitTriggerConfig), fullyQualifiedName: "aws.codecommit.CodecommitTriggerConfig")]
    public interface ICodecommitTriggerConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codecommit_trigger#repository_name CodecommitTrigger#repository_name}.</summary>
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryName
        {
            get;
        }

        /// <summary>trigger block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codecommit_trigger#trigger CodecommitTrigger#trigger}
        /// </remarks>
        [JsiiProperty(name: "trigger", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codecommit.CodecommitTriggerTrigger\"},\"kind\":\"array\"}}]}}")]
        object Trigger
        {
            get;
        }

        /// <summary>AWS CodeCommit.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICodecommitTriggerConfig), fullyQualifiedName: "aws.codecommit.CodecommitTriggerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Codecommit.ICodecommitTriggerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codecommit_trigger#repository_name CodecommitTrigger#repository_name}.</summary>
            [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>trigger block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codecommit_trigger#trigger CodecommitTrigger#trigger}
            /// </remarks>
            [JsiiProperty(name: "trigger", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codecommit.CodecommitTriggerTrigger\"},\"kind\":\"array\"}}]}}")]
            public object Trigger
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
