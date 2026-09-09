---
title: Renderer package guide
---

# Renderer package guide

Install `C4.Net.Renderer` when you need standalone SVG documents for one or more workspace views.

```bash
dotnet add package C4.Net.Renderer
```

## Namespace

```csharp
using C4.Net.Renderer;
```

## Render a workspace

`SvgWorkspaceRenderer` returns a dictionary keyed by view key.

```csharp
IReadOnlyDictionary<string, string> diagrams = new SvgWorkspaceRenderer().Render(workspace);
File.WriteAllText("system-context.svg", diagrams["system-context"]);
```

This overload does not mutate `workspace`. It uses persisted element coordinates and relationship vertices when they exist, and falls back to a deterministic in-memory layout when they do not.

Container-view SVGs draw a lower-left-labeled boundary around the viewed
software system's visible containers. Component-view SVGs do the same for the
viewed container's visible components. People, software systems, and other
containers or components keep their own placement outside that scope boundary.

## Reuse layout from an earlier workspace

```csharp
IReadOnlyDictionary<string, string> diagrams = new SvgWorkspaceRenderer().Render(successor, predecessor);
SaveWorkspace(successor);
```

The two-workspace overload copies matching view geometry, element positions, connector vertices, routing, and label positions from `predecessor` into `successor` before rendering.

## Related topics

- `C4.Net.Editor` builds on this package for interactive browser editing.
- `C4.Net.Examples/SvgRenderingExample.cs` shows a complete rendering example.
