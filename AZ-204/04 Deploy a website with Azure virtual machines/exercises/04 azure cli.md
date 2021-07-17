```
az group create \
  --name <resource-group-name> \
  --location <resource-group-location>

az vm create \
  --resource-group [sandbox resource group name] \
  --name MeanStack \
  --image Canonical:UbuntuServer:16.04-LTS:latest \
  --admin-username azureuser \
  --generate-ssh-keys

```

Open port 80 for incoming HTTP trafic to the web
```
az vm open-port \
  --port 80 \
  --resource-group [sandbox resource group name] \
  --name MeanStack
```

Create SSH connection to the VM
```
ipaddress=$(az vm show \
  --name MeanStack \
  --resource-group [sandbox resource group name] \
  --show-details \
  --query [publicIps] \
  --output tsv)

ssh azureuser@$ipaddress
```


