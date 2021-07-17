# Create a Linux virtual Machine in Azure
- Resources used in a VM: storage account, virtual disk, virtual network, network interface, public IP, 
- Choose storage options: HDD, SSD
- Map storage to VHD
- 1GiB = 1.074Gb

# Exercise - Decide an authentication method for SSH
- create keys for SSH

# Exercise - Create a Linux virtual machine with the Azure portal

# Azure virtual machines IP addresses and SSH options
### To connect to a VM we need these items:
- public IP
- port opened for SSH 22
- username + SSH key + access to private key

# Exercise - Connect to a Linux virtual machine with SSH

# Network and security settings
- Is used to enforce and control network traffic rules at the networking level
- Azure starting with the **lowest priority** rule
- default rule added to every security group for both inbound and outbound: **Deny ALL**
- 

# Exercise - Configure network settings