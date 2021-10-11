``` 
dotnet add package Azure.Storage.Blobs
```

```
az storage account show-connection-string \
  --resource-group learn-676c7dc1-bf19-4f89-8ebc-bee3ac46680e \
  --query connectionString \
  --name <name>
```

```
dotnet add package Microsoft.Extensions.Configuration.Json
```

```
az storage container list \
--account-name <name>
```

**Get help for command lines**
```
az storage container create -h
```