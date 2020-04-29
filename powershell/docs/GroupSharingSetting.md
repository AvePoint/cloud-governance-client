# GroupSharingSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableManageGroupSharing** | **Boolean** |  | [optional] [default to null]
**EnableInviteGuestUser** | **Boolean** |  | [optional] [default to null]
**EnableManageSiteSharing** | **Boolean** |  | [optional] [default to null]
**SiteSharingType** | [**GroupSiteSharingCapabilities**](GroupSiteSharingCapabilities.md) |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientGroupSharingSetting  -EnableManageGroupSharing null `
 -EnableInviteGuestUser null `
 -EnableManageSiteSharing null `
 -SiteSharingType null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

