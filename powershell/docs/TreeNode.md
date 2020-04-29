# TreeNode
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebApplicationId** | **String** |  | [optional] [default to null]
**WebApplicationUri** | **String** |  | [optional] [default to null]
**SiteCollectionId** | **String** |  | [optional] [default to null]
**SiteCollectionUrl** | **String** |  | [optional] [default to null]
**SiteId** | **String** |  | [optional] [default to null]
**NodeId** | **String** |  | [optional] [default to null]
**StartIndex** | **Int32** |  | [optional] [default to null]
**PageSize** | **Int32** |  | [optional] [default to null]
**PageIndex** | **Int32** |  | [optional] [default to null]
**FullCount** | **Int32** |  | [optional] [default to null]
**Name** | **String** |  | [optional] [default to null]
**Title** | **String** |  | [optional] [default to null]
**Description** | **String** |  | [optional] [default to null]
**DisplayName** | **String** |  | [optional] [default to null]
**ManagedPath** | **String** |  | [optional] [default to null]
**AgentID** | **String** |  | [optional] [default to null]
**FullPath** | **String** |  | [optional] [default to null]
**FarmName** | **String** |  | [optional] [default to null]
**HasNextPage** | **Boolean** |  | [optional] [default to null]
**FarmID** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ParentID** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Extension** | [**TreeNodeExtension**](TreeNodeExtension.md) |  | [optional] [default to null]
**Parent** | [**TreeNode**](TreeNode.md) |  | [optional] [default to null]
**Type** | [**TreeNodeType**](TreeNodeType.md) |  | [optional] [default to null]
**SpObjectID** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ParentSPObjectID** | [**UUID**](UUID.md) |  | [optional] [default to null]
**Id** | [**UUID**](UUID.md) |  | [optional] [default to null]
**LoadManagedPath** | **Boolean** |  | [optional] [default to null]
**LoadChildrenFromDB** | **Boolean** |  | [optional] [default to null]
**LoadedPageCount** | **Int32** |  | [optional] [default to null]
**Children** | [**TreeNode[]**](TreeNode.md) |  | [optional] [default to null]
**SelectedChildren** | [**TreeNode[]**](TreeNode.md) |  | [optional] [default to null]
**FilterUrls** | **String** |  | [optional] [default to null]
**FilterType** | **Int32** |  | [optional] [default to null]
**CheckNumber** | **Int32** |  | [optional] [default to null]
**SelectedWebAppIdSubSiteProvServ** | [**UUID**](UUID.md) |  | [optional] [default to null]
**SelectedSiteCollIdsSubSiteProvServ** | **String** |  | [optional] [default to null]
**ChildrenType** | **Int32** |  | [optional] [default to null]
**ListId** | [**UUID**](UUID.md) |  | [optional] [default to null]
**ServerRelativeUrl** | **String** |  | [optional] [default to null]
**UserName** | **String** |  | [optional] [default to null]

## Examples

- Create a new object
```powershell
New-Cloud.Governance.ClientTreeNode  -WebApplicationId null `
 -WebApplicationUri null `
 -SiteCollectionId null `
 -SiteCollectionUrl null `
 -SiteId null `
 -NodeId null `
 -StartIndex null `
 -PageSize null `
 -PageIndex null `
 -FullCount null `
 -Name null `
 -Title null `
 -Description null `
 -DisplayName null `
 -ManagedPath null `
 -AgentID null `
 -FullPath null `
 -FarmName null `
 -HasNextPage null `
 -FarmID null `
 -ParentID null `
 -Extension null `
 -Parent null `
 -Type null `
 -SpObjectID null `
 -ParentSPObjectID null `
 -Id null `
 -LoadManagedPath null `
 -LoadChildrenFromDB null `
 -LoadedPageCount null `
 -Children null `
 -SelectedChildren null `
 -FilterUrls null `
 -FilterType null `
 -CheckNumber null `
 -SelectedWebAppIdSubSiteProvServ null `
 -SelectedSiteCollIdsSubSiteProvServ null `
 -ChildrenType null `
 -ListId null `
 -ServerRelativeUrl null `
 -UserName null
```

- Convert the object to JSON
```powershell
$ | Convert-ToJSON
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

