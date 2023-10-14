using swagger.polymorphism.core.Enums;

namespace swagger.polymorphism.core.Discriminators;
public static class DeviceDiscriminator
{
    /*
     * 'DiscriminatorKey' is the attribute that is going to be isnerted when Swagger initialize
     * to determine what type of schema is being passed
     * **/
    public const string DiscriminatorKey = "DeviceType";

    public const string PhoneDevice = nameof(ElectronicDeviceType.Smarthphone);
    public const string LaptopDevice = nameof(ElectronicDeviceType.Laptop);
}
