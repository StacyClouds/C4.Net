---
title: Editor package guide
---

# Editor package guide

Install `C4.Net.Editor` to embed interactive workspace layout editing in a Blazor application.

```bash
dotnet add package C4.Net.Editor
```

`C4.Net.Editor` depends on the renderer package and expects a `Workspace` instance from the core package.

## Namespace

```razor
@using C4.Net.Editor
```

## Add static assets

Reference the packaged stylesheet and script from the host page.

```html
<link rel="stylesheet" href="_content/C4.Net.Editor/c4sharp-editor.css" />
<script src="_content/C4.Net.Editor/c4sharp-editor.js"></script>
```

## Enable an interactive render mode

The editor components use Blazor interop for dragging elements and editing connector vertices, so the host page must render them with an interactive Blazor render mode.

## Use `WorkspaceEditor`

`WorkspaceEditor` renders a thumbnail navigator plus the selected interactive view.

```razor
<WorkspaceEditor Workspace="workspace"
                 InitialViewKey="system-context"
                 @bind-SelectedViewKey="selectedViewKey"
                 LayoutChanged="OnLayoutChanged"
                 SaveRequested="SaveWorkspace" />
```

## Use `ViewEditor`

Use `ViewEditor` when the host already controls navigation and only needs a single editable view surface.

## Persistence responsibilities

Dragging updates `ElementView.X` and `ElementView.Y`. Connector edits update the underlying `RelationshipView`. `LayoutChanged` reports in-memory changes immediately, and `SaveRequested` lets the host decide how to persist the updated workspace.

See `C4.Net.Renderer.Web/Components/Pages/Editor.razor` for a complete host example.
