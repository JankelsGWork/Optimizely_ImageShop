@echo off
CALL CreateZip.cmd release

echo ----------------------
echo Creating nuget package
echo ----------------------

dotnet pack Imageshop.Optimizely.Plugin.csproj -p:Configuration=Release
pause