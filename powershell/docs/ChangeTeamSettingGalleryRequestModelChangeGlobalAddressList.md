# ChangeTeamSettingGalleryRequestModelChangeGlobalAddressList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OriginalEnabled** | **Boolean** |  | [optional] [default to $false]
**ExchangeAssignBy** | [**AssignBy**](AssignBy.md) |  | [optional] 
**Enabled** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeTeamSettingGalleryRequestModelChangeGlobalAddressList = New-Cloud.Governance.ClientChangeTeamSettingGalleryRequestModelChangeGlobalAddressList  -OriginalEnabled null `
 -ExchangeAssignBy null `
 -Enabled null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeTeamSettingGalleryRequestModelChangeGlobalAddressList | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

