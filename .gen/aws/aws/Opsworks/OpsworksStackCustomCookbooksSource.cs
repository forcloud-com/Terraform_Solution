using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opsworks.OpsworksStackCustomCookbooksSource")]
    public class OpsworksStackCustomCookbooksSource : aws.Opsworks.IOpsworksStackCustomCookbooksSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#type OpsworksStack#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#url OpsworksStack#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#password OpsworksStack#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#revision OpsworksStack#revision}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Revision
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#ssh_key OpsworksStack#ssh_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sshKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SshKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#username OpsworksStack#username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}
