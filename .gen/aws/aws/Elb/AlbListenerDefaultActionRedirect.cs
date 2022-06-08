using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.AlbListenerDefaultActionRedirect")]
    public class AlbListenerDefaultActionRedirect : aws.Elb.IAlbListenerDefaultActionRedirect
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#status_code AlbListener#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}")]
        public string StatusCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#host AlbListener#host}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Host
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#path AlbListener#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#port AlbListener#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#protocol AlbListener#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#query AlbListener#query}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Query
        {
            get;
            set;
        }
    }
}
