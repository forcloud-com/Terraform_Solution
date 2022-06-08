using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directoryservice
{
    #pragma warning disable CS8618

    /// <summary>AWS Directory Service.</summary>
    [JsiiByValue(fqn: "aws.directoryservice.DirectoryServiceDirectoryConfig")]
    public class DirectoryServiceDirectoryConfig : aws.Directoryservice.IDirectoryServiceDirectoryConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#name DirectoryServiceDirectory#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#password DirectoryServiceDirectory#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#alias DirectoryServiceDirectory#alias}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }

        /// <summary>connect_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#connect_settings DirectoryServiceDirectory#connect_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectSettings", typeJson: "{\"fqn\":\"aws.directoryservice.DirectoryServiceDirectoryConnectSettings\"}", isOptional: true)]
        public aws.Directoryservice.IDirectoryServiceDirectoryConnectSettings? ConnectSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#description DirectoryServiceDirectory#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#edition DirectoryServiceDirectory#edition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "edition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Edition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#enable_sso DirectoryServiceDirectory#enable_sso}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableSso", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableSso
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#short_name DirectoryServiceDirectory#short_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShortName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#size DirectoryServiceDirectory#size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Size
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#tags DirectoryServiceDirectory#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#type DirectoryServiceDirectory#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>vpc_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/directory_service_directory#vpc_settings DirectoryServiceDirectory#vpc_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcSettings", typeJson: "{\"fqn\":\"aws.directoryservice.DirectoryServiceDirectoryVpcSettings\"}", isOptional: true)]
        public aws.Directoryservice.IDirectoryServiceDirectoryVpcSettings? VpcSettings
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
