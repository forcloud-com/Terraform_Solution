using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    [JsiiInterface(nativeType: typeof(IDmsEndpointElasticsearchSettings), fullyQualifiedName: "aws.dms.DmsEndpointElasticsearchSettings")]
    public interface IDmsEndpointElasticsearchSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#endpoint_uri DmsEndpoint#endpoint_uri}.</summary>
        [JsiiProperty(name: "endpointUri", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointUri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#service_access_role_arn DmsEndpoint#service_access_role_arn}.</summary>
        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceAccessRoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#error_retry_duration DmsEndpoint#error_retry_duration}.</summary>
        [JsiiProperty(name: "errorRetryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ErrorRetryDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#full_load_error_percentage DmsEndpoint#full_load_error_percentage}.</summary>
        [JsiiProperty(name: "fullLoadErrorPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FullLoadErrorPercentage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDmsEndpointElasticsearchSettings), fullyQualifiedName: "aws.dms.DmsEndpointElasticsearchSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Dms.IDmsEndpointElasticsearchSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#endpoint_uri DmsEndpoint#endpoint_uri}.</summary>
            [JsiiProperty(name: "endpointUri", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#service_access_role_arn DmsEndpoint#service_access_role_arn}.</summary>
            [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceAccessRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#error_retry_duration DmsEndpoint#error_retry_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "errorRetryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ErrorRetryDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#full_load_error_percentage DmsEndpoint#full_load_error_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fullLoadErrorPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FullLoadErrorPercentage
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
