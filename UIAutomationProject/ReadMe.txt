# Project Name

A brief description of what this project does and who it's for.

## Features

- Feature 1
- Feature 2
- Feature 3

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/username/project-name.git


#Docker use

In order to use Docker you will need to have Docker Destkop open. 
When opened navigate to UIAutomation.csproj root folder then create a Dockerfile
# Use SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the app
COPY . ./
RUN dotnet publish -c Release -o out

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Expose the port (match your app’s port)
EXPOSE 80

# Start the app
ENTRYPOINT ["dotnet", "UIAutomationProject.dll"]

Then use the command line to build the project 
docker buildx build -f Dockerfile -t uiautomationproject .

If file name error displays then rename file using command
ren Dockerfile.dockerfile Dockerfile

then run the command to create container:
docker run -d -p 8080:80 --name uiautomationprojectcontainer uiautomationproject

then run the command to run tests within docker:
docker run -d -p 4444:4444 --name selenium-chrome selenium/standalone-chrome

then run the command:
dotnet test

#This will run your tests within the docker container
