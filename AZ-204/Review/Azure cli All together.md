# Create  cosmos db
`
az cosmosdb create --enable-automatic-failover true -g rsgroup1 --max interval 5 -l 'eastus=0 estus=1' --default-consistency-level strong
`


# Create Azure service bus 
`az servicebus queue create -g rsgroup1 -n name1 --namespace-name nsname1`

# Create Eventhubs
```
az eventhubs namespace create --name $NS_NAME

HUB_NAME=hubname-$RANDOM
az eventhubs eventhub create -n $HUB_NAME --namespace-name $NS_NAME

az storage account create -g rsgroup1 -l eastus --sku Standard_LRS -n storage1

az storage container create -n $CONTAINER_NAME --connection-string $CNNSTRING

```


# Create and deploy Web App
```
az appservice plan create -n plan1 -g rsgroup1 --sku FREE -l centralus

az webapp create -n appname1 -p plan1 -g rsgroup1

az webapp config appsettings set -n appname1 -g rsgroup1 --settings AzureStorageConfig:ConnectionString=$CONNECTIONSTRING AzureStorageConfig:FileContainerName=files

dotnet publish -o pub
cd pub
zip -r ../site.zip *

az webapp deployment source config-zip --src ../site.zip -n appname1 -g rsgroup1
or 
az webapp deployment source config -n $WEB_APP_NAME -g $RESOURCE_GROUP --repo-url $GITHUB_URL --branch master --manual-integration
```

# Create a VM using Azure CLI
```
az group create -n $RSGROUP_NAME -l $LOCATION

az vm create -g $RSGROUP_NAME -n vm1 --image Canonical:UbuntuServer:16.04-LTS:latest \
  --admin-username USER1 --generate-ssh-keys

az vm open-port --port 80 -g $RSGROUP_NAME -n OPENPORT80

ipaddress=$(az vm show \
  --name MeanStack \
  --resource-group $RSGROUP_NAME \
  --show-details \
  --query [publicIps] \
  --output tsv)

ssh azureuser@$ipaddress
```


# resource management
```
az resource tag --tags Department=Finance -g rsgroup1 -n msftlearn-vnet1 --resource-type "Microsoft.Network/virtualNetworks"
```

# Create VM using Azure PowerShell

```
$vmname = "testvm-eus-01"
New-AzVm -ResourceGroupName rsgroup1 -Name "testvm-eus-01" -Credential (Get-Credential) -Location "East US" -Image UbuntuLTS -OpenPorts 22

$vm = (Get-AzVM -Name "testvm-eus-01" -ResourceGroupName rsgroup1)
$vm.HardwareProfile
$vm.StorageProfile.OsDisk
$vm | Get-AzPublicIpAddress

ssh bob@205.22.16.5
```

Stop a VM and delete it
```
Stop-AzVM -Name $vm.Name -ResourceGroup $vm.ResourceGroupName

Remove-AzVM -Name $vm.Name -ResourceGroup $vm.ResourceGroupName

Get-AzResource -ResourceGroupName $vm.ResourceGroupName | ft

$vm | Remove-AzNetworkInterface –Force
Get-AzDisk -ResourceGroupName $vm.ResourceGroupName -DiskName $vm.StorageProfile.OSDisk.Name | Remove-AzDisk -Force
Get-AzVirtualNetwork -ResourceGroup $vm.ResourceGroupName | Remove-AzVirtualNetwork -Force
Get-AzNetworkSecurityGroup -ResourceGroup $vm.ResourceGroupName | Remove-AzNetworkSecurityGroup -Force
Get-AzPublicIpAddress -ResourceGroup $vm.ResourceGroupName | Remove-AzPublicIpAddress -Force
```

# Deploy a website to azure web app
```
dotnet new mvc --name BestBikeApp
cd BestBikeApp
dotnet run
curl -kL http://127.0.0.1:5000/

cd ~/BestBikeApp
dotnet publish -o pub
cd pub
zip -r site.zip *

az webapp deployment source config-zip \
    --src site.zip \
    --resource-group learn-d4c3bb97-0dc1-4d05-bef0-865324da006b \
    --name hellovule01
```

# Deploy a containerized to azure web app
```
az webapp config hostname add --ewbapp-name $APPNAME --g $RSGROUPNAME --hostname $HOSTNAME
az web app create -n $APPNAME --plan $APPPLAN -g $GROUPNAME
az web app config container set --docker-custom-image-name $DOCKERHUBCONTAINERPATH -n $APPNAME -g $GROUPNAME
```

# Secure Azure sql Database
```
export ADMINLOGIN='vule'
export PASSWORD='Abcde12345.'
export SERVERNAME=server$RANDOM
export RESOURCEGROUP=learn-21b1724f-fc3c-495c-992a-d36f67493165
export LOCATION=$(az group show --name $RESOURCEGROUP | jq -r '.location')

az sql server create -n $SERVERNAME -g $RESOURCEGROUP -l $LOCATION -u $ADMINLOGIN -p $PASSWORD

az sql db create -g $RESOURCEGROUP -s $SERVERNAME -n marketplaceDb --sample-name AdventureWorksLT --service-objective Basic

az sql db show-connection-string --client sqlcmd -n marketplaceDb -s $SERVERNAME | jq -r

sqlcmd -S tcp:server28444.database.windows.net,1433 -d marketplaceDb -U '[username]' -P '[password]' -N -l 30

az vm create -g $RESOURCEGROUP -n appServer \
  --image UbuntuLTS --size Standard_DS2_v2 --generate-ssh-keys

ssh 40.80.159.134
```

Run these command line in bash to install sql tool
```
echo 'export PATH="$PATH:/opt/mssql-tools/bin"' >> ~/.bash_profile
echo 'export PATH="$PATH:/opt/mssql-tools/bin"' >> ~/.bashrc
source ~/.bashrc
curl https://packages.microsoft.com/keys/microsoft.asc | sudo apt-key add -
curl https://packages.microsoft.com/config/ubuntu/16.04/prod.list | sudo tee /etc/apt/sources.list.d/msprod.list
sudo apt-get update
sudo ACCEPT_EULA=Y apt-get install -y mssql-tools unixodbc-dev
```

Connect to Server
```
sqlcmd -S tcp:server28444.database.windows.net,1433 -d marketplaceDb -U 'vule' -P 'Abcde12345.' -N -l 30

It will display an error due to IPAddress allowance
```

In portal Set ***Allow access to Azure services*** to **YES** 

Then reconnect to SQL server. This time, it should be successful

```
EXECUTE sp_set_database_firewall_rule N'Allow appServer database level rule', '[From IP Address]', '[To IP Address]';
GO

EXECUTE sp_delete_database_firewall_rule N'Allow appServer database level rule';
GO
```

Grant permissions to a user
```
CREATE USER ApplicationUser WITH PASSWORD = 'YourStrongPassword1';
GO
ALTER ROLE db_datareader ADD MEMBER ApplicationUser;
ALTER ROLE db_datawriter ADD MEMBER ApplicationUser;
GO

DENY SELECT ON SalesLT.Address TO ApplicationUser;
GO
```

Reconnect to SQL using ApplicationUser
```
sqlcmd -S tcp:server28444.database.windows.net,1433 -d marketplaceDb -U 'ApplicationUser' -P 'YourStrongPassword1' -N -l 30

select top 1 Firstname, LastName, EmailAddress, Phone from SalesLT.Customer;
```

# Azure keyvault

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

