using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directoryservice
{
    /// <summary>AWS Directory Service.</summary>
    [JsiiInterface(nativeType: typeof(IDirectoryServiceDirectoryConfig), fullyQualifiedName: "aws.directoryservice.DirectoryServiceDirectoryConfig")]
    public interface IDirectoryServiceDirectoryConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#name DirectoryServiceDirectory#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#password DirectoryServiceDirectory#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#alias DirectoryServiceDirectory#alias}.</summary>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>connect_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#connect_settings DirectoryServiceDirectory#connect_settings}
        /// </remarks>
        [JsiiProperty(name: "connectSettings", typeJson: "{\"fqn\":\"aws.directoryservice.DirectoryServiceDirectoryConnectSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Directoryservice.IDirectoryServiceDirectoryConnectSettings? ConnectSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#description DirectoryServiceDirectory#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#edition DirectoryServiceDirectory#edition}.</summary>
        [JsiiProperty(name: "edition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Edition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#enable_sso DirectoryServiceDirectory#enable_sso}.</summary>
        [JsiiProperty(name: "enableSso", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableSso
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#short_name DirectoryServiceDirectory#short_name}.</summary>
        [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShortName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#size DirectoryServiceDirectory#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Size
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#tags DirectoryServiceDirectory#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#type DirectoryServiceDirectory#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#vpc_settings DirectoryServiceDirectory#vpc_settings}
        /// </remarks>
        [JsiiProperty(name: "vpcSettings", typeJson: "{\"fqn\":\"aws.directoryservice.DirectoryServiceDirectoryVpcSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Directoryservice.IDirectoryServiceDirectoryVpcSettings? VpcSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Directory Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDirectoryServiceDirectoryConfig), fullyQualifiedName: "aws.directoryservice.DirectoryServiceDirectoryConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Directoryservice.IDirectoryServiceDirectoryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#name DirectoryServiceDirectory#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#password DirectoryServiceDirectory#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#alias DirectoryServiceDirectory#alias}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>connect_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#connect_settings DirectoryServiceDirectory#connect_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectSettings", typeJson: "{\"fqn\":\"aws.directoryservice.DirectoryServiceDirectoryConnectSettings\"}", isOptional: true)]
            public aws.Directoryservice.IDirectoryServiceDirectoryConnectSettings? ConnectSettings
            {
                get => GetInstanceProperty<aws.Directoryservice.IDirectoryServiceDirectoryConnectSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#description DirectoryServiceDirectory#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#edition DirectoryServiceDirectory#edition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "edition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Edition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#enable_sso DirectoryServiceDirectory#enable_sso}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableSso", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableSso
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#short_name DirectoryServiceDirectory#short_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShortName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#size DirectoryServiceDirectory#size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Size
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#tags DirectoryServiceDirectory#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#type DirectoryServiceDirectory#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>vpc_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#vpc_settings DirectoryServiceDirectory#vpc_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcSettings", typeJson: "{\"fqn\":\"aws.directoryservice.DirectoryServiceDirectoryVpcSettings\"}", isOptional: true)]
            public aws.Directoryservice.IDirectoryServiceDirectoryVpcSettings? VpcSettings
            {
                get => GetInstanceProperty<aws.Directoryservice.IDirectoryServiceDirectoryVpcSettings?>();
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
