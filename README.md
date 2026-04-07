# dotnet-csharp-learning

cd ~/devTools
git clone <your-github-repo-url>
cd dotnet-csharp-learning
dotnet new sln -n NewDotNet
dotnet new console -n NewDotNet.Fundamentals
dotnet sln NewDotNet.sln add NewDotNet.Fundamentals/NewDotNet.Fundamentals.csproj
dotnet sln NewDotNet.sln list
dotnet run --project NewDotNet.Fundamentals/NewDotNet.Fundamentals.csproj