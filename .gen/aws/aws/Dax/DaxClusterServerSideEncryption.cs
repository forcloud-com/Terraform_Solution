using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dax
{
    [JsiiByValue(fqn: "aws.dax.DaxClusterServerSideEncryption")]
    public class DaxClusterServerSideEncryption : aws.Dax.IDaxClusterServerSideEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dax_cluster#enabled DaxCluster#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get;
            set;
        }
    }
}
