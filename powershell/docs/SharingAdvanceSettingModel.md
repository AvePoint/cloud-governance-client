# SharingAdvanceSettingModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SharingDomainRestrictionMode** | [**SharingDomainRestrictionMode**](SharingDomainRestrictionMode.md) |  | [optional] 
**LimitDomainList** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SharingAdvanceSettingModel = New-Cloud.Governance.ClientSharingAdvanceSettingModel  -SharingDomainRestrictionMode null `
 -LimitDomainList null
```

- Convert the resource to JSON
```powershell
$SharingAdvanceSettingModel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

