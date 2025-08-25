# UserMembershipInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectId** | **String** |  | [optional] 
**IdentityName** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**UserType** | [**MembershipUserType**](MembershipUserType.md) |  | [optional] 
**ActionType** | [**UserMembershipStatus**](UserMembershipStatus.md) |  | [optional] 
**Email** | **String** |  | [optional] 
**LoginName** | **String** |  | [optional] 
**AzureUserType** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$UserMembershipInfo = New-Cloud.Governance.ClientUserMembershipInfo  -ObjectId null `
 -IdentityName null `
 -DisplayName null `
 -UserType null `
 -ActionType null `
 -Email null `
 -LoginName null `
 -AzureUserType null
```

- Convert the resource to JSON
```powershell
$UserMembershipInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

