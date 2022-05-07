# MatchingApp

After Cloning Run this command in PS

dotnet tool install --global dotnet-ef --version 5.0.0-preview.8.20407.4
dotnet ef migrations add InitialCreate -o Data/Migrations
dotnet ef database update
