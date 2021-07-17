# Analyze the limitations of a polling-based web app
- The itemlist will be updated even when there is no update from server. 

# Enable automatic updates in a web application using SignalR Service
- Create SignalR account , set service mode to ****serverless** 
- Create HTTP function **negotiate** it is used by webapp to get the connectionInfo about SignalR 
- Create `an Azure Cosmos DB Trigger` named **stocksChanged** which receives changes from CosmosDB and broadcast out a `signalRMessages`

# Other matters:
- CORS: allow a webapp running under one domain to access resource in another domain 
- `CORSCredentials:true` tells function app to accept credential cookies from the request. 

# Use a storage account to host a static website
- `Azure Functions: Deploy to Function App` 
- `Azure Storage: Configure Static Website` set default file: `index.html` and error document `index.html` 
- `Azure Storage: Deploy to Static Website` select storage account and choose `public subfolder` 
- Setup CORS in function app 