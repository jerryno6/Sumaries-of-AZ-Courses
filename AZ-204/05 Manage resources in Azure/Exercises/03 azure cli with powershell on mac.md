Run powershell
```
sudo pwsh
```

```
Get-Help Get-ChildItem -detailed

Get-Module
```

Install & update  azure module
```
Install-Module Az -AllowClobber
```

```
Import-Module Az
Connect-AzAccount
Select-AzSubscription -SubscriptionId 'ade79e45-e72d-49ad-8a7b-f86b98cd9d42'
Get-AzResourceGroup | Format-Table

New-AzResourceGroup -Name <name> -Location <location>
Get-AzResource | ft
Get-AzResource -ResourceGroupName ExerciseResources
```

Create virtual machine
```
$vmname = "testvm-eus-01"
New-AzVm -ResourceGroupName learn-8d35fbf5-b4de-423d-8243-54fd9b00503d -Name "testvm-eus-01" -Credential (Get-Credential) -Location "East US" -Image UbuntuLTS -OpenPorts 22

$vm = (Get-AzVM -Name "testvm-eus-01" -ResourceGroupName learn-8d35fbf5-b4de-423d-8243-54fd9b00503d)
$vm.HardwareProfile
$vm.StorageProfile.OsDisk
$vm | Get-AzPublicIpAddress
```

Connect to VM
```
ssh bob@205.22.16.5
```

Stop a VM and delete it
```
Stop-AzVM -Name $vm.Name -ResourceGroup $vm.ResourceGroupName

Remove-AzVM -Name $vm.Name -ResourceGroup $vm.ResourceGroupName

Get-AzResource -ResourceGroupName $vm.ResourceGroupName | ft

$vm | Remove-AzNetworkInterface –Force
Get-AzDisk -ResourceGroupName $vm.ResourceGroupName -DiskName $vm.StorageProfile.OSDisk.Name | Remove-AzDisk -Force
Get-AzVirtualNetwork -ResourceGroup $vm.ResourceGroupName | Remove-AzVirtualNetwork -Force
Get-AzNetworkSecurityGroup -ResourceGroup $vm.ResourceGroupName | Remove-AzNetworkSecurityGroup -Force
Get-AzPublicIpAddress -ResourceGroup $vm.ResourceGroupName | Remove-AzPublicIpAddress -Force
```