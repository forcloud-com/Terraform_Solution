using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.route53.Route53RecordAlias")]
    public class Route53RecordAlias : aws.Route53.IRoute53RecordAlias
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#evaluate_target_health Route53Record#evaluate_target_health}.</summary>
        [JsiiProperty(name: "evaluateTargetHealth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object EvaluateTargetHealth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#name Route53Record#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#zone_id Route53Record#zone_id}.</summary>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public string ZoneId
        {
            get;
            set;
        }
    }
}
