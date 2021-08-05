# Unit 2 What is Kubernetes?
- Container management: organizing, adding, removing, or updating a significant number of containers.
- Container orchestration: deploy & update containers automatically.
- Benefit: Self-healing, Dynamic scaling, Rolling updates, Managing storeage/networktraffic , managing sensitive info: name & password

# Unit 3 How Kubernetes works
- Control plane: API, Backin store, Scheduler, Controller manager, cloud controller manager
- Computer clusters: a set of computesrs which do the same kind of tasks
- Node: a PC in clusters
- kube-proxy: IP for eachnode, rules for routing, loadbalancing
- Container runtime: default = docker
- Kubernetes pods: An App with it's dependency. ex: web container + database container
- Kubernetes lifecycle: Pending, running/unknown, succeeded/failed, result
- Container states:     Wating, runing, terminated

# Unit 4 How Kubernetes deployments work
- 4 options to deploy pod: 
    - template: manually, not relaunched if failed/deleted/terminated.
    - replication: multiple pods.
    - replica set: ~ replication, + selector value
    - Deployments: Allow you to deploy & manage updates for pods.
- Kubernetes networking: 
    - Pods can communicate with one another across nodes without NAT
    - Nodes can communicate with all pods & vice versa without NAT.
    - Agents on a node can communicate with al nodes & pods.
- Kubetnetes services: ClusterIP, NodePort, LoadBalancer.
- Group pods using label.
- Kubernetes storage: pod removed, so is the volume. we can use *PersistentVolumes*, *PersistentVolumeClaims*
- Cloud integration considerations:  it's a best practice to use services outside the Kubernetes cluster.

# Unit 5 Exercise: explore a Kubernetes installation with a single-node cluster

# Unit 6 When to use Kubernetes
### When to use
- Microservice, cloud navitve app, containers, update containers at scale, centralized container networking & storage management

### WHen not to use
- If your company isn't ready to adopt this change because Kubernetes has a steep learning curve that will affect teams.

