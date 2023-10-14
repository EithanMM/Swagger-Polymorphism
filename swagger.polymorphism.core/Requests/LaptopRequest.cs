using swagger.polymorphism.core.Common;

namespace swagger.polymorphism.core.Requests;

public class LaptopRequest : DeviceRequest
{
    public string GraphicsCard { get; set; } = string.Empty;
    public string MotherBoard { get; set; } = string.Empty;
    public int NumberOfUsbPorts { get; set; }

    public override string GetDeviceType()
    {
        return DeviceConstants.LaptopDeviceName;
    }
}
