# GuestPermissionResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowGuestsCreateUpdateChannels** | **Boolean** |  | [optional] [default to $false]
**AllowGuestsDeleteChannels** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$GuestPermissionResult = New-Cloud.Governance.ClientGuestPermissionResult  -AllowGuestsCreateUpdateChannels null `
 -AllowGuestsDeleteChannels null
```

- Convert the resource to JSON
```powershell
$GuestPermissionResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

