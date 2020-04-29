# SitePolicySharingSetting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **Boolean** |  | [optional] [default to null]
**SharingCapabilities** | [**SharingCapabilities**](SharingCapabilities.md) |  | [optional] [default to null]
**MembersCanShare** | **Boolean** |  | [optional] [default to null]
**AllowMembersEditMembership** | **Boolean** |  | [optional] [default to null]
**AllowAccessRequests** | **Boolean** |  | [optional] [default to null]
**RequestAccessEmail** | **String** |  | [optional] [default to null]
**AccessRequestType** | [**AccessRequestType**](AccessRequestType.md) |  | [optional] [default to null]
**AccessRequestMessage** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientSitePolicySharingSetting  -IsEnabled null `
 -SharingCapabilities null `
 -MembersCanShare null `
 -AllowMembersEditMembership null `
 -AllowAccessRequests null `
 -RequestAccessEmail null `
 -AccessRequestType null `
 -AccessRequestMessage null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

