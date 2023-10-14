using Ardalis.GuardClauses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace swagger.polymorphism.core.Json;

public sealed class DeviceSerializeSettings : JsonSerializerSettings
{
    /*
     * The 'this' keyword is used to 
     * pass an object as a parameter to other methods
     */

    public DeviceSerializeSettings()
    {
        Apply(this);
    }

    public static void Apply(JsonSerializerSettings jsonSettings)
    {
        // Null check validation
        Guard.Against.Null(jsonSettings, nameof(jsonSettings));

        jsonSettings.NullValueHandling = NullValueHandling.Ignore;
        jsonSettings.ContractResolver = new DefaultContractResolver()
        {
            NamingStrategy = new CamelCaseNamingStrategy()
        };

        jsonSettings.Converters.Add(new StringEnumConverter());

        // custom json builders
        jsonSettings.Converters.Add(DeviceRequestConverterBuilder.Build());
    }
}
