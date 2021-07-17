# Compile a checklist for creating an Azure Virtual Machine
- Virtual Network:  unroutable IP addresses such as 10.0.0.0/8, 172.16.0.0/12, or 192.168.0.0/16
- Network Security Groups (NSGs) acts as a software firewall, which allow you to control the traffic flow to and from subnets and to and from VMs
### Plan for each VM:
- What does the server communicate with , OS, port, diskspace, data, CPU ..
- VMname: 15chars in win, 64chars inlinux: env-location-instance-service-role. Ex: devusc-webvm01
- Resize a VM will make it reboot.

### Size of a VM
- General purpose
- Compute Optimized
- Memory Optimized
- Storage Optimized
- GPU
- High Performance: with high speed internet thoughput

### Pricing model:
- Compute costs, Storage costs
- Payment options: pay-as-you-go, reserved VM

### Azure storage: 
- Unmanaged disk: storage account is capable of supporting 40 standard virtual hard disks (VHDs) at full utilization.
- Managed Disk: Do not care about storage account limits.

### OS:
- azure only support 64 bit OS

# Exercise - Create a VM using the Azure portal

# Describe the options available to create and manage an Azure Virtual Machine
### Resource Manager templates
- JSON file

### Azure Automation services
- Process Automation: set up watcher tasks that can respond to events that may occur in your datacenter
- Configuration Management: track software updates
- Update Management: 

# Manage the availability of your Azure VMs
- Availability is the percentage of time a service is available for use.
- An `availability` set is a logical feature used to ensure that a group of related VMs are deployed so that they aren't all subject to a single point of failure and not all upgraded at the same time 
- `Fault Domains` is a logical group of hardware in Azure that shares a common set of hardware components, and that share a single point of failure.
- An `update domain` is a logical group of hardware that can undergo maintenance, or be rebooted at the same time

### **Azure Site Recovery** replicates workloads from a primary site to a secondary location
- Site Recovery enables the use of Azure as a destination for recovery, thus eliminating the cost and complexity of maintaining a secondary physical datacenter.
- Site Recovery makes it incredibly simple to test failovers for recovery drills without impacting production environments
- Azure Site Recovery works with Azure resources, or Hyper-V, VMware, and physical servers in your on-premises infrastructure 

# Back up your virtual machines
- Azure backup uses these components: Azure Backup agent, Azure Backup Server, Azure Backup VM extension, System Center Data Protection Manager

### advantages of azure backup:
- Automatic storage management. Azure Backup automatically allocates and manages backup storage and uses a pay-as-you-use model. You only pay for what you use.
- Unlimited scaling. Azure Backup uses the power and scalability of Azure to deliver high availability.
- Multiple storage options. Azure Backup offers locally redundant storage where all copies of the data exist within the same region and geo-redundant storage where your data is replicated to a secondary region.
- Unlimited data transfer. Azure Backup does not limit the amount of inbound or outbound data you transfer. Azure Backup also does not charge for the data that is transferred.
- Data encryption. Data encryption allows for secure transmission and storage of your data in Azure.
- Application-consistent backup. An application-consistent backup means that a recovery point has all required data to restore the backup copy. Azure Backup provides application-consistent backups.
- Long-term retention. Azure doesn't limit the length of time you keep the backup data.

