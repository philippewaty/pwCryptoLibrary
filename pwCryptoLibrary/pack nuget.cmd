if not exist NuGet mkdir NuGet

del /Q NuGet\*.*

NuGet.exe pack pwCryptoLibrary.nuspec -OutputDirectory NuGet -IncludeReferencedProjects -Properties Configuration=Release;Platform=AnyCPU -Build

rem pause