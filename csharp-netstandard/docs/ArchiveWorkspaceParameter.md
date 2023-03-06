# Cloud.Governance.Client.Model.ArchiveWorkspaceParameter
archive workspace parameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArchiveProfile** | **string** | WorkspaceType is site, you should set profile name             WorkspaceType is teams, you should set profile id | [optional] 
**WorkspaceType** | **WorkspaceArchivedType** | workspace type | [optional] 
**IsSendCancelEmail** | **bool** |  | [optional] [default to false]
**CancelEmailTemplateId** | **Guid** |  | [optional] 
**Workspace** | [**List&lt;WorkspaceIdTypeModel&gt;**](WorkspaceIdTypeModel.md) |  | [optional] 
**IsSelectAllWorkspace** | **bool** |  | [optional] [default to false]
**Type** | **WorkspaceType** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

