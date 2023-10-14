using swagger.polymorphism.core.Models;
using swagger.polymorphism.core.Requests;

namespace swagger.polymorphism.data.Services;

public interface IDummyService
{
    public Device GenerateDeviceDummy(DeviceRequest request);

    public IEnumerable<DeviceRequest> GetDevices();
}
