
# OdooRpc.CoreCLR.Client.V8.Models

## All Models for Simple Odoo JSON-RPC Client .NET 8

[Report Bug](https://github.com/akifmt/OdooRpc.CoreCLR.Client.V8.Models/issues) || [Request Feature](https://github.com/akifmt/OdooRpc.CoreCLR.Client.V8.Models/issues)

![version](https://img.shields.io/github/v/release/akifmt/OdooRpc.CoreCLR.Client.V8.Models?color=blue)
![Downloads](https://img.shields.io/github/downloads/akifmt/OdooRpc.CoreCLR.Client.V8.Models/total) ![Contributors](https://img.shields.io/github/contributors/akifmt/OdooRpc.CoreCLR.Client.V8.Models?color=dark-green) ![Issues](https://img.shields.io/github/issues/akifmt/OdooRpc.CoreCLR.Client.V8.Models) [![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)]()


## About The Project

OdooRpc.CoreCLR.Client.V8.Models
* All Models for Simple Odoo JSON-RPC Client .NET 8
* This repository contains all default models and fields for Odoo Version 17 (Released November, 2023)
* Easily extend and utilize these models in your projects
* All Models: [https://github.com/akifmt/OdooRpc.CoreCLR.Client.V8.Models/blob/main/Models.md](https://github.com/akifmt/OdooRpc.CoreCLR.Client.V8.Models/blob/main/Models.md)


## Installation

### Install
  - Check provided options from NuGet:
  - [https://www.nuget.org/packages/OdooRpc.CoreCLR.Client.V8.Models](https://www.nuget.org/packages/OdooRpc.CoreCLR.Client.V8.Models) 


## Usage
We will create a custom model that extends the existing ProductProduct class, allowing us to interact with Odoo's product data more effectively. We will also include the necessary NuGet packages, a detailed explanation of the code, and how to make requests using the custom model.  
Steps:  
1. Adding Required Libraries
2. Creating a Child Class
3. Making Requests with the Custom Model

#### 1. Adding Required Libraries
You need to add the following packages to your .csproj file:
```
<ItemGroup>
    <PackageReference Include="OdooRpc.CoreCLR.Client.V8" Version="8.0.4" />
    <PackageReference Include="OdooRpc.CoreCLR.Client.V8.Models" Version="8.0.4" />
</ItemGroup>
```

#### 2. Creating a Child Class
The custom class ProductProductCustom extends the ProductProduct class. Here’s a breakdown of its components:
```
using OdooRpc.CoreCLR.Client.V8.Models;
using OdooRpc.CoreCLR.Client.V8.Models.Items;
using System.Text.Json.Serialization;

namespace ConsoleApp1Test.Specs.Models;

public class ProductProductCustom : ProductProduct
{

    [JsonIgnore]
    public Many2OneItem create_u => new Many2OneItem(this.create_uid);

    [JsonIgnore]
    public Many2OneItem write_u => new Many2OneItem(this.write_uid);

    [JsonIgnore]
    public Many2OneItem categ => new Many2OneItem(this.categ_id);

}
```

#### 3. Making Requests with the Custom Model
The following code, demonstrates how to make an asynchronous request to fetch products using the custom model:
```
// Fetch products using the custom model
public async Task<ProductProductCustom[]> FetchProductsAsync()
{
    OdooConnectionInfo odooConnectionInfo = new OdooConnectionInfo { Database = "YOUR_DB_NAME", Host = "YOUR_HOST", Port = 443, IsSSL = true, Username = "YOUR_USERNAME", Password = "YOUR_PASSWORD" };
    OdooRpcClient client = new OdooRpcClient(odooConnectionInfo);

    ProductProductCustom[] products = await client.Get<ProductProductCustom[]>(
              new OdooSearchParameters(ModelNames.ProductProduct, new OdooDomainFilter()));
    return products;
}
```


## Release Notes

* No extra library dependencies


## Contributing

Any contributions you make are **greatly appreciated**.
* If you have suggestions for adding or removing projects, feel free to [open an issue](https://github.com/akifmt/OdooRpc.CoreCLR.Client.V8.Models/issues/new) to discuss it.
* Please make sure you check your spelling and grammar.
* Create individual PR for each suggestion.


## License

Distributed under the MIT License. See `LICENSE` for more information.


## Contact

Project Link: [https://github.com/akifmt/OdooRpc.CoreCLR.Client.V8.Models](https://github.com/akifmt/OdooRpc.CoreCLR.Client.V8.Models)


## Acknowledgments

* ![Dotnet](https://img.shields.io/badge/-.NET%208.0-blueviolet?logo=dotnet)

