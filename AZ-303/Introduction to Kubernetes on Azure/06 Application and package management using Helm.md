# Unit 2 What is Heml
- Package manager = App resources + deployment resources
- Heml client
- Heml chart
- Helm release
- Heml repositories

# Unit 3 Exercise - Install an AKS cluster for the team test deployments using HELM

# Unit 4 Create and install a Helm chart
- Heml combines all yaml files.
- use `Heml create` to create ChartTemplate **chart.yaml**: Quite similar to kubernetes deploy.yaml
- **values.yaml** contains configuration values for Heml chart, can be predefined or supplied by the user at the time of deploying.
- Test a helm chart: `helm install --debug --dry-run my-drone-webapp ./drone-webapp`
- Install heml chart: `helm install my-drone-webapp ./drone-webapp`

# Unit 5 Exercise

# Unit 6 Manage a Helm release
- Heml programming language: ifelse, loop.
- Define chart dependency
- Upgrade a Heml release `helm upgrade my-app ./app-chart`
- roll back a Helm release `helm rollback my-app 2`