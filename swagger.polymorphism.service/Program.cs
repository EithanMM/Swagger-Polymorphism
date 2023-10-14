using swagger.polymorphism.core.Json;
using swagger.polymorphism.data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var services = builder.Services;
services.AddControllers(options =>
{
    // option to suppress automatic [Required] property in fields
    options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true;
}).AddNewtonsoftJson(options =>
{
    // Json Serializarion Configuration
    options.AllowInputFormatterExceptionMessages = false;
    DeviceSerializeSettings.Apply(options.SerializerSettings);
});

// Services
services.AddSingleton<IDummyService, DummyService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen(options =>
{
    #region First approach to enable discriminator
    options.EnableAnnotations(enableAnnotationsForInheritance: true, enableAnnotationsForPolymorphism: true);
    #endregion

    #region Second approach to enable discriminator
    //options.SelectDiscriminatorNameUsing(type =>
    //{
    //    return type.Name switch
    //    {
    //        nameof(DeviceRequest) => DeviceDiscriminator.DiscriminatorKey,
    //        _ => null
    //    };
    //});
    #endregion

    // Enable swagger Polymorphism
    options.UseOneOfForPolymorphism();
});
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
