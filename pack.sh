#!/bin/sh

rm *.nupkg

xbuild /t:Rebuild /p:Configuration=Release
nuget pack ThisVersion/ThisVersion.csproj.nuspec
