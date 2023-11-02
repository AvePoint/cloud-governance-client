# M365GroupLifecycleModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **String** |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 
**GroupName** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**SharedPointSiteUrl** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$M365GroupLifecycleModel = New-Cloud.Governance.ClientM365GroupLifecycleModel  -GroupId null `
 -OfficeTenantId null `
 -GroupName null `
 -Email null `
 -SharedPointSiteUrl null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$M365GroupLifecycleModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

