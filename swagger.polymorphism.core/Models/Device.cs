using Swashbuckle.AspNetCore.Annotations;

namespace swagger.polymorphism.core.Models;

public class Device
{

    public Device()
    {
        this.Id = Guid.NewGuid().ToString();
        this.CreationDateTime = DateTime.Now;
    }

    [SwaggerSchema(ReadOnly = true)]
    public string Id { get; set; } = null!;

    [SwaggerSchema(ReadOnly = true)]
    public DateTime CreationDateTime { get; set; }

    [SwaggerSchema(ReadOnly = true)]
    public string Message { get; set; } = null!;
}
