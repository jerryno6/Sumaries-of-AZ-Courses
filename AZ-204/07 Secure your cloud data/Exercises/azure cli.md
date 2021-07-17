sends the folder's contents to Azure Container Registry
```
cd ~/mslearn-deploy-run-container-app-service/dotnet
az acr build --registry <container_registry_name> --image webimage .
```

```
az keyvault create \
    --resource-group <resource-group> \
    --name <your-unique-vault-name>
```

```
$key = Add-AzureKeyVaultKey -VaultName 'contoso' -Name 'MyFirstKey' -Destination 'HSM'
```

Show Secret Value in KeyVault
```
az keyvault secret show \
  --name MyPassword \
  --vault-name <my-keyvault-NNN> \
  --query value \
  --output tsv
```


