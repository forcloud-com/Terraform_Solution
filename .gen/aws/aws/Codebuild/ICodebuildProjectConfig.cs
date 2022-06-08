using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    /// <summary>AWS CodeBuild.</summary>
    [JsiiInterface(nativeType: typeof(ICodebuildProjectConfig), fullyQualifiedName: "aws.codebuild.CodebuildProjectConfig")]
    public interface ICodebuildProjectConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>artifacts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#artifacts CodebuildProject#artifacts}
        /// </remarks>
        [JsiiProperty(name: "artifacts", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectArtifacts\"}")]
        aws.Codebuild.ICodebuildProjectArtifacts Artifacts
        {
            get;
        }

        /// <summary>environment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#environment CodebuildProject#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironment\"}")]
        aws.Codebuild.ICodebuildProjectEnvironment Environment
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#name CodebuildProject#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#service_role CodebuildProject#service_role}.</summary>
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceRole
        {
            get;
        }

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source CodebuildProject#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSource\"}")]
        aws.Codebuild.ICodebuildProjectSource Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#badge_enabled CodebuildProject#badge_enabled}.</summary>
        [JsiiProperty(name: "badgeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BadgeEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#build_timeout CodebuildProject#build_timeout}.</summary>
        [JsiiProperty(name: "buildTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BuildTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>cache block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#cache CodebuildProject#cache}
        /// </remarks>
        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectCache\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codebuild.ICodebuildProjectCache? Cache
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#description CodebuildProject#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#encryption_key CodebuildProject#encryption_key}.</summary>
        [JsiiProperty(name: "encryptionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>logs_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#logs_config CodebuildProject#logs_config}
        /// </remarks>
        [JsiiProperty(name: "logsConfig", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codebuild.ICodebuildProjectLogsConfig? LogsConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#queued_timeout CodebuildProject#queued_timeout}.</summary>
        [JsiiProperty(name: "queuedTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? QueuedTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>secondary_artifacts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#secondary_artifacts CodebuildProject#secondary_artifacts}
        /// </remarks>
        [JsiiProperty(name: "secondaryArtifacts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondaryArtifacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecondaryArtifacts
        {
            get
            {
                return null;
            }
        }

        /// <summary>secondary_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#secondary_sources CodebuildProject#secondary_sources}
        /// </remarks>
        [JsiiProperty(name: "secondarySources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondarySources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecondarySources
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source_version CodebuildProject#source_version}.</summary>
        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#tags CodebuildProject#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#vpc_config CodebuildProject#vpc_config}
        /// </remarks>
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectVpcConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codebuild.ICodebuildProjectVpcConfig? VpcConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS CodeBuild.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectConfig), fullyQualifiedName: "aws.codebuild.CodebuildProjectConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Codebuild.ICodebuildProjectConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>artifacts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#artifacts CodebuildProject#artifacts}
            /// </remarks>
            [JsiiProperty(name: "artifacts", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectArtifacts\"}")]
            public aws.Codebuild.ICodebuildProjectArtifacts Artifacts
            {
                get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectArtifacts>()!;
            }

            /// <summary>environment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#environment CodebuildProject#environment}
            /// </remarks>
            [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectEnvironment\"}")]
            public aws.Codebuild.ICodebuildProjectEnvironment Environment
            {
                get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectEnvironment>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#name CodebuildProject#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#service_role CodebuildProject#service_role}.</summary>
            [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source CodebuildProject#source}
            /// </remarks>
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSource\"}")]
            public aws.Codebuild.ICodebuildProjectSource Source
            {
                get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectSource>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#badge_enabled CodebuildProject#badge_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "badgeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? BadgeEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#build_timeout CodebuildProject#build_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "buildTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BuildTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>cache block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#cache CodebuildProject#cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectCache\"}", isOptional: true)]
            public aws.Codebuild.ICodebuildProjectCache? Cache
            {
                get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectCache?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#description CodebuildProject#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#encryption_key CodebuildProject#encryption_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>logs_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#logs_config CodebuildProject#logs_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logsConfig", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectLogsConfig\"}", isOptional: true)]
            public aws.Codebuild.ICodebuildProjectLogsConfig? LogsConfig
            {
                get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectLogsConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#queued_timeout CodebuildProject#queued_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queuedTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? QueuedTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>secondary_artifacts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#secondary_artifacts CodebuildProject#secondary_artifacts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryArtifacts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondaryArtifacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SecondaryArtifacts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>secondary_sources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#secondary_sources CodebuildProject#secondary_sources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secondarySources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildProjectSecondarySources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SecondarySources
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#source_version CodebuildProject#source_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#tags CodebuildProject#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>vpc_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_project#vpc_config CodebuildProject#vpc_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectVpcConfig\"}", isOptional: true)]
            public aws.Codebuild.ICodebuildProjectVpcConfig? VpcConfig
            {
                get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectVpcConfig?>();
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
