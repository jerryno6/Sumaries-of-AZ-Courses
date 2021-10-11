# Classify your data

### Types of data
- Structure Data: SQL 
- Semi-structure Data: json, xml, yaml
- Unstructured data: media files, office files, text files, log files

# Determine operational needs
- Transaction data: need to be created, updated, deleted quickly and with high frequency.
- Photos and videos: can be queried by ID to return the whole file, but creates and updates will be less frequent and are less of a priority.
- Business data: For business data, all the analysis is happening on historical data. No original data is updated based on the analysis, so business data is read-only. Business analysts will be able to read from all databases.

# Group multiple operations in a transaction
- Transaction requirements: ACID stands for Atomicity, Consistency, Isolation, and Durability:
- OLTP (Online Transaction Processing)
- OLAP (Online Analytical Processing) 

# Choose a storage solution on Azure
- Transaction Data: SQL
- Photos & Videos: Blob
- Business data: SQL
- Product Catalog: Cosmos DB

# Azure storage access tiers
- Hot, cool, archive