---
title: NuGet package map
---

# NuGet packages for developers

This documentation set is organised around the published NuGet packages.

## Package overview

| Package | Depends on | Use it for | Guide |
|---|---|---|---|
| `C4.Net.Core` | - | Creating workspaces, models, views, and styles in code | [Core package guide](getting-started.md) |
| `C4.Net.Client` | `C4.Net.Core` | Reading and writing workspaces through the Structurizr-compatible API | [Client package guide](api-client.md) |
| `C4.Net.Renderer` | `C4.Net.Core` | Rendering workspace views to standalone SVG documents | [Renderer package guide](svg-rendering.md) |
| `C4.Net.Editor` | `C4.Net.Renderer` | Embedding an interactive Blazor editor for workspace layouts | [Editor package guide](razor-svg-editor.md) |

## Install packages

```bash
dotnet add package C4.Net.Core
dotnet add package C4.Net.Client
dotnet add package C4.Net.Renderer
dotnet add package C4.Net.Editor
```

Install only the packages you need:

- Start with `Core` when your application creates or transforms workspaces.
- Add `Client` when you need to download or publish workspaces.
- Add `Renderer` when you need SVG output in a console app, service, or pipeline.
- Add `Editor` when a Blazor host needs interactive layout editing in the browser.

## Common package combinations

- `Core` only: model a workspace and hand it to another process.
- `Core` + `Client`: build a workspace in code and publish it.
- `Core` + `Renderer`: generate SVG artifacts locally.
- `Core` + `Renderer` + `Editor`: render and edit layouts inside a Blazor app.
- `Core` + `Client` + `Renderer`: generate diagrams locally and publish the same workspace remotely.

## Source locations

- Core: `C4.Net.Core/`
- Client: `C4.Net.Client/`
- Renderer: `C4.Net.Renderer/`
- Editor: `C4.Net.Editor/`
