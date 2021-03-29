# UnlockSiteSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsExpired** | **Boolean** |  | [optional] [default to $false]
**IsExtendEnabled** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$UnlockSiteSetting = New-Cloud.Governance.ClientUnlockSiteSetting  -IsExpired null `
 -IsExtendEnabled null
```

- Convert the resource to JSON
```powershell
$UnlockSiteSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

