# TreeNode
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebApplicationId** | **String** |  | [optional] 
**WebApplicationUri** | **String** |  | [optional] 
**SiteCollectionId** | **String** |  | [optional] 
**SiteCollectionUrl** | **String** |  | [optional] 
**SiteId** | **String** |  | [optional] 
**NodeId** | **String** |  | [optional] 
**StartIndex** | **Int32** |  | [optional] 
**PageSize** | **Int32** |  | [optional] 
**PageIndex** | **Int32** |  | [optional] 
**FullCount** | **Int32** |  | [optional] 
**Name** | **String** |  | [optional] 
**Title** | **String** |  | [optional] 
**Description** | **String** |  | [optional] 
**DisplayName** | **String** |  | [optional] 
**ManagedPath** | **String** |  | [optional] 
**AgentID** | **String** |  | [optional] 
**FullPath** | **String** |  | [optional] 
**FarmName** | **String** |  | [optional] 
**HasNextPage** | **Boolean** |  | [optional] 
**FarmID** | **String** |  | [optional] 
**ParentID** | **String** |  | [optional] 
**Extension** | [**TreeNodeExtension**](TreeNodeExtension.md) |  | [optional] 
**Parent** | [**TreeNode**](TreeNode.md) |  | [optional] 
**Type** | [**TreeNodeType**](TreeNodeType.md) |  | [optional] 
**SpObjectID** | **String** |  | [optional] 
**NetworkId** | **String** |  | [optional] 
**ParentSPObjectID** | **String** |  | [optional] 
**Id** | **String** |  | [optional] 
**LoadManagedPath** | **Boolean** |  | [optional] 
**LoadChildrenFromDB** | **Boolean** |  | [optional] 
**LoadedPageCount** | **Int32** |  | [optional] 
**Children** | [**TreeNode[]**](TreeNode.md) |  | [optional] 
**SelectedChildren** | [**TreeNode[]**](TreeNode.md) |  | [optional] 
**FilterUrls** | **String** |  | [optional] 
**FilterType** | **Int32** |  | [optional] 
**CheckNumber** | **Int32** |  | [optional] 
**SelectedWebAppIdSubSiteProvServ** | **String** |  | [optional] 
**SelectedSiteCollIdsSubSiteProvServ** | **String** |  | [optional] 
**ChildrenType** | **Int32** |  | [optional] 
**ListId** | **String** |  | [optional] 
**ServerRelativeUrl** | **String** |  | [optional] 
**UserName** | **String** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TreeNode = New-Cloud.Governance.ClientTreeNode  -WebApplicationId null `
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
 -NetworkId null `
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

- Convert the resource to JSON
```powershell
$TreeNode | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

