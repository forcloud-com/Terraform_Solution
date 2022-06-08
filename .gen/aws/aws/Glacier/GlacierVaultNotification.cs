using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glacier
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glacier.GlacierVaultNotification")]
    public class GlacierVaultNotification : aws.Glacier.IGlacierVaultNotification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glacier_vault#events GlacierVault#events}.</summary>
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Events
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glacier_vault#sns_topic GlacierVault#sns_topic}.</summary>
        [JsiiProperty(name: "snsTopic", typeJson: "{\"primitive\":\"string\"}")]
        public string SnsTopic
        {
            get;
            set;
        }
    }
}
