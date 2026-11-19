# Changelog

The app version lives in `src/xSADMain/xSADMain.csproj` (`<Version>`). Bump it for every release and add an entry here.
The two DLLs keep their own version (2.0.0.125) so installers never see them go "backwards".

## 1.7.4 – 2026-11-16

- Settings > Path Configuration redesigned to match the Cyprus VAT Return module: three boxes
  (Sage Version drop-down, Sage Installation Directory, Current user xml folder with a "..." browse button)
  and Save / Cancel. The long list of 19 radio buttons is gone, so the window is much smaller.
- The drop-down shows the Sage 50 versions installed on the PC (v2009 to v2026 and V33, e.g. "Sage 50 v2023");
  if none are found it lists them all. Choosing one fills in its data folder.
- The Sage version is now saved only when Save is pressed (before, clicking a version saved it at once,
  even if you then pressed Cancel). Saving a version whose data folder doesn't exist asks first.
- Fixed the "Sage Intallation Directory" typo.

## 1.7.3 – 2026-11-11

- Fixed: Tax For All rejected the VIES XML with "File content does not match its extension". The file was
  written as UTF-8 *with* a byte-order mark; it is now plain UTF-8 (no BOM) and declares `encoding="UTF-8"`.
  Files made by older versions can be fixed by re-saving them in Notepad as "UTF-8" (not "UTF-8 with BOM").

## 1.7.2 – 2026-10-29

- Fixed: app closed on startup with "Could not extract … sage version from path" when the Sage data folder
  wasn't found. It now opens and points to Settings > Path Configuration.
- Sage version is read from the data folder name (2009–2026, V33); auto-detect picks the newest folder with companies.
- Removed an unused SQL Server connection string (with `sa` password) from xSADReports.
- Source recovered from the v1.7.1 binaries; builds as a .NET Framework 4.8 x86 solution.
- See README "Fixes since decompiling" for details.

## 1.7.1

- Last release built from the original AccountsTech source (shipped binaries only).
