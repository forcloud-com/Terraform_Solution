using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.efs.EfsAccessPointRootDirectoryCreationInfo")]
    public class EfsAccessPointRootDirectoryCreationInfo : aws.Efs.IEfsAccessPointRootDirectoryCreationInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#owner_gid EfsAccessPoint#owner_gid}.</summary>
        [JsiiProperty(name: "ownerGid", typeJson: "{\"primitive\":\"number\"}")]
        public double OwnerGid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#owner_uid EfsAccessPoint#owner_uid}.</summary>
        [JsiiProperty(name: "ownerUid", typeJson: "{\"primitive\":\"number\"}")]
        public double OwnerUid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#permissions EfsAccessPoint#permissions}.</summary>
        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
        public string Permissions
        {
            get;
            set;
        }
    }
}
