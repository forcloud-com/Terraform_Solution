using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mq
{
    /// <summary>AWS Managed Message Queue.</summary>
    [JsiiByValue(fqn: "aws.mq.DataAwsMqBrokerConfig")]
    public class DataAwsMqBrokerConfig : aws.Mq.IDataAwsMqBrokerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/mq_broker#broker_id DataAwsMqBroker#broker_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "brokerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BrokerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/mq_broker#broker_name DataAwsMqBroker#broker_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BrokerName
        {
            get;
            set;
        }

        /// <summary>logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/mq_broker#logs DataAwsMqBroker#logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"aws.mq.DataAwsMqBrokerLogs\"}", isOptional: true)]
        public aws.Mq.IDataAwsMqBrokerLogs? Logs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/mq_broker#tags DataAwsMqBroker#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
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
