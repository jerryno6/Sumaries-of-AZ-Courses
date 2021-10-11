# Explore Azure Storage security features
- All data written to Azure Storage is automatically encrypted by Storage Service Encryption (SSE) with a 256-bit Advanced Encryption Standard (AES) cipher, and is FIPS 140-2 compliant
- Azure Disk Encryption
- Azure Key Vault
- supports Azure Active Directory and role-based access control (RBAC)
- Use Storage Analytics service to audit

# Understand storage account keys
- Storage account keys give access to everything in the account -> **use in trusted in-house applications**

# Understand shared access signatures (SAS)
- For untrusted clients
- 2 types of SAS: 
    - service-level: specific resources
    - account-level: all 
- We can specify the time range of access, so that 3rd party can only use storage for a limited period of time

![SAS explaination](https://docs.microsoft.com/en-us/learn/data-ai-cert/secure-azure-storage-account/media/4-client-flowchart.png)

![SAS explaination](https://docs.microsoft.com/en-us/learn/data-ai-cert/secure-azure-storage-account/media/4-server-flowchart.png)

# Control network access to your storage account
- You can restrict access to specific IP addresses, ranges, or virtual networks

# Understand advanced threat protection for Azure Storage
- Azure Defender for Storage : alert when anomalies in activity occur

# Explore Azure Data Lake Storage security features