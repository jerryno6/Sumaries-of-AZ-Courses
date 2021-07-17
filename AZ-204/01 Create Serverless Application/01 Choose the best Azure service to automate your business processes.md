# Identify the technology options

### 4 Azure services to automate your business processes
1. (design first) Microsoft Power Automate : for `office user` to create selfservice workflow using GUI only, includes testing & production environment. 
2. (deisgn first) Azure Logic App: for `developers & IT pros` to create advanced integration project using GUI & code which can be stored in Azure devops & source code management system. 
3. (code first) Azure function: run small pieces of code in the cloud. 4 types: HTTPTrigger, TimerTrigger, Blobtrigger, CosmosDBTrigger. 
4. (code first) Azure WebJobs: It is a cloud-based hosting service for web applications, mobile back-ends, and RESTful APIs. Two type: Continuous & triggered. **Can customize JobHost, custom retry policy**. 

All of them have some similarities:
1. Can accepts inputs & produce outputs.
2. Can run actions.
3. Can include conditions.

### Microsoft Power Automate
![Microsoft Power Automate ](https://docs.microsoft.com/en-us/learn/modules/introduction-power-automate/media/flow-example.png)

### Azure Logic App
![Azure Loigc App](https://docs.microsoft.com/en-us/azure/logic-apps/media/logic-apps-overview/overview.png)

### Azure Function
![Azure Function](https://docs.microsoft.com/en-us/learn/modules/create-serverless-logic-with-azure-functions/media/4-file-navigation.png)

### Azure WebJobs CRON: {second} {minute} {hour} {day} {month} {day of the week} 
![Azure WebJobs](https://docs.microsoft.com/en-us/azure/app-service/media/web-sites-create-web-jobs/listallwebjobs.png)

### Evaluate Azure services for integration and process automation scenarios

# Analyze the decision criteria
What services is choosen depends on 
- Who will develop this solutionn
- Exist application

# Choose the best design-first technology to automate your business process

# When to choose Azure Functions to run your business logic
- Consider cost & integration