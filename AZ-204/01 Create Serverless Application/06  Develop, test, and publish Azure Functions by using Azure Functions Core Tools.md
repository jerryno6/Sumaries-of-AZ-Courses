# Azure function core tools v2.0
- Develop, run, test locally before publishing it to azure.
- `func init` Create new function project, choose runtime & language
- `func new` Create new function, choose type of function

# Install azure function core and azure cli at local:
- `brew update && brew install azure-cli` install azure cli
- `brew tap azure/functions` prepare to install azfunction tool
- `brew install azure-functions-core-tools@3` Install azure function 3x

# Test function:
- func start &> ~/output.txt &
- curl "http://localhost:7071/api/simple-interest?principal=5000&rate=.035&term=36" -w "\n"

# Publish to azure
- you might need to install azure cli & login
- `az login`
- func azure functionapp publish <app_name>
- The Core Tools do not validate or test your functions code during publishing
- Any functions already present in the target app are stopped and deleted before the contents of your project are deployed