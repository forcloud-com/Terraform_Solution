using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Worklink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.worklink.WorklinkFleetIdentityProvider")]
    public class WorklinkFleetIdentityProvider : aws.Worklink.IWorklinkFleetIdentityProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#saml_metadata WorklinkFleet#saml_metadata}.</summary>
        [JsiiProperty(name: "samlMetadata", typeJson: "{\"primitive\":\"string\"}")]
        public string SamlMetadata
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#type WorklinkFleet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
