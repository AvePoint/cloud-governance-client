# AzureAdMetadataSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Office365Tenant** | [**GuidModel**](GuidModel.md) |  | [optional] [default to null]
**UseBuiltInProperty** | **Boolean** |  | [optional] [default to null]
**Value** | [**LookupValue**](LookupValue.md) |  | [optional] [default to null]
**Property** | **String** |  | [optional] [default to null]
**AllowReferenceAsRoleInApprovalProcess** | **Boolean** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientAzureAdMetadataSettings  -Office365Tenant null `
 -UseBuiltInProperty null `
 -Value null `
 -Property null `
 -AllowReferenceAsRoleInApprovalProcess null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

