# RequestSensitivityLabel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **String** |  | [optional] 
**Name** | **String** |  | [optional] 
**AllowGuestSharing** | **Boolean** |  | [optional] [default to $false]
**SiteSharing** | **Int32** |  | [optional] [default to 0]
**Privacy** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$RequestSensitivityLabel = New-Cloud.Governance.ClientRequestSensitivityLabel  -Id null `
 -Name null `
 -AllowGuestSharing null `
 -SiteSharing null `
 -Privacy null
```

- Convert the resource to JSON
```powershell
$RequestSensitivityLabel | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

