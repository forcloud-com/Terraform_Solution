using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    #pragma warning disable CS8618

    /// <summary>AWS OpsWorks.</summary>
    [JsiiByValue(fqn: "aws.opsworks.OpsworksUserProfileConfig")]
    public class OpsworksUserProfileConfig : aws.Opsworks.IOpsworksUserProfileConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_user_profile#ssh_username OpsworksUserProfile#ssh_username}.</summary>
        [JsiiProperty(name: "sshUsername", typeJson: "{\"primitive\":\"string\"}")]
        public string SshUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_user_profile#user_arn OpsworksUserProfile#user_arn}.</summary>
        [JsiiProperty(name: "userArn", typeJson: "{\"primitive\":\"string\"}")]
        public string UserArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_user_profile#allow_self_management OpsworksUserProfile#allow_self_management}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowSelfManagement", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowSelfManagement
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_user_profile#ssh_public_key OpsworksUserProfile#ssh_public_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sshPublicKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SshPublicKey
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
