# ChangeLibrarySettingValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] 
**WebUrl** | **String** |  | [optional] 
**WebId** | **String** |  | [optional] 
**IsEditRequest** | **Boolean** |  | [optional] [default to $false]
**Lists** | [**SPList[]**](SPList.md) |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) | ApiUser model | [optional] 
**Owners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**Members** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**CoOwners** | [**ApiUser[]**](ApiUser.md) |  | [optional] 
**SiteTitle** | **String** |  | [optional] 
**SiteId** | **String** |  | [optional] 
**Classification** | **String** |  | [optional] 
**IsEnableSensitivityLabel** | **Boolean** |  | [optional] [default to $false]
**SiteUrl** | **String** |  | [optional] 
**TenantId** | **String** |  | [optional] 
**Sensitivity** | [**StringModel**](StringModel.md) | StringModel model | [optional] 
**Privacy** | **Boolean** |  | [optional] [default to $false]
**EnvironmentName** | **String** |  | [optional] 
**WorkspaceTypeWithValidated** | [**WorkspaceType**](WorkspaceType.md) |  | [optional] 
**IsHybrid** | **Boolean** |  | [optional] [default to $false]
**IsValid** | **Boolean** |  | [optional] [default to $false]
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeLibrarySettingValidateResult = New-Cloud.Governance.ClientChangeLibrarySettingValidateResult  -Metadatas null `
 -WebUrl null `
 -WebId null `
 -IsEditRequest null `
 -Lists null `
 -PrimaryContact null `
 -SecondaryContact null `
 -Owners null `
 -Members null `
 -CoOwners null `
 -SiteTitle null `
 -SiteId null `
 -Classification null `
 -IsEnableSensitivityLabel null `
 -SiteUrl null `
 -TenantId null `
 -Sensitivity null `
 -Privacy null `
 -EnvironmentName null `
 -WorkspaceTypeWithValidated null `
 -IsHybrid null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeLibrarySettingValidateResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

