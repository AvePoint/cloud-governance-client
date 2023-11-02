# Cloud.Governance.Client.Model.CreateGroupRequestTemplateSettings
Teams template settings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableCreateTeamFromScratch** | **bool** | Whether to allow business users to create a team from scratch. | [optional] [default to false]
**EnableCreateTeamFromExistTeam** | **bool** | Whether to allow business users to create a team from an existing team. | [optional] [default to false]
**EnableCreateTeamFromTeamTemplate** | **bool** | Whether to allow business users to create a team using a team template. | [optional] [default to false]
**SelectedTemplate** | [**TeamsTemplateSettingsSelectedTemplate**](TeamsTemplateSettingsSelectedTemplate.md) |  | [optional] 
**SelectedMSTemplate** | [**TeamsTemplateSettingsSelectedMSTemplate**](TeamsTemplateSettingsSelectedMSTemplate.md) |  | [optional] 
**TeamTemplates** | [**List&lt;TextModel&gt;**](TextModel.md) | All team templates | [optional] 
**EnableCloneChannels** | **bool** | Set whether copying channels from the team is enabled. | [optional] [default to false]
**EnableCloneApps** | **bool** | Set whether copying apps from the team is enabled. | [optional] [default to false]
**EnableCloneTabs** | **bool** | Set whether copying tabs from the team is enabled. | [optional] [default to false]
**EnableCloneMembers** | **bool** | Set whether copying members from the team is enabled. | [optional] [default to false]
**EnableCloneTeamSetting** | **bool** | Set whether copying team settings from the team is enabled. | [optional] [default to false]
**EnableCloneTeamPrivacy** | **bool** | Whether to enable the team privacy. (Currently not supported) | [optional] [default to false]
**EnableCloneTeamClassification** | **bool** | Whether to enable the team classification. (Currently not supported) | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

