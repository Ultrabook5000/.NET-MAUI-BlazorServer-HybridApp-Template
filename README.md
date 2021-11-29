# .NET MAUI Blazor Server and Hybrid App - Template
## What is it?
**TLDR;** This template provides a structure for creating Blazor Server and .NET MAUI Hybrid App with a shared RCL (Razor Class Library) where you can share your pages and services.

At the end of Eilon Lipton's talk at the .NET Conf 21 ([Build cross-platform native apps with .NET MAUI and Blazor](https://www.youtube.com/watch?v=Dr8L7zXxwLI&t=1534s)) there was a question about a project template for "*WebAssembly + Server + Hybrid*" and that Microsoft is currently not sure which way to ship this template.

So I decided to create one template for Visual Studio 2022 Preview.

![Picture of app running in Web, Windows and Android.](/assets/images/Overview.png)

>Currently, this template supports only Blazor Server and **not** Blazor WASM.

## Prerequierements
1. Install [Visual Studio 2022 Preview](https://visualstudio.microsoft.com/vs/preview/) and [.NET MAUI preview](https://docs.microsoft.com/en-us/dotnet/maui/get-started/installation)
2. Install this template
    - Download the `.zip` file from the release page.
    - Copy the `.zip` to the following path `%USERPROFILE%\Documents\Visual Studio 2022\Templates\ProjectTemplates` (if you didn't changed the path).
3. Create a new project and search for `.NET MAUI Hybrid App`, you should see this template.

## Structure
![Folder structure of this template](/assets/images/Folder_Structure.png)
1. .NET MAUI Blazor App which holds all the platform specific configuration.
    - **wwwroot**
        - **css**
            - **app.css** -> Place here your .css which should only be available in the hybrid app.
    - **MauiProgram.cs** -> Here you can configure your services and configurations. There is also an extension method `AddMauiHybridServices()` which will register your shared dependencies.
2. RCL where all your shared components and services are available.
    - **Extensions**
        - **MauiHybridServices.cs** -> Register here your services which should be available in both applications.
    - **Pages**
        - 
    - **wwwroot** -> Place your .js, .css, etc.. files which should be available in both. If you add a new file, please be sure, that you add them to yout `_Layout.cshtml` files.
3. Blazor Server App 
    - **wwwroot**
        - **css**
            - **site.css** -> Place here your .css which should only be available in the Blazor Server.


## Notes
