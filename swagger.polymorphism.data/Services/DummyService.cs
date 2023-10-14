using swagger.polymorphism.core.Models;
using swagger.polymorphism.core.Requests;

namespace swagger.polymorphism.data.Services;

public class DummyService : IDummyService
{
    private List<DeviceRequest> deviceList;

    public DummyService()
    {
        if (deviceList == null)
            deviceList = new();
    }
    public Device GenerateDeviceDummy(DeviceRequest request)
    {
        var device = new Device();

        if (request is PhoneRequest)
            device.Message = $"A {request.GetDeviceType()} device has been created";

        if (request is LaptopRequest)
            device.Message = $"A {request.GetDeviceType()} device has been created";

        deviceList.Add(request);

        return device;
    }

    public IEnumerable<DeviceRequest> GetDevices()
    {
        return deviceList;
    }
}
