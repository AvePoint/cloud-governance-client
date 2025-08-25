# InviteGuestGalleryInviteGuestUserScope
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **String** |  | [optional] 
**Mode** | [**InviteGuestMode**](InviteGuestMode.md) |  | [optional] 
**IsSeparateApprovalProcess** | **Boolean** |  | [optional] [default to $false]
**SeparatedApprovalProcessId** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$InviteGuestGalleryInviteGuestUserScope = New-Cloud.Governance.ClientInviteGuestGalleryInviteGuestUserScope  -TenantId null `
 -Mode null `
 -IsSeparateApprovalProcess null `
 -SeparatedApprovalProcessId null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$InviteGuestGalleryInviteGuestUserScope | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

