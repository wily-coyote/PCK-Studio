# pckstudio-mod

...is a fork of the original [PCK Studio](https://github.com/PhoenixARC/-PCK-Studio).

## Features
- QOL fixes (context menus, help menus, renaming in LOC editor)
- Rewritten model editor with OpenTK renderer
- Raw property import/export to TSV
- Redesigned UI without Metro Framework
- Removed Discord RPC

## To build
Open the solution file in Visual Studio, or run MSBuild.

If building with MSBuild, run a NuGet restore first.

You need to have built at least once for the WinForms designer to work.
