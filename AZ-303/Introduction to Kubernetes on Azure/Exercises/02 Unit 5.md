# Install MicroK8s
- install VM manager: multipass
- pull & run a VM for k8s
- connect to vm instance
- Install microK8s snap app

```
brew install --cask multipass
multipass launch --name microk8s-vm --mem 4G --disk 40G
multipass shell microk8s-vm
sudo snap install microk8s --classic
```

# Prepare the cluster
- Checkstatus of the installation
- Install addons

```
sudo microk8s.status --wait-ready
sudo microk8s.enable dns dashboard registry
```

# Explore the Kubernetes cluster
- Create alias `kubectl`

```
sudo snap alias microk8s.kubectl kubectl
sudo kubectl get nodes
sudo kubectl get nodes -o wide
sudo kubectl get services -o wide --all-namespaces
```

# Install websererver on a cluster
- Create NGINX deployment
- Fetch information ab deployment,
- Fetch information ab pods
- Find address of the pod

```
sudo kubectl create deployment nginx --image=nginx
sudo kubectl get deployments
sudo kubectl get pods
sudo kubectl get pods -o wide
```

- Get the website from address of the pod
```
wget 10.1.83.10
```

# Scale a web server deployment on a cluster
- Scale web
- Check running pods

```
sudo kubectl scale --replicas=3 deployments/nginx
sudo kubectl get pods -o wide
```

# Uninstall MicroK8s
```
sudo microk8s.disable dashboard dns registry
sudo snap remove microk8s
exit
multipass stop microk8s-vm
multipass delete microk8s-vm
multipass purge
```