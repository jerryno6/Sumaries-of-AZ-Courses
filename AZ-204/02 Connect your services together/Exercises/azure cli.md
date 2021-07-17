### Select region for group 
```
az configure --defaults group=learn-ae4d4deb-e429-49b7-930c-04e4e6fb9a0f location="Central India"
```

Set subscription to work on
```
az account list --output table

az account set --subscription "id of subscription"
```

### Create eventhub namespace 
```
NS_NAME=ehubns-$RANDOM 
```

```
az eventhubs namespace create --name $NS_NAME
```

### List access keys
```
az eventhubs namespace authorization-rule keys list \
--name RootManageSharedAccessKey \
--namespace-name $NS_NAME
```

### Create event Hub
```
HUB_NAME=hubname-$RANDOM
az eventhubs eventhub create --name $HUB_NAME --namespace-name $NS_NAME
```

### View detail of eventHub
```
az eventhubs eventhub show --namespace-name $NS_NAME --name $HUB_NAME
```

### Create azure storage account
```
STORAGE_NAME=storagename$RANDOM
```

```
az storage account create \
  --resource-group learn-676c7dc1-bf19-4f89-8ebc-bee3ac46680e \
  --location eastus \
  --sku Standard_LRS \
  --name eastusstorageacc
```

### List all access key of storage account
```
az storage account keys list --account-name $STORAGE_NAME
```

### View connection string 
```
az storage account show-connection-string -n $STORAGE_NAME
```

### Create container inside azure storage
```
az storage container create --name messages --connection-string "DefaultEndpointsProtocol=https;EndpointSuffix=core.windows.net;AccountName=storagename21960;AccountKey=plLj1YGZ0erYgsL0t1fm2JL2PN6FRp+Ht4IfC0NoQieXkfrdiOcPvQzOsl83Kr5oPrTtRTTP4ZYiWkXSje6fQA=="
```