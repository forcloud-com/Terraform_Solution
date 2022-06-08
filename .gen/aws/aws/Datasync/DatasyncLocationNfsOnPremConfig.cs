using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datasync.DatasyncLocationNfsOnPremConfig")]
    public class DatasyncLocationNfsOnPremConfig : aws.Datasync.IDatasyncLocationNfsOnPremConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_nfs#agent_arns DatasyncLocationNfs#agent_arns}.</summary>
        [JsiiProperty(name: "agentArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AgentArns
        {
            get;
            set;
        }
    }
}
