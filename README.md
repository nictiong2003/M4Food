## M4Food

Cross-platform .NET MAUI application for the M4Food team.

### Development Environment
- .NET 8 SDK with the `android` workload installed
- Visual Studio 2022 17.8+ or VS Code with the MAUI extension
- Android SDK / Emulator (API 34)

### Known Issues

**Build fails with `System.IO.IOException` mentioning files like `classes.jar` being locked**
- Happens when cloned repositories still carry stale locks inside `bin` / `obj`.
- Close Visual Studio, emulators, and any `dotnet` / `msbuild` processes.
- Delete `M4Food/bin` and `M4Food/obj`.
- In Visual Studio run `Clean Solution` → `Rebuild Solution`.
- If it still fails, reboot or check antivirus/sync tools that may lock the directory.