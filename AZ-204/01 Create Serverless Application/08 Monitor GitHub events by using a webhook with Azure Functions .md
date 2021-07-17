# Azure Functions can be triggered by a webhook

# Setup a webhook
- Step 1: specify how you want your webhook to behave
- Step 2: what events it should listen to
- Payload URL: THe url of our server which will receive a POST call from other service
- Content type: JSON / form parameter
- Events: What event we want 3rdparty service to notify us.
- Use secrettoken for security, we only want to receive request from github.

# Exercise - Secure webhook payloads with a secret
- Get function key from azure and put it to github hooks secret.