# ChangeSiteSharingRequestModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalSharing** | [**SharingCapabilitiesChangedValueRequestModel**](SharingCapabilitiesChangedValueRequestModel.md) |  | [optional] 
**GuestAccessExpireSetting** | [**SharingExpireSettingModelChangedValueRequestModel**](SharingExpireSettingModelChangedValueRequestModel.md) |  | [optional] 
**SharingAdvanceSetting** | [**SharingAdvanceSettingModelChangedValueRequestModel**](SharingAdvanceSettingModelChangedValueRequestModel.md) |  | [optional] 
**SharingLinkType** | [**SharingLinkTypeChangedValueRequestModel**](SharingLinkTypeChangedValueRequestModel.md) |  | [optional] 
**AnyoneLinksExpireSetting** | [**SharingExpireSettingModelChangedValueRequestModel**](SharingExpireSettingModelChangedValueRequestModel.md) |  | [optional] 
**LinkPermissionType** | [**LinkPermissionTypeChangedValueRequestModel**](LinkPermissionTypeChangedValueRequestModel.md) |  | [optional] 
**TenantLevelSetting** | [**SPTenantSharingSettingModel**](SPTenantSharingSettingModel.md) |  | [optional] 
**IsEnableSensitivityLabel** | **Boolean** |  | [optional] [default to $false]
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteSharingRequestModel = New-Cloud.Governance.ClientChangeSiteSharingRequestModel  -ExternalSharing null `
 -GuestAccessExpireSetting null `
 -SharingAdvanceSetting null `
 -SharingLinkType null `
 -AnyoneLinksExpireSetting null `
 -LinkPermissionType null `
 -TenantLevelSetting null `
 -IsEnableSensitivityLabel null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$ChangeSiteSharingRequestModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

