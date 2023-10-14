# Swagger Polymorphism

Swagger polymorphism is a feature in the Swagger framework that allows for the definition and handling of polymorphic data models in API specifications. Polymorphism refers to the ability of an object to take on different forms or types. In the context of Swagger, this means that a single endpoint can accept or return multiple types of objects.

With Swagger polymorphism, you can define a base model and then define multiple sub-models that inherit from the base model. Each sub-model can have its own unique properties and characteristics. This enables you to handle different variations or versions of an object within a single API specification.


### Schema example
```json
{
  "DeviceType": "Laptop",
  "serialNumber": "XCCDLF",
  "brand": "Dell",
  "screenSize": "15",
  "graphicsCard": "Nvidia",
  "motherBoard": "Asus Rock",
  "numberOfUsbPorts": "4"
}
```

```json
{
  "DeviceType": "Smarthphone",
	"serialNumber": "SLDKOI98",
  "brand": "Samsung",
  "screenSize": 5,
  "simNumber": "3094959",
  "isSmartPhone": true
}
```

## NuGet Packages used
- Ardalis.GuardClauses
- JsonSubTypes
- Microsoft.AspNetCore.Mvc.Newtonsoft
- Newtonsoft.Json
- Swashbucle.AspNetCore
- Swashbucle.AspNetCore.Annotations