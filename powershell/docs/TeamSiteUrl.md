# TeamSiteUrl
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RootSite** | **String** |  | [optional] 
**Url** | **String** |  | [optional] 
**HasSequenceNumber** | **Boolean** |  | [optional] [default to $false]
**UrlwithSequenceNumber** | **String** |  | [optional] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$TeamSiteUrl = New-Cloud.Governance.ClientTeamSiteUrl  -RootSite null `
 -Url null `
 -HasSequenceNumber null `
 -UrlwithSequenceNumber null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$TeamSiteUrl | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

