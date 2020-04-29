# RenewModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Contacts** | [**ObjectContactModel**](ObjectContactModel.md) |  | [optional] [default to null]
**Metadatas** | [**RequestMetadata[]**](RequestMetadata.md) |  | [optional] [default to null]
**Memberships** | [**MembershipRenewalItemModel[]**](MembershipRenewalItemModel.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientRenewModel  -Contacts null `
 -Metadatas null `
 -Memberships null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

