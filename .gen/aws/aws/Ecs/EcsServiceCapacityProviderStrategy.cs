using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecs.EcsServiceCapacityProviderStrategy")]
    public class EcsServiceCapacityProviderStrategy : aws.Ecs.IEcsServiceCapacityProviderStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#capacity_provider EcsService#capacity_provider}.</summary>
        [JsiiProperty(name: "capacityProvider", typeJson: "{\"primitive\":\"string\"}")]
        public string CapacityProvider
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#base EcsService#base}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "base", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Base
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_service#weight EcsService#weight}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Weight
        {
            get;
            set;
        }
    }
}
