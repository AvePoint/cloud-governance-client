# CreateCommunityGalleryShowLinksInRequestDetailsPage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SharePointSiteUrl** | **String** |  | [optional] [readonly] 
**GroupPlannerLink** | **String** |  | [optional] [readonly] 
**GroupFilesLink** | **String** |  | [optional] [readonly] 
**GroupNotebookLink** | **String** |  | [optional] [readonly] 
**TeamLink** | **String** |  | [optional] [readonly] 
**TeamsUrl** | **String** |  | [optional] [readonly] 
**ActivityId** | **String** | An unique identifier for the activity which can be used to find configuration in the dynamic service if it is assign by IT | [optional] 

## Examples

- Prepare the resource
```powershell
$CreateCommunityGalleryShowLinksInRequestDetailsPage = New-Cloud.Governance.ClientCreateCommunityGalleryShowLinksInRequestDetailsPage  -SharePointSiteUrl null `
 -GroupPlannerLink null `
 -GroupFilesLink null `
 -GroupNotebookLink null `
 -TeamLink null `
 -TeamsUrl null `
 -ActivityId null
```

- Convert the resource to JSON
```powershell
$CreateCommunityGalleryShowLinksInRequestDetailsPage | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

