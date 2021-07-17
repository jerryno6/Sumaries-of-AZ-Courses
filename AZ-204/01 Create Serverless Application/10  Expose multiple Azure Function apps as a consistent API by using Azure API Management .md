# Azure API management
- Enable user to construct API from disparate microservices. 
- Enable user to publish, secure, transform, maintain and monitor APIS 
- APIM handles all tasks mediatting api calls such as authentication, authorization, logs, version management,  
- Once the API is built, we can implement cache or ensure security requirement.
- APIM Consumption Tier: no infrastructure to manage, no idle capacity, high-availability, automatic scaling, and usage-based pricing

![Azure API Management](https://docs.microsoft.com/en-us/azure/api-management/media/transform-api/api-management-management-console.png)

# Exercise - Create a new API in API Management from a function app
- Create 2 function Apps: ProductFunction & OrderFunction
- Create APIM in ProductFuncion, set  `OrgranizationName`
- Link ProductDetails to api

# The benefits of using Azure API Management to compose your API
- You can change the location and definition of the services behind without necessarily reconfiguring or updating the clientapps. 
- Hide the real microservces behind. 
- APIM can enforce consistent rules and security requirements on all microservices. 

# Exercise - Add another Azure Functions app to an existing API
- Add details to APIM
- get `master key` in subscriptions eg: c228cc3063d84c57b15e790a5b3ecccf
- Do the GET method with the key put in `Ocp-Apim-Subscription-Key` header to query. Eg as below:
>curl -X GET "https://productfunctionf04c6929c0-apim.azure-api.net/products/ProductDetails?id=2" -H "Ocp-Apim-Subscription-Key: c228cc3063d84c57b15e790a5b3ecccf"
