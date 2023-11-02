# TeamMemberPermissionSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowCreateUpdateChannels** | **Boolean** |  | [optional] [default to $false]
**AllowCreatePrivateChannels** | **Boolean** |  | [optional] [default to $false]
**AllowDeleteChannels** | **Boolean** |  | [optional] [default to $false]
**AllowAddRemoveApps** | **Boolean** |  | [optional] [default to $false]
**AllowCreateUpdateRemoveTabs** | **Boolean** |  | [optional] [default to $false]
**AllowCreateUpdateRemoveConnectors** | **Boolean** |  | [optional] [default to $false]
**AllowEditMessages** | **Boolean** |  | [optional] [default to $false]
**AllowDeleteMessages** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$TeamMemberPermissionSetting = New-Cloud.Governance.ClientTeamMemberPermissionSetting  -AllowCreateUpdateChannels null `
 -AllowCreatePrivateChannels null `
 -AllowDeleteChannels null `
 -AllowAddRemoveApps null `
 -AllowCreateUpdateRemoveTabs null `
 -AllowCreateUpdateRemoveConnectors null `
 -AllowEditMessages null `
 -AllowDeleteMessages null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$TeamMemberPermissionSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

