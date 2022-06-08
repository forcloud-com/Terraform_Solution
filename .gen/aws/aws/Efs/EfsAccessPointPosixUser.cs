using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.efs.EfsAccessPointPosixUser")]
    public class EfsAccessPointPosixUser : aws.Efs.IEfsAccessPointPosixUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#gid EfsAccessPoint#gid}.</summary>
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
        public double Gid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#uid EfsAccessPoint#uid}.</summary>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
        public double Uid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#secondary_gids EfsAccessPoint#secondary_gids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? SecondaryGids
        {
            get;
            set;
        }
    }
}
