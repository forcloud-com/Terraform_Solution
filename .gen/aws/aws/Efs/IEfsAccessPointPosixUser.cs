using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    [JsiiInterface(nativeType: typeof(IEfsAccessPointPosixUser), fullyQualifiedName: "aws.efs.EfsAccessPointPosixUser")]
    public interface IEfsAccessPointPosixUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#gid EfsAccessPoint#gid}.</summary>
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
        double Gid
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#uid EfsAccessPoint#uid}.</summary>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
        double Uid
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#secondary_gids EfsAccessPoint#secondary_gids}.</summary>
        [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? SecondaryGids
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsAccessPointPosixUser), fullyQualifiedName: "aws.efs.EfsAccessPointPosixUser")]
        internal sealed class _Proxy : DeputyBase, aws.Efs.IEfsAccessPointPosixUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#gid EfsAccessPoint#gid}.</summary>
            [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
            public double Gid
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#uid EfsAccessPoint#uid}.</summary>
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
            public double Uid
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_access_point#secondary_gids EfsAccessPoint#secondary_gids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? SecondaryGids
            {
                get => GetInstanceProperty<double[]?>();
            }
        }
    }
}
