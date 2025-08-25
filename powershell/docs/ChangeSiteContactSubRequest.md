# ChangeSiteContactSubRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**AssignTo** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Reason** | **String** |  | [optional] 
**ModifiedBy** | **String** |  | [optional] 
**ModifiedByDisplayName** | **String** |  | [optional] 
**ModifiedDate** | **System.DateTime** |  | [optional] 
**Status** | **Int32** |  | [optional] [readonly] [default to 0]
**StatusDescription** | **String** |  | [optional] [readonly] 
**AdminContactSettings** | [**ChangeSiteContactSubRequestAdminContactSettings**](ChangeSiteContactSubRequestAdminContactSettings.md) |  | [optional] 
**ProgressStatus** | [**ApiRequestProgressStatus**](ApiRequestProgressStatus.md) |  | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteContactSubRequest = New-Cloud.Governance.ClientChangeSiteContactSubRequest  -Id null `
 -AssignTo null `
 -Reason null `
 -ModifiedBy null `
 -ModifiedByDisplayName null `
 -ModifiedDate null `
 -Status null `
 -StatusDescription null `
 -AdminContactSettings null `
 -ProgressStatus null
```

- Convert the resource to JSON
```powershell
$ChangeSiteContactSubRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

