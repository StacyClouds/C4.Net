---
name: editor
description: Guide editor-oriented scenarios with C4.Net.Editor.
license: MIT
compatibility: C4.Net repository context.
metadata:
  author: StacyClouds
  version: "1.0"
---

Use this skill for editor and interactive authoring scenarios.

## Install

```bash
dotnet add package C4.Net.Editor
```

## Scope

- Workspace editing workflows
- Integration with renderer/core pipelines
- Validation of editable diagram-as-code experiences

## Prerequisites

- `C4.Net.Core` for workspace/model composition.
- Optional `C4.Net.Renderer` for SVG previews.
- Optional `C4.Net.Client` for publish/sync workflows.

## Guidance flow

1. Clarify the editing scenario (local tool, web app, hybrid).
2. Establish how Core models are created and persisted.
3. Connect editing outputs to rendering and/or publishing flows.
4. Verify round-trip behavior (edit, save, render, publish).

## Usage checklist

- Define how workspaces are loaded and saved.
- Define how edits are validated before persistence.
- If preview is required, verify editor output renders through Renderer.
- If publish is required, verify hand-off to Client.

## API correctness protocol

- Verify editor API surface against package source/tests before proposing concrete code.
- Prefer flows aligned with `docs/razor-svg-editor.md` when interactive editing guidance is needed.
- If a component or integration method is uncertain, inspect implementation first and provide a verified path.

## Authoritative references

- `docs/razor-svg-editor.md`
- `C4.Net.Editor/`
- `C4.Net.Editor.Tests/`

## Expected output

- Integration plan for editor-centric applications
- Recommended package combination
- Validation checklist for interactive workflows (with verified API assumptions)
