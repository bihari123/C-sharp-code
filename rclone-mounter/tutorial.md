## Get the list of installed templates ( for gui )
```
dotnet new --list
```
## If you don't see the template you want, then just search it 


``` 
dotnet new avalonia.mvvm --search
```

## Then install the template 
```
   dotnet new --install Avalonia.Templates
```
## Then build a project using avaloniaUI
```
dotnet new avalonia.mvvm -o RcloneMounter -n RcloneMounter
```
## To make  a view, run the following command from the root of the project
```
dotnet new avalonia.usercontrol -o Views -n RcloneMounterView  --namespace RcloneMounter.Views
```

## Adding the sqlite in the csharp
```
dotnet add package Microsoft.Data.Sqlite
```
## Adding MessageBox package 
```
dotnet add package MessageBox.Avalonia 
```
