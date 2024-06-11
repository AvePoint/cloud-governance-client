# ServicePlanModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlanId** | **String** |  | [optional] 
**PlanDiscription** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ServicePlanModel = New-Cloud.Governance.ClientServicePlanModel  -PlanId null `
 -PlanDiscription null
```

- Convert the resource to JSON
```powershell
$ServicePlanModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

