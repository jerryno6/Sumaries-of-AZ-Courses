# Exercise - Restrict network access
- Initially, all public access to your Azure SQL Database is blocked by the SQL Database firewall. you must specify one or more server-level IP firewall rules that enable access to your Azure SQL Database
- `SQL Data Warehouse only supports server-level IP firewall rules, and not database-level IP firewall rules.`

# Server-level firewall rules
### Allow access to Azure services
- Use it when PaaS services in Azure need to connect to SQL Server
- `This option configures the firewall to allow all connections from Azure including connections from the subscriptions of other customers. When selecting this option, make sure your login and user permissions limit access to only authorized users.` 
![Allow access to Azure services](https://docs.microsoft.com/en-us/learn/modules/secure-your-azure-sql-database/media/2-allow-azure-services.png)

### IP address rules: 
- Used when you have a static public IP address that needs to access your database. 
![IP address rules](https://docs.microsoft.com/en-us/learn/modules/secure-your-azure-sql-database/media/2-server-ip-rule-1.png)

### Virtual network rules
- Used when Azure VMs need to access your database. 
![Virtual network rules](https://docs.microsoft.com/en-us/learn/modules/secure-your-azure-sql-database/media/2-vnet-rule.png)

# Database-level firewall rules
### IP address rules
![IP address rules](https://docs.microsoft.com/en-us/learn/modules/secure-your-azure-sql-database/media/2-db-ip-rule-1.png)

# Exercise - Control who can access your database
- grant permission for user such as
```
DENY SELECT ON SalesLT.Address TO ApplicationUser;
```

# Exercise - Secure your data in transit, at rest, and on display
- **encryption** : TLS, Transparent data encryption
- **data masking**: When querying the columns, database administrators will still see the original values, but non-administrators will see the masked values. For example

| FirstName     | EmailAddress  | Phone  |
| :------------- |:-------------:| :-----:|
| Orlando   | oXXX@XXXX.com | XXX-XXX-0173 |
| Keith     | kXXX@XXXX.com | XXX-XXX-0127 |
| Donna     | dXXX@XXXX.com | XXX-XXX-0130 |
| Janet     | jXXX@XXXX.com | XXX-XXX-0173 |

# Exercise - Monitor your database
### Advanced Data Security (ADS): 
- Data discovery & classification: protecting the sensitive data 
- Vulnerability assessment: discover, track, and help you remediate potential database vulnerabilities
- Advanced Threat Protection: detect abnomalous activity
