---
title: API Reference
---

# C4.Net API Reference

This section contains the full public API reference for all C4.Net packages,
generated from XML documentation comments in the source code.

## Browse the reference

- [Full API index (Table of Contents)](toc.html)
- [C4.Net.Workspace](C4.Net.Workspace.html) — top-level entry point
- [C4.Net.Model](C4.Net.Model.html) — the C4 model root
- [C4.Net.Api.StructurizrClient](C4.Net.Api.StructurizrClient.html) — publish and fetch workspaces
- [C4.Net.Renderer.SvgWorkspaceRenderer](C4.Net.Renderer.SvgWorkspaceRenderer.html) — SVG rendering

## Packages covered

| Package | Entry namespace |
|---------|----------------|
| C4.Net.Core | `C4.Net` |
| C4.Net.Client | `C4.Net.Api` |
| C4.Net.Renderer | `C4.Net.Renderer` |
| C4.Net.Editor | `C4.Net.Editor` |

## How this reference is generated

After each NuGet release, regenerate this API reference manually:

```bash
scripts/regenerate-release-api-docs.sh <package-version>
```

That command restores tools, rebuilds the solution for DocFX, regenerates `docs/api/`, and writes the versioned release notes page. Override `DOCFX_TARGET_FRAMEWORK` if you need a target other than the default `net10.0`.

To regenerate step by step:

```bash
dotnet tool restore
dotnet build C4.Net.slnx -c Release -p:TargetFramework=net10.0
dotnet docfx metadata docfx.json
dotnet docfx build docfx.json
```

See [CONTRIBUTING.md](https://github.com/StacyClouds/C4.Net/blob/main/CONTRIBUTING.md#xml-documentation-and-api-reference) for full instructions.

## XML documentation standards

All public API members carry XML documentation comments following this style:

- `<summary>` — what the type or member does
- `<param>` — description of each parameter
- `<returns>` — what is returned (non-void methods)
- `<exception>` — exceptions that may be thrown
- `<remarks>` — additional detail for non-obvious behaviour
- `<example>` — usage example for key entry-point classes

> **Note:** Internal members also carry `<summary>` comments for IntelliSense and AI-tooling
> benefit, but they are excluded from this published reference.
