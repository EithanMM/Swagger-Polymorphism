using JsonSubTypes;
using Newtonsoft.Json;
using swagger.polymorphism.core.Discriminators;
using swagger.polymorphism.core.Requests;

namespace swagger.polymorphism.core.Json
{
    /*
     * This builder class configures
     * the polymorphism that is gonna be used to recognize the diferrent requests
     * based on a specific discriminator value**/
    internal static class DeviceRequestConverterBuilder
    {
        public static JsonConverter Build()
        {
            return JsonSubtypesConverterBuilder
                .Of<DeviceRequest>(DeviceDiscriminator.DiscriminatorKey)
                .RegisterSubtype<PhoneRequest>(DeviceDiscriminator.PhoneDevice)
                .RegisterSubtype<LaptopRequest>(DeviceDiscriminator.LaptopDevice)
                .SerializeDiscriminatorProperty()
                .Build();
        }
    }
}
