# Unit 2 What is Docker?:
- a loosely isolated environment that software package run on. We can run it without Virtual Machine (VM)
- Docker: a platform to develop, ship, run container.

# Unit 3 How Docker images work
- Container images: a package contain software
- host OS: the OS on which Docker on
- Container OS: the OS that is part of the packaged image. Container OS is the environment in which we deploy and run our application.
- BaseImage: scratch, empty container images without filesystemlayer.
- Parent image, child image.
- Docker file:  contains the instructions we use to build and run a Docker image

# Unit 4 How Docker containers work
```
docker ps -a
docker run -d   tmp-ubuntu
docker pause    happy_wilbur
docker restart  happy_wilbur
docker stop     happy_wilbur
docker rm       happy_wilbur  
```

- What is a volume: A volume is stored on the host filesystem at a specific folder location. Volumes are considered the preferred data storage strategy to use with containers.
- What is a bind mount: can mount any file or folder on the host. Expecting the host can change the contents of these mounts
- Docker network configuration: 
    - Bridge network: isolated. --publish 8080:80 (hostport:containerport)
    - Host
    - none

# Unit 5 When to use Docker containers
### Benefit of using container:
- Efficient use of hardware: 
- Container isolation
- Application portability
- Application delivery
- Management of hosting environments: We manage container OS, apps inside it without affecting other containers.
- Cloud deployments: Can run on Azure Container Instances, Azure App Service, and Azure Kubernetes Services

### When not to use: 
- Single point of attack because of using same host
- More complicated in managging.