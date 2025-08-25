# ChangeTeamSettingGalleryRequestModelChangeTeamMemberPermission
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
**OriginalAllowCreateUpdateChannels** | **Boolean** |  | [optional] [default to $false]
**OriginalAllowCreatePrivateChannels** | **Boolean** |  | [optional] [default to $false]
**OriginalAllowDeleteChannels** | **Boolean** |  | [optional] [default to $false]
**OriginalAllowAddRemoveApps** | **Boolean** |  | [optional] [default to $false]
**OriginalAllowCreateUpdateRemoveTabs** | **Boolean** |  | [optional] [default to $false]
**OriginalAllowCreateUpdateRemoveConnectors** | **Boolean** |  | [optional] [default to $false]
**OriginalAllowEditMessages** | **Boolean** |  | [optional] [default to $false]
**OriginalAllowDeleteMessages** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeTeamSettingGalleryRequestModelChangeTeamMemberPermission = New-Cloud.Governance.ClientChangeTeamSettingGalleryRequestModelChangeTeamMemberPermission  -AllowCreateUpdateChannels null `
 -AllowCreatePrivateChannels null `
 -AllowDeleteChannels null `
 -AllowAddRemoveApps null `
 -AllowCreateUpdateRemoveTabs null `
 -AllowCreateUpdateRemoveConnectors null `
 -AllowEditMessages null `
 -AllowDeleteMessages null `
 -OriginalAllowCreateUpdateChannels null `
 -OriginalAllowCreatePrivateChannels null `
 -OriginalAllowDeleteChannels null `
 -OriginalAllowAddRemoveApps null `
 -OriginalAllowCreateUpdateRemoveTabs null `
 -OriginalAllowCreateUpdateRemoveConnectors null `
 -OriginalAllowEditMessages null `
 -OriginalAllowDeleteMessages null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeTeamSettingGalleryRequestModelChangeTeamMemberPermission | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

