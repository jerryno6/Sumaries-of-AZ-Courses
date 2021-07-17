# Create an Event Hub using the Azure CLI
- EventHub namespace can have many EventHub
- Partition Count: expected number of concurrent consumers. Cant be changed
- By default eventhub have 4 partitions

# Configure applications to send or receive messages through an Event Hub

### To configure an application to send messages to an Event Hub, provide the following information, so that the application can create connection credentials:
- Event Hub namespace name
- Event Hub name
- Shared access policy name
- Primary shared access key
### To configure an application to receive messages from an Event Hub, provide the following information, so that the application can create connection credentials:
- Event Hub namespace name
- Event Hub name
- Shared access policy name
- Primary shared access key
- Storage account name
- Storage account connection string
- Storage account container name

**If you have a receiver application that stores messages in Azure Blob Storage, you'll also need to configure a storage account**

# Exercise - Configure applications to send or receive messages through an Event Hub

# Exercise - Evaluate the performance of the deployed Event Hub using the Azure portal

