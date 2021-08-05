# Unit 2 Create an Azure Kubernetes Service cluster
- Cluster architectures
    - 1 plan & Nodes
    - 1 control plan & 1 node: dev environment
- Node pools: 
    - specify VMsize, OS size    
    - Default cluster: Linux node pool.
    - New node created in Nodepool will have the same size & OS
- Node count: number of nodes
- HTTP application routing: automatic routing because clusters block all external communication by default.
- Ingress Controllers: expose the app to the world

# Unit 3 Exercise - Create an Azure Kubernetes Service cluster

# Unit 4 Deploy an application on your Azure Kubernetes Service cluster
- container registry
- Kubernetes pod
- Kubernetes deployment: deploy many of pod, update app
- Kubernetes manifest files: describe workloads in Yaml
- Kubernetes label: group objects
- Manifest file: define everything need to create & manage workload  

# Unit 5 Exercise - Deploy an application on your Azure Kubernetes Service cluster

# Unit 6 Enable network access to an application
- Kubenetes services: acts as a load balancer for ports. It need: target resource (defined by Label), serviceport (port for app), protocol, resource port (targetPort)
    - ClusterIP
    - NodePort
    - Loadbalancer
    - External name
- Kubenetes ingresses: allow you to expose any app without worrying IP address of pods & containers. So from out side kubernetes can connect to app.
- Annotation: for addon usage

# Unit 7 Exercise - Enable network access to an application

