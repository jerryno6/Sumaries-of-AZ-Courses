# Unit 2 Configure multiple nodes and enable scale-to-zero by using AKS
- System node pool: Linux, host system pods control plan, max pods per node is 30
- User node pool: can be linux / windows, allow 0 node count

### scale pool manualy
```
az aks nodepool scale \
    --resource-group resourceGroup \
    --cluster-name aksCluster \
    --name gpunodepool \
    --node-count 0
```

### Scale automatically
- Horizontal pod autoscaler: scale the number of service replicas. Scales pods only on available nodes in node pools. checks the Metrics API every 30 seconds
- Cluster autoscaler: scale the number of nodes based on computing resources.

# Unit 3 Exercise - Configure multiple nodes and enable scale-to-zero on an AKS cluster

# unit 4 Configure multiple node pools by using AKS spot node pools with the cluster autoscaler
- SpotVM < Spot scaleset < Spot node pool 
- Spot virtual machine: utilize unused azure compute capacity -> reduce price, no SLA
- Spot VM eviction policy: Deallocate
- Spot virtual machine scale set: Deallocate / Delete (vm & disk) => compensate by create new VM
- Spot node pool: user node pool that uses spot VM scale set,`--priority Spot `, `--spot-max-price`, `--eviction-policy`, `--enable-cluster-autoscaler`. Limitations:
    - AKS cluster need multiple node-pool support to be enabled; 
    - spot node pools can't be upgraded
    - The createion of spotVN isn't guaranteed.
    - Spot node pools should be used only for workloads that can be interrupted.
- To ensure that workloads are scheduled on the nodes of the spot user node pool: config toleration with a key `kubernetes.azure.com/scalesetpriority`

# Unit 5 Exercise - create spot node pools

# Unit 6 Configure AKS resource-quota policies by using Azure Policy for Kubernetes
- An admission controller: intercepts authenticated & authorized requests to kubernetes API
- An admission-controller webhook : validating & mutating
- Open Policy Agent (OPA): opensource
- OPA gate keeper: customize adminssion policies using configuration instead of hard coded.
- Azure Policy for AKS

# Unit 7 Exercise - Configure Azure Policy for Kubernetes on an AKS cluster