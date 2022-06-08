using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiByValue(fqn: "aws.emr.EmrClusterStep")]
    public class EmrClusterStep : aws.Emr.IEmrClusterStep
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#action_on_failure EmrCluster#action_on_failure}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionOnFailure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActionOnFailure
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#hadoop_jar_step EmrCluster#hadoop_jar_step}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hadoopJarStep", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterStepHadoopJarStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HadoopJarStep
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#name EmrCluster#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
