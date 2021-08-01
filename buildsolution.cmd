@echo off
if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Preview\MSBuild\Current\Bin" goto vs16prev
if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin" goto vs16ent
if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin" goto vs16pro
if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin" goto vs16com
if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\BuildTools\MSBuild\Current\Bin" goto vs16build

echo "Unable to detect suitable environment. Check if VS 2019 is installed."

pause

:vs16prev
set msbuildpath=%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Preview\MSBuild\Current\Bin
goto build

:vs16ent
set msbuildpath=%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin
goto build

:vs16pro
set msbuildpath=%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin
goto build

:vs16com
set msbuildpath=%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin
goto build

:vs16build
set msbuildpath=%ProgramFiles(x86)%\Microsoft Visual Studio\2019\BuildTools\MSBuild\Current\Bin
goto build

:build
@echo Started: %date% %time%
@echo
set targets=Build
if not "%~1" == "" set targets=%~1
"%msbuildpath%\msbuild.exe" /t:%targets% build.proj /fl /flp:logfile=build.log

echo Do you now want to create NuGet packages? (y/n)
set INPUT=
set /PINPUT=Type input: %=%
if /I "%INPUT%"=="y" goto createpackages
if /I "%INPUT%"=="n" goto break

:createpackages
build.cmd Pack
@echo Build Completed: %date% %time%

:break
pause
@echo Build Completed: %date% %time%