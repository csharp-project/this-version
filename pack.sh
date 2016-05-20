#!/bin/sh

xbuild /t:Build /p:Configuration=Release
nuget pack ThisVersion/ThisVersion.csproj.nuspec