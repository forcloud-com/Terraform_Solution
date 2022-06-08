using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glacier
{
    [JsiiInterface(nativeType: typeof(IGlacierVaultNotification), fullyQualifiedName: "aws.glacier.GlacierVaultNotification")]
    public interface IGlacierVaultNotification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glacier_vault#events GlacierVault#events}.</summary>
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Events
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glacier_vault#sns_topic GlacierVault#sns_topic}.</summary>
        [JsiiProperty(name: "snsTopic", typeJson: "{\"primitive\":\"string\"}")]
        string SnsTopic
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlacierVaultNotification), fullyQualifiedName: "aws.glacier.GlacierVaultNotification")]
        internal sealed class _Proxy : DeputyBase, aws.Glacier.IGlacierVaultNotification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glacier_vault#events GlacierVault#events}.</summary>
            [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Events
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glacier_vault#sns_topic GlacierVault#sns_topic}.</summary>
            [JsiiProperty(name: "snsTopic", typeJson: "{\"primitive\":\"string\"}")]
            public string SnsTopic
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
