using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    [JsiiByValue(fqn: "aws.datasync.DatasyncTaskTimeouts")]
    public class DatasyncTaskTimeouts : aws.Datasync.IDatasyncTaskTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_task#create DatasyncTask#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
