# Spike.NugetSeedworks
Example project to create and publish a NuGet package

[![Build Status](https://marius-vrstr.visualstudio.com/NugetSeedworks/_apis/build/status/mariusvrstr.Spike.NugetSeedworks?branchName=main)](https://marius-vrstr.visualstudio.com/NugetSeedworks/_build/latest?definitionId=5&branchName=main)

Reference  | Location
------------- | -------------
Azure DevOps CI/CD  | [Project Reference](https://marius-vrstr.visualstudio.com/NugetSeedworks)

- [X] Create a basic CLass Library Project with Unit Tests
- [X] Setup a basic CI/CD Pipeline in Azure DevOps
- [X] Include the .nuspec file
- [ ] Publish NuGet Package to Azure DevOps Artifact Feed
- [ ] Use the custom NuGet Package (from Artifact Feed) in another project
- [ ] Update the NuGet Package Version

# Environment Setup
1. Download the [latest Nuget](https://www.nuget.org/downloads) CLI
2. Move the downloaded file (nuget.exe) to a tools folder e.g. c:\clitools
3. Add to path variable (Control Panel > System > Advance settings > Environment Variables > PATH)
<img src="https://raw.githubusercontent.com/mariusvrstr/Spike.NugetSeedworks/main/resources/System.png" width="300" alt="PATH Variable"> 


# Project Setup

1. Ensure the Assembly name is unique
<img src="https://raw.githubusercontent.com/mariusvrstr/Spike.NugetSeedworks/main/resources/AssemblyName.png" width="300" alt="PATH Variable"> 
2. Configure Project Build to generate .nuspec file on build 
<img src="https://raw.githubusercontent.com/mariusvrstr/Spike.NugetSeedworks/main/resources/GenerateNuGetPackage.png" width="300" alt="Generate NuGet Package File"> 


# Azure DevOps Setup
This will allow for automated builds and package feed.
1. Add new Article Feed
2. Add new Pipeline (See YML file)
<img src="https://raw.githubusercontent.com/mariusvrstr/Spike.NugetSeedworks/main/resources/PushFeed.png" width="300" alt="PATH Variable"> 


# Resources
- [Create and publish package using visual studio](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio-net-framework)
- [Assigning access to internal projects](https://stackoverflow.com/questions/61384798/nuget-restore-not-working-with-artifact-feed-in-azure-devops)
