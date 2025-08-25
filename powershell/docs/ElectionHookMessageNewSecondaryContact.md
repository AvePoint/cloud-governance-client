# ElectionHookMessageNewSecondaryContact
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **String** | Display name of contact | [optional] 
**IdentityName** | **String** | User principal name of contact | [optional] 

## Examples

- Prepare the resource
```powershell
$ElectionHookMessageNewSecondaryContact = New-Cloud.Governance.ClientElectionHookMessageNewSecondaryContact  -DisplayName null `
 -IdentityName null
```

- Convert the resource to JSON
```powershell
$ElectionHookMessageNewSecondaryContact | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

