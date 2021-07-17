# Principles of resource groups
- Group resources
- Delete multiple resources

### How to use resource group:
- Naming convention ex: purpose-grouptype-type
- Group by environment, type, department, 

# Use tagging to organize resources
- Resource name is limited to 512 chars
- A tag value is limited to 256 chars
- A resource can have up to 50 tags, they can be used for : department, env, cost center, lifecycle
- Not all resource types support tags, and tags can't be applied to classic resources.
- You can use Azure Policy to automatically add or enforce tags for resources 
- Monitoring systems could include tag data with alerts
- reference Azure Automation Runbooks Gallery to know more
- You can apply tags to resource group, and the resouces inside it do not inherit those tags.

# Use policies to enforce standards
- Create Azure policy, create policy assignment

# Secure resources with role-based access control
- RBAC uses an allow model for access.
### Best Practices for RBAC
- Segregate duties within your team and grant only the amount of access to users that they need to perform their jobs
- grant users the lowest privilege level that they need to do their work
- use Resource Locks to prevent deletion

# Use resource locks to protect resources

# 