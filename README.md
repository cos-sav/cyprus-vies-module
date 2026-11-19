# Cyprus VIES Declaration – source recovered from v1.7.1

This solution was rebuilt by decompiling the shipped v1.7.1 binaries with ILSpy 8.2
(`Cyprus VIES.exe` 1.7.1.0, `xSageDataObjects.dll` and `xSADReports.dll` 2.0.0.125).
The 2015–2017 source package was older than this build (Sage up to 2018, .NET 4.0),
so it was used only for the manuals and the installer project.

## Layout

| Path | Contents |
| --- | --- |
| `src/xSADMain` | Main WinForms app (`Cyprus VIES.exe`), C# |
| `src/xSageDataObjects` | Sage ODBC/SDO access layer. Originally VB.NET, decompiled to C# |
| `src/xSADReports` | DevExpress reports and preview. Originally VB.NET, decompiled to C# |
| `lib/` | Third-party DLLs taken from the v1.7.1 build (DevExpress 10.1, SQL CE 3.5, EnvDTE, stdole) |
| `docs/` | User manual, licence agreement, online submission manual (from the old source) |
| `deployment/` | Old MSI setup project (`xSADSetup.vdproj`) and SQL CE 3.5 SP2 runtime installers |
| `tools/clean-database.sql` | Script to empty the bundled `.sdf` before shipping |

## Building

- Visual Studio 2022 (or `dotnet build -c Release`) on Windows. Target: .NET Framework 4.8, x86.
- The reference-assemblies NuGet package lets it build without the 4.8 targeting pack.
- Output: `src/xSADMain/bin/Release/net48/`.
- Running it needs Sage 50 (with its ODBC driver and Sage Data Objects registered) and the
  SQL Server Compact 3.5 SP2 runtime (`deployment/Additional SQL Server CE SP2 files`).

The solution builds with 0 errors. Every type and resource in the original assemblies is present
in the rebuilt ones. It has **not** been run against Sage yet; that needs a Windows machine with Sage 50.

## Changes from the decompiled output

- VB `WithEvents` members came out as `private virtual` properties, which C# rejects. They are now
  `private` (same behaviour). The unused `_adapter` WithEvents wrappers in the TableAdapters became plain fields.
- Removed the unused `ArtemisConnectionString` setting from xSADReports (code and `app.config`).
  It held an `sa` SQL Server password, compiled into every shipped copy of `xSADReports.dll`.
- Re-embedded three empty `.resources` files that ILSpy skipped, so the resource names match the original.

## Known limitations

- Forms have `InitializeComponent` inline in one file (no `.Designer.cs` split). They compile and run,
  but the Visual Studio designer may need the DevExpress 10.1 design-time licence to open some of them.
- Local variable names and comments are lost. Generated TableAdapter code contains `goto` statements from VB.
- `deployment/xSADSetup/xSADSetup.vdproj` still points at the old project paths and needs updating
  (or replacing with WiX/Inno Setup) before an MSI can be built.
- The bundled `src/xSADMain/Database/xSAD-VIESv1.sdf` still holds developer data until
  `tools/clean-database.sql` is run on Windows.

## Fixes since decompiling (see also CHANGELOG.md)

- **Startup crash "Could not extract … sage version from path"** (2026-10-28). When the Sage data folder
  could not be found, `SageController.SelectAllSageCompanies` threw inside the main window's constructor,
  so the app closed before Settings > Path Configuration could be opened. Now:
  - the Sage version is read from the data folder's name (`2009`–`2026` → SDO v15–v32, `V33` style → that version),
    which also fixes 2009–2011 never matching and covers future `Vnn` folders up to v33;
  - auto-detect scans every `C:\ProgramData\Sage\Accounts\<version>` folder and picks the newest one that
    has a `COMPANY` file, instead of the first folder that merely exists;
  - if nothing is found, the main window opens with an empty list and tells the user to set the path.
