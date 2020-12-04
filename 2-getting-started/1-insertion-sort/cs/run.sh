#!/bin/bash
docker run --rm -t -v "$(pwd):/src" -w /src mcr.microsoft.com/dotnet/sdk:5.0-alpine dotnet test InsertionSortTest/InsertionSortTest.csproj