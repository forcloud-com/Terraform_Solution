using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emr.EmrInstanceGroupEbsConfig")]
    public class EmrInstanceGroupEbsConfig : aws.Emr.IEmrInstanceGroupEbsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#size EmrInstanceGroup#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public double Size
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#type EmrInstanceGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#iops EmrInstanceGroup#iops}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Iops
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_group#volumes_per_instance EmrInstanceGroup#volumes_per_instance}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumesPerInstance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VolumesPerInstance
        {
            get;
            set;
        }
    }
}
