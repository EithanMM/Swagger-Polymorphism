using swagger.polymorphism.core.Discriminators;
using Swashbuckle.AspNetCore.Annotations;

namespace swagger.polymorphism.core.Requests;

[SwaggerDiscriminator(DeviceDiscriminator.DiscriminatorKey)]
[SwaggerSubType(typeof(PhoneRequest), DiscriminatorValue = DeviceDiscriminator.PhoneDevice)]
[SwaggerSubType(typeof(LaptopRequest), DiscriminatorValue = DeviceDiscriminator.LaptopDevice)]
public abstract class DeviceRequest
{
    public string SerialNumber { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public int ScreenSize { get; set; }

    public abstract string GetDeviceType();
}
