using swagger.polymorphism.core.Common;

namespace swagger.polymorphism.core.Requests;

public class PhoneRequest : DeviceRequest
{
    public string SimNumber { get; set; } = string.Empty;
    public bool isSmartPhone { get; set; }

    public override string GetDeviceType()
    {
        return DeviceConstants.PhoneDeviceName;
    }
}
