# Guidelines for using Azure Key Vault
- Key vaults: Keys/secret/cert management
- vaults: a container
- keys:  cryptographic asset destined for a particular use ex: password, publickey, private key
- secrets: data blobs protected by a HSM-generated key ex: PFX files, SQL connection strings, data encryption keys, etc.

# Manage access to secrets, certificates, and keys
- Azure Key Vault uses Azure Active Directory (Azure AD) to authenticate users 
- a built-in role `Key Vault Contributor` provides access to management features of key vaults
- You can then customize the permissions as desired by changing the Key permissions entries
- Restricting network access
- Keyvault only accept system-assigned managed identity

# Manage certificates

![1st](https://docs.microsoft.com/en-us/learn/modules/configure-and-manage-azure-key-vault/media/5-certificate-authority-1.png)

![2nd](https://docs.microsoft.com/en-us/learn/modules/configure-and-manage-azure-key-vault/media/5-certificate-authority-2.png)