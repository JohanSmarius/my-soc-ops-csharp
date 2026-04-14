# Copilot Workspace Instructions

## Mandatory Development Checklist
Complete all items before handoff:

- [ ] Lint passes (`dotnet format --verify-no-changes` or repo lint task)
- [ ] Build passes (`dotnet build SocOps/SocOps.csproj`)
- [ ] Tests pass (`dotnet test` when tests exist)

## Mission
Deliver focused, reliable improvements to Soc Ops (Blazor WebAssembly).

## Run Locally
- Build: `dotnet build SocOps/SocOps.csproj`
- Run: `dotnet run --project SocOps/SocOps.csproj`
- URL: http://localhost:5166

## Project Map
- `SocOps/Components`: UI screens and bingo components
- `SocOps/Services`: game state and bingo logic
- `SocOps/Models`: domain models
- `SocOps/Data`: question source data
- `SocOps/Layout`: shell and navigation
- `SocOps/wwwroot/css/app.css`: utility CSS classes

## Working Rules
- Keep business rules in services; keep components UI-focused.
- Follow existing utility CSS patterns; avoid high-specificity selectors.
- Make the smallest safe change that fully solves the request.
- Validate changes before handoff and call out assumptions/blockers.

## Design Guide

Use this guide for any UI or styling change.

### Visual Direction
- Prefer a cohesive, intentional theme over default framework styling.
- Use a token-first approach in `SocOps/wwwroot/css/app.css` (`:root` variables for color, type, spacing, radius, shadows, and motion).
- Keep utility classes composable and low-specificity.

### Typography and Color
- Use expressive typography that matches the product mood; avoid generic default stacks unless preserving existing design.
- Maintain strong contrast for text, controls, and state indicators.
- Favor semantic class names for theme-specific UI patterns (example: card, status, CTA, board state).

### Layout and Responsiveness
- Design mobile-first, then scale up at existing breakpoints.
- Ensure no clipping, overlap, or inaccessible off-screen controls at small widths.
- Preserve current app structure and navigation behavior unless the task explicitly changes it.

### Interaction and Motion
- Keep interactions clear and tactile (hover/active/focus-visible states).
- Use subtle motion for high-value moments (screen entrance, modal reveal), not constant animation.
- Always honor reduced-motion preferences.

### Accessibility and Usability
- Keep keyboard navigation intact and visible via consistent `:focus-visible` styles.
- Do not rely on color alone to communicate state (combine text/icon/shape where practical).
- Keep touch targets comfortable on mobile.

### Scope Boundaries
- UI requests should not change game rules, scoring logic, board generation, or data model behavior unless explicitly requested.
- Prefer updating existing components and utilities before adding new files.
