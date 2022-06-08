using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Outposts
{
    /// <summary>AWS Outposts.</summary>
    [JsiiByValue(fqn: "aws.outposts.DataAwsOutpostsOutpostsConfig")]
    public class DataAwsOutpostsOutpostsConfig : aws.Outposts.IDataAwsOutpostsOutpostsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/outposts_outposts#availability_zone DataAwsOutpostsOutposts#availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/outposts_outposts#availability_zone_id DataAwsOutpostsOutposts#availability_zone_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZoneId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/outposts_outposts#site_id DataAwsOutpostsOutposts#site_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "siteId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SiteId
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
