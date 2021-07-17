# Read data with input & output bindings
- 4 Input binding types: Blob, cosmosdb, mobile app, Azure table storage
- 7 types of ouput binding express: App settings, Trigger filename, Trigger metadata, JSON payloads, New GUID, Current date and time
- When we use cosmosDB as input, we can specify id for it to query, or we can write our own query, but we need to handle thereturn collection in our code to display it to UI.
- Edit file junction.json to edit the connection configuration
- A function can have only 1 trigger, but multiple inputs