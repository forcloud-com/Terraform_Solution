using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecs.EcsClusterDefaultCapacityProviderStrategy")]
    public class EcsClusterDefaultCapacityProviderStrategy : aws.Ecs.IEcsClusterDefaultCapacityProviderStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_cluster#capacity_provider EcsCluster#capacity_provider}.</summary>
        [JsiiProperty(name: "capacityProvider", typeJson: "{\"primitive\":\"string\"}")]
        public string CapacityProvider
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_cluster#base EcsCluster#base}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "base", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Base
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_cluster#weight EcsCluster#weight}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Weight
        {
            get;
            set;
        }
    }
}
