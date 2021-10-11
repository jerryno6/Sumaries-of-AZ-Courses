```
az appservice plan create -n plan1 -g rsgroup1 --sku FREE -l centralus

az webapp create -n appname1 -p plan1 -g rsgroup1

CONNECTIONSTRING=$(az storage account show-connection-string -n storage1 --output tsv)

az webapp config appsettings set -n appname1 -g rsgroup1 --settings AzureStorageConfig:ConnectionString=$CONNECTIONSTRING AzureStorageConfig:FileContainerName=files

dotnet publish -o pub
cd pub
zip -r ../site.zip *

az webapp deployment source config-zip --src ../site.zip -n appname1 -g rsgroup1

az storage blob list --account-name storage1 --container-name files --query [].{Name:name} --output table
```