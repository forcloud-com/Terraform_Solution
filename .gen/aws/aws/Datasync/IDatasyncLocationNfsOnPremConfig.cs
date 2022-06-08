using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationNfsOnPremConfig), fullyQualifiedName: "aws.datasync.DatasyncLocationNfsOnPremConfig")]
    public interface IDatasyncLocationNfsOnPremConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_nfs#agent_arns DatasyncLocationNfs#agent_arns}.</summary>
        [JsiiProperty(name: "agentArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AgentArns
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationNfsOnPremConfig), fullyQualifiedName: "aws.datasync.DatasyncLocationNfsOnPremConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Datasync.IDatasyncLocationNfsOnPremConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_nfs#agent_arns DatasyncLocationNfs#agent_arns}.</summary>
            [JsiiProperty(name: "agentArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AgentArns
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
