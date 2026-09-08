# C4.Net

C4.Net is a multi-targeted .NET library for building architecture workspaces in code, publishing them to Structurizr-compatible services, rendering diagrams to SVG, and adding interactive editing to Blazor applications.

For C4 model background and notation guidance, use the official [C4 Model website](https://c4model.com).

## Package overview

| Package | Purpose | Start here when you need to... |
|---|---|---|
| `C4.Net.Core` | Workspace, model, view, and styling APIs | Define people, software systems, containers, components, and views in .NET code |
| `C4.Net.Client` | Structurizr-compatible API client | Read or publish workspaces, preserve layout, and use optional client-side encryption |
| `C4.Net.Renderer` | SVG renderer | Generate standalone SVG diagrams from workspace views |
| `C4.Net.Editor` | Interactive Blazor editor components | Embed a browser-based layout editor for rendered workspace views |

## Installation

```bash
dotnet add package C4.Net.Core
dotnet add package C4.Net.Client
dotnet add package C4.Net.Renderer
dotnet add package C4.Net.Editor
```

Install only the packages your application needs. `Core` is the foundation package. `Client` and `Renderer` build on `Core`, and `Editor` builds on `Renderer`.

## Quick example

```csharp
using C4.Net;

Workspace workspace = new Workspace("Getting Started", "A simple architecture workspace.");
Model model = workspace.Model;

Person user = model.AddPerson("User", "Uses the system.");
SoftwareSystem softwareSystem = model.AddSoftwareSystem("Software System", "Provides the core capability.");
user.Uses(softwareSystem, "Uses");

SystemContextView view = workspace.Views.CreateSystemContextView(
    softwareSystem,
    "system-context",
    "A simple system context view.");
view.AddAllPeople();
view.AddAllSoftwareSystems();

Styles styles = workspace.Views.Configuration.Styles;
styles.Add(new ElementStyle(Tags.SoftwareSystem) { Background = "#1168bd", Color = "#ffffff" });
styles.Add(new ElementStyle(Tags.Person) { Background = "#08427b", Color = "#ffffff", Shape = Shape.Person });
```

## Documentation

- [Package map](docs/nuget.md)
- [Core package guide](docs/getting-started.md)
- [Client package guide](docs/api-client.md)
- [Renderer package guide](docs/svg-rendering.md)
- [Editor package guide](docs/razor-svg-editor.md)
- [Client-side encryption](docs/client-side-encryption.md)

## Table of contents

- [NuGet packages for developers](docs/nuget.md)
- [Using `C4.Net.Core`](docs/getting-started.md)
- [Using `C4.Net.Client`](docs/api-client.md)
- [Using `C4.Net.Renderer`](docs/svg-rendering.md)
- [Using `C4.Net.Editor`](docs/razor-svg-editor.md)
- [Using client-side encryption](docs/client-side-encryption.md)
- [C4 Model reference](https://c4model.com)
