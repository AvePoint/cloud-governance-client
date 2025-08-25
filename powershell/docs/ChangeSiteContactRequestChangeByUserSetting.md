# ChangeSiteContactRequestChangeByUserSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentUser** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**NewUser** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 
**AlternativeUser** | [**ApiMyGroupPrimaryContact**](ApiMyGroupPrimaryContact.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteContactRequestChangeByUserSetting = New-Cloud.Governance.ClientChangeSiteContactRequestChangeByUserSetting  -CurrentUser null `
 -NewUser null `
 -AlternativeUser null
```

- Convert the resource to JSON
```powershell
$ChangeSiteContactRequestChangeByUserSetting | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

