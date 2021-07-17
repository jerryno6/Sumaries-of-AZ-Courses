Deploy web app using zip 
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

Deploy a containerized web app
```
APPNAME="vuleApp"
HOSTNAME="http://www.abc.com">www.abc.com
GROUPNAME="group-name"
APPPLAN="AppPlan1"
DOCKERHUBCONTAINERPATH="abc/myweb:v1"

az webapp config hostname add --ewbapp-name $APPNAME --g $RSGROUPNAME --hostname $HOSTNAME
az web app create -n $APPNAME --plan $APPPLAN -g $GROUPNAME
az web app config container set --docker-custom-image-name $DOCKERHUBCONTAINERPATH -n $APPNAME -g $GROUPNAME

```