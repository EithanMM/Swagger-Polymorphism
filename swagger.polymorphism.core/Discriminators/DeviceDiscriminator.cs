using swagger.polymorphism.core.Enums;

namespace swagger.polymorphism.core.Discriminators;
public static class DeviceDiscriminator
{
    public const string DiscriminatorKey = "DeviceType";

    public const string PhoneDevice = nameof(ElectronicDeviceType.Smarthphone);
    public const string LaptopDevice = nameof(ElectronicDeviceType.Laptop);
}
