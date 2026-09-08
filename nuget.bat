dotnet test .\C4.Net.Core.Tests\C4.Net.Core.Tests.csproj
dotnet test .\C4.Net.Client.Tests\C4.Net.Client.Tests.csproj

dotnet msbuild "/t:rebuild;pack" /p:Version=0.9.7 /p:Configuration=Debug .\C4.Net.Core\C4.Net.Core.csproj
dotnet msbuild "/t:rebuild;pack" /p:Version=0.9.7 /p:Configuration=Debug .\C4.Net.Client\C4.Net.Client.csproj