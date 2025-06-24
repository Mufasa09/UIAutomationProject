# Use SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

RUN chmod +x /root/.nuget/packages/selenium.webdriver.msedgedriver/*/driver/linux64/msedgedriver || echo "File not found"

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
