Remove-Item -Recurse -Force $PSScriptRoot\output, $PSScriptRoot\SampleDeploymentContributor\obj, $PSScriptRoot\SampleDatabase\obj
dotnet build $PSScriptRoot\SampleDeploymentContributor\SampleDeploymentContributor.csproj

# deffer issue
# dotnet build $PSScriptRoot\SampleDatabase\SampleDatabase.sqlproj /p:WithoutInputs=False

# report issue
dotnet build $PSScriptRoot\SampleDatabase\SampleDatabase.sqlproj
