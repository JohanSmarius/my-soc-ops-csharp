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
