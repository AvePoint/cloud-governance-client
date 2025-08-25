# ChangeTeamSettingModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **String** |  | [optional] 
**OfficeTenantId** | **String** |  | [optional] 
**GroupName** | **String** |  | [optional] 
**Email** | **String** |  | [optional] 
**SharedPointSiteUrl** | **String** |  | [optional] 
**ServiceId** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeTeamSettingModel = New-Cloud.Governance.ClientChangeTeamSettingModel  -GroupId null `
 -OfficeTenantId null `
 -GroupName null `
 -Email null `
 -SharedPointSiteUrl null `
 -ServiceId null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeTeamSettingModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

