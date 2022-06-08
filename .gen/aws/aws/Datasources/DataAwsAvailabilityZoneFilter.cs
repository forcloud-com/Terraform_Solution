using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasources
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datasources.DataAwsAvailabilityZoneFilter")]
    public class DataAwsAvailabilityZoneFilter : aws.Datasources.IDataAwsAvailabilityZoneFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/availability_zone#name DataAwsAvailabilityZone#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/availability_zone#values DataAwsAvailabilityZone#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
