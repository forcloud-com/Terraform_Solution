using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mq
{
    /// <summary>AWS Managed Message Queue.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsMqBrokerConfig), fullyQualifiedName: "aws.mq.DataAwsMqBrokerConfig")]
    public interface IDataAwsMqBrokerConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/mq_broker#broker_id DataAwsMqBroker#broker_id}.</summary>
        [JsiiProperty(name: "brokerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BrokerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/mq_broker#broker_name DataAwsMqBroker#broker_name}.</summary>
        [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BrokerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/mq_broker#logs DataAwsMqBroker#logs}
        /// </remarks>
        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"aws.mq.DataAwsMqBrokerLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Mq.IDataAwsMqBrokerLogs? Logs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/mq_broker#tags DataAwsMqBroker#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Managed Message Queue.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsMqBrokerConfig), fullyQualifiedName: "aws.mq.DataAwsMqBrokerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Mq.IDataAwsMqBrokerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/mq_broker#broker_id DataAwsMqBroker#broker_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "brokerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BrokerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/mq_broker#broker_name DataAwsMqBroker#broker_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BrokerName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/mq_broker#logs DataAwsMqBroker#logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"aws.mq.DataAwsMqBrokerLogs\"}", isOptional: true)]
            public aws.Mq.IDataAwsMqBrokerLogs? Logs
            {
                get => GetInstanceProperty<aws.Mq.IDataAwsMqBrokerLogs?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/mq_broker#tags DataAwsMqBroker#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
