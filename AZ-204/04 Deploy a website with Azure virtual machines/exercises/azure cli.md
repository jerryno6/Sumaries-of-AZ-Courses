```
ssh-keygen -m PEM -t rsa -b 4096
```

See content of file
```
cat ~/.ssh/id_rsa.pub
```

```
ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAACAQC8gWN6DNmAsasX2x69wpV1Q2ZZf7r+7mG+t0+uE0sRINqZ5zh98uQx1gMfShUenT1+Qe4z0XCaKqnPg5O42JK2+6TiBG2aYv3on4KZbGzQUJDwkESw4sYr9+lI6eJVekunPyjZ0J+UVZFKHvGX1CbKHqlUq3c7+NRK9IWVb3raqrPYPA3IZcFtFWEK3gbkVmOnLwdcxw0TfeiTk9DPsVlxKXKNkJmSkIovuqp385qKgO6CgXup0t+FzmvYaFu7YB+SJogak4BSYb3jdurh4kuyeuSiTOWJakA9TW6eFLz16kRXmy+d/qWd6LRkn+ao24O4hk62Bk6/7er1IUKDgu6n6cL9fvWvsAnvehLgn/nDbPg31p457QvFiylTmciO7wKQHgsS+c98pTs1xH+dLqjgrj/IlJWFULnlyZ5i5i97iKRIAsGNIudYTY+wA4VkLUvPAWC7rdg9bYsHrQZkSrNXo4loTsfuuZR2vUL3kPInigW7aWTLjlggL33m1V7WuJ4BYRGC/HEtjfcEqMnG1kYoXpvKoFPEFm+owhDujuSSLk2VPbtFpfJCdYNfR0+8pkB8Md1B32FpjgN9FJvKKbzF1phUD+9Yc8S/Pu1B8WLcLtGumFAmBr6jGwuir9f4NX6tsqCZtDY2K4BsL4PSSsyjulxPehUEokiAU6AMpvnM+Q== ledangvu@cc-839d3a22-56b4544fdc-9hhq7
```

Copy key to VM
```
ssh-copy-id -i ~/.ssh/id_rsa.pub azureuser@myserver
```

the default SSH key will be placed at ~/.ssh/username
Start remote to the VM
```
ssh -i <private key path> vule@168.63.245.7

or 

ssh -i vule@168.63.245.7
```