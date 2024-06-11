# ChangeContactObjectModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**PowerPlatformName** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**Type** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**PowerPlatformShowTargetObject** | **String** |  | [optional] 
**ObjectIdentity** | **String** |  | [optional] 
**EnvironmentName** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeContactObjectModel = New-Cloud.Governance.ClientChangeContactObjectModel  -ObjectId null `
 -TenantId null `
 -Name null `
 -PowerPlatformName null `
 -Email null `
 -Type null `
 -PowerPlatformShowTargetObject null `
 -ObjectIdentity null `
 -EnvironmentName null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeContactObjectModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

