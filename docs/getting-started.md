---
title: Core package guide
---

# Core package guide

Install `C4.Net.Core` when you want to create or modify workspaces in .NET code.

```bash
dotnet add package C4.Net.Core
```

## Namespace

```csharp
using C4.Net;
```

## Create a workspace

A workspace contains the model, views, and related configuration.

```csharp
Workspace workspace = new Workspace("Getting Started", "A simple architecture workspace.");
Model model = workspace.Model;
```

## Add model elements

Add people, software systems, containers, and components through the model graph.

```csharp
Person user = model.AddPerson("User", "Uses the system.");
SoftwareSystem softwareSystem = model.AddSoftwareSystem("Software System", "Provides the core capability.");
user.Uses(softwareSystem, "Uses");
```

## Create views

Create a view from the workspace view set, then add the elements you want to render.

```csharp
SystemContextView view = workspace.Views.CreateSystemContextView(
    softwareSystem,
    "system-context",
    "A simple system context view.");
view.AddAllPeople();
view.AddAllSoftwareSystems();
```

## Apply styles

Styles live under `workspace.Views.Configuration.Styles`.

```csharp
Styles styles = workspace.Views.Configuration.Styles;
styles.Add(new ElementStyle(Tags.SoftwareSystem) { Background = "#1168bd", Color = "#ffffff" });
styles.Add(new ElementStyle(Tags.Person) { Background = "#08427b", Color = "#ffffff", Shape = Shape.Person });
```

## Next steps

- Add `C4.Net.Client` to publish or download workspaces.
- Add `C4.Net.Renderer` to generate SVG output locally.
- Add `C4.Net.Editor` to edit rendered layouts in a Blazor host.

For C4 notation guidance, use the official [C4 Model website](https://c4model.com).
