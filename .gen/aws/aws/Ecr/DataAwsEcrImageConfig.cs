using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    #pragma warning disable CS8618

    /// <summary>AWS EC2 Container Registry.</summary>
    [JsiiByValue(fqn: "aws.ecr.DataAwsEcrImageConfig")]
    public class DataAwsEcrImageConfig : aws.Ecr.IDataAwsEcrImageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecr_image#repository_name DataAwsEcrImage#repository_name}.</summary>
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        public string RepositoryName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecr_image#image_digest DataAwsEcrImage#image_digest}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageDigest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecr_image#image_tag DataAwsEcrImage#image_tag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageTag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecr_image#registry_id DataAwsEcrImage#registry_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistryId
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
