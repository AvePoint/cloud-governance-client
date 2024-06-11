# SharedChannelChangedMembership
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Users** | [**UserMembershipInfo[]**](UserMembershipInfo.md) |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$SharedChannelChangedMembership = New-Cloud.Governance.ClientSharedChannelChangedMembership  -Users null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$SharedChannelChangedMembership | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

