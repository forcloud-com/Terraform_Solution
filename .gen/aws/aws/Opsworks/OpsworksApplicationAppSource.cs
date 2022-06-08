using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opsworks.OpsworksApplicationAppSource")]
    public class OpsworksApplicationAppSource : aws.Opsworks.IOpsworksApplicationAppSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#type OpsworksApplication#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#password OpsworksApplication#password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#revision OpsworksApplication#revision}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Revision
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#ssh_key OpsworksApplication#ssh_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sshKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SshKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#url OpsworksApplication#url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Url
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#username OpsworksApplication#username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}
