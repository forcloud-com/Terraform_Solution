using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.rds.RdsClusterS3Import")]
    public class RdsClusterS3Import : aws.Rds.IRdsClusterS3Import
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#bucket_name RdsCluster#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#ingestion_role RdsCluster#ingestion_role}.</summary>
        [JsiiProperty(name: "ingestionRole", typeJson: "{\"primitive\":\"string\"}")]
        public string IngestionRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#source_engine RdsCluster#source_engine}.</summary>
        [JsiiProperty(name: "sourceEngine", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceEngine
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#source_engine_version RdsCluster#source_engine_version}.</summary>
        [JsiiProperty(name: "sourceEngineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceEngineVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster#bucket_prefix RdsCluster#bucket_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketPrefix
        {
            get;
            set;
        }
    }
}
