using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Worklink
{
    [JsiiInterface(nativeType: typeof(IWorklinkFleetIdentityProvider), fullyQualifiedName: "aws.worklink.WorklinkFleetIdentityProvider")]
    public interface IWorklinkFleetIdentityProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#saml_metadata WorklinkFleet#saml_metadata}.</summary>
        [JsiiProperty(name: "samlMetadata", typeJson: "{\"primitive\":\"string\"}")]
        string SamlMetadata
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#type WorklinkFleet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorklinkFleetIdentityProvider), fullyQualifiedName: "aws.worklink.WorklinkFleetIdentityProvider")]
        internal sealed class _Proxy : DeputyBase, aws.Worklink.IWorklinkFleetIdentityProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#saml_metadata WorklinkFleet#saml_metadata}.</summary>
            [JsiiProperty(name: "samlMetadata", typeJson: "{\"primitive\":\"string\"}")]
            public string SamlMetadata
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#type WorklinkFleet#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
