# Identify incorrectly assigned resources in Azure
- use tags
- use name

# Exercise - Identify incorrectly assigned resources

# Assess resources that can move
- Check in the list `Move operation support for resources` for resources which can be moved

### Virtual machines have their own limitations you must keep in mind. Here's a summary of limitations for virtual machines:
- If you want to move a virtual machine, all of its dependants must go with it.
- You can't move virtual machines with certificates in Azure Key Vault between subscriptions.
- You can't move virtual machine scale sets with standard load balancers or a standard public IP.
- You can't move any managed disks that are in availability zones to different subscriptions.


# Validate resources in Azure
- use azure rest to send POST to get url
- use GET url to check for result
- If you use azure portal, the test for moving will be done automatically after moving.

# Identify steps to move resources between Azure resource groups
- Create a resource group.
- Get the resource.
- Move the resource to another resource group by using the resource ID.
- Return all the resources in your resource group to verify your resource moved.


# Exercise - Move and verify resources between Azure resource groups