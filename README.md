# dotnet-dll-sandbox-test
A repository to test how types to link the types from independent DLL.

## Run

```
dotnet publish LibA -o out/liba
dotnet publish LibB -o out/libb
dotnet run --project Loader/Loader.csproj
```