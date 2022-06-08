using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiByValue(fqn: "aws.emr.EmrClusterStepHadoopJarStep")]
    public class EmrClusterStepHadoopJarStep : aws.Emr.IEmrClusterStepHadoopJarStep
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#args EmrCluster#args}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Args
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#jar EmrCluster#jar}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jar", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Jar
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#main_class EmrCluster#main_class}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mainClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MainClass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#properties EmrCluster#properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Properties
        {
            get;
            set;
        }
    }
}
