using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Gamelift
{
    [JsiiInterface(nativeType: typeof(IGameliftAliasRoutingStrategy), fullyQualifiedName: "aws.gamelift.GameliftAliasRoutingStrategy")]
    public interface IGameliftAliasRoutingStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_alias#type GameliftAlias#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_alias#fleet_id GameliftAlias#fleet_id}.</summary>
        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FleetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_alias#message GameliftAlias#message}.</summary>
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Message
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGameliftAliasRoutingStrategy), fullyQualifiedName: "aws.gamelift.GameliftAliasRoutingStrategy")]
        internal sealed class _Proxy : DeputyBase, aws.Gamelift.IGameliftAliasRoutingStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_alias#type GameliftAlias#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_alias#fleet_id GameliftAlias#fleet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FleetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_alias#message GameliftAlias#message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Message
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
