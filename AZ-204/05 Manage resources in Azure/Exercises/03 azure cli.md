Find most common use for blob
```
az find blob
```

```
az storage blob --help
```

```
az group list --output table
az group list --query "[?name == '$RESOURCE_GROUP']"
```

Create app Service plan to run our app
```
az appservice plan create --name $AZURE_APP_PLAN --resource-group $RESOURCE_GROUP --location $AZURE_REGION --sku FREE

az appservice plan list --output table
```

Create a web app
```
az webapp create --name $AZURE_WEB_APP --resource-group $RESOURCE_GROUP --plan $AZURE_APP_PLAN

az webapp list --output table
```

Deploy source code from github
```
az webapp deployment source config --name $AZURE_WEB_APP --resource-group $RESOURCE_GROUP --repo-url "https://github.com/Azure-Samples/php-docs-hello-world" --branch master --manual-integration
```