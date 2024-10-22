# Run Scripts to Submit Dynamic Requests

Below are sample scripts you can leverage in ServiceNow to be able have users submit requests in ServiceNow and let Cloud Governance execute the service request. For more information about the sample script for each service type, refer to the sections below.

## Note
| RESTMessage    | HttpMethod   | Endpoint URL                           |
| ---------------| --------------- | -------------------------------------- |
| x_avepo_cg_modern.GetDynamicServiceTemplate    |  Get    | `${data_center_url}/services/dynamic/${id}/template` |
| x_avepo_cg_modern.SubmitDynamicRequest   |   Post   | `${data_center_url}/requests/dynamic/template`    |


## Sample Script

```javascript

try { 
	var serviceId = 'xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx';
    sm = new sn_ws.RESTMessageV2('x_avepo_cg_modern.GetDynamicServiceTemplate', 'Get Service Template'); 
    sm.setStringParameter('data_center_url', gs.getProperty('x_avepo_cg_modern.data_center_url')); 
	sm.setStringParameter("gao_api_clientsecret", gs.getProperty('x_avepo_cg_modern.gao_api_clientsecret')); 
	sm.setStringParameter("gao_user_name", gs.getProperty('x_avepo_cg_modern.gao_user_name')); 
    sm.setStringParameter("id", serviceId); 
    response = sm.execute(); 
    var template = JSON.parse(response.getBody()); 
	
	template.serviceId = serviceId;
	template.summary = 'summary';
	template.notesToApprovers = 'note to approver';
	for (var i = 0; i < template .galleries.length; i++) {
	  if(template.galleries[i].teamNameAndDescription)
		{
			template.galleries[i].teamNameAndDescription.displayName = 'New Team Name';
		}
		if(template.galleries[i].classificationAndSensitivityLabel)
		{
			template.galleries[i].classificationAndSensitivityLabel.classification =  {
				"classificationName": "xxxx"
			};
		}
		if(template.galleries[i].teamId)
		{
			template.galleries[i].teamId.teamId = 'TestServiceNow';
		}
		if(template.galleries[i].teamContact)
		{
			template.galleries[i].teamContact.primaryContact = {};
			template.galleries[i].teamContact.primaryContact.loginName = "Demo1@domain.com";
			template.galleries[i].teamContact.secondaryContact = {};
			template.galleries[i].teamContact.secondaryContact.loginName = "Demo2@domain.com";
		}
		if(template.galleries[i].teamTemplate)
		{
			template.galleries[i].teamTemplate.value = 'xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx';
		}
		if(template.galleries[i].memberPermissionSetting)
		{
			template.galleries[i].memberPermissionSetting.allowCreateUpdateChannels = true;
			template.galleries[i].memberPermissionSetting.allowCreatePrivateChannels = true;
			template.galleries[i].memberPermissionSetting.allowDeleteChannels = true;
			template.galleries[i].memberPermissionSetting.allowAddRemoveApps = true;
			template.galleries[i].memberPermissionSetting.allowCreateUpdateRemoveTabs = true;
			template.galleries[i].memberPermissionSetting.allowCreateUpdateRemoveConnectors = true;
			template.galleries[i].memberPermissionSetting.allowEditMessages = true;
			template.galleries[i].memberPermissionSetting.allowDeleteMessages = true;
		}
		if(template.galleries[i].guestPermissionSetting)
		{
			template.galleries[i].guestPermissionSetting.allowGuestsCreateUpdateChannels = false;
			template.galleries[i].guestPermissionSetting.allowGuestsDeleteChannels = false;
		}
		if(template.galleries[i].funSetting)
		{
			template.galleries[i].funSetting.allowGiphy = false;
			template.galleries[i].funSetting.giphyContentRating = 0;
			template.galleries[i].funSetting.allowStickersAndMemes = false;
			template.galleries[i].funSetting.allowCustomMemes = false;
		}
		if(template.galleries[i].mentionSetting)
		{
			template.galleries[i].mentionSetting.allowTeamMentions = false;
			template.galleries[i].mentionSetting.allowChannelMentions = false;
		}
		if(template.galleries[i].cloneTeam)
		{
			template.galleries[i].cloneTeam.cloneTeamId = 'xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx';
			template.galleries[i].cloneTeam.enableCloneChannels = true;
			template.galleries[i].cloneTeam.enableCloneApps = true;
			template.galleries[i].cloneTeam.enableCloneTabs = true;
			template.galleries[i].cloneTeam.enableCloneMembers = true;
			template.galleries[i].cloneTeam.enableCloneTeamSetting = true;
		}
		if(template.galleries[i].teamHubSite)
		{
			template.galleries[i].teamHubSite.convertHubSite = 0;
			template.galleries[i].teamHubSite.registerAsHubSite = {};
			template.galleries[i].teamHubSite.registerAsHubSite.enabledUsers = [];
			template.galleries[i].teamHubSite.registerAsHubSite.hubSiteName = 'xxxx'
			var registeuser = {}; 
			registeuser.loginName = "Demo1@domain.com"; 
			template.galleries[i].teamHubSite.registerAsHubSite.enabledUsers.push(registeuser); 
		}
		if(template.galleries[i].teamSiteUrl)
		{
			template.galleries[i].teamSiteUrl.rootSite = 'https://xxxx.sharepoint.com';
		}
		if(template.galleries[i].owners)
		{
			template.galleries[i].owners.owners = [];
			var owner = {}; 
			owner.loginName = "Demo1@domain.com"; 
			template.galleries[i].owners.owners.push(owner); 
		}
		if(template.galleries[i].quotaSettingProfile)
		{
			template.galleries[i].quotaSettingProfile.value = 'xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx';
		}
		if(template.galleries[i].siteDesign)
		{
			template.galleries[i].siteDesign.appliedSiteDesignId = 'xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx';
			template.galleries[i].siteDesign.siteDesign = 'xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx';
		}
		if(template.galleries[i].guestPermissionSetting)
		{
			template.galleries[i].guestPermissionSetting.allowGuestsCreateUpdateChannels = false;
			template.galleries[i].guestPermissionSetting.allowGuestsDeleteChannels = false;
		}
		if(template.galleries[i].locale)
		{
			template.galleries[i].locale.locale = 1156;
		}
		if(template.galleries[i].members)
		{
			template.galleries[i].members.members = [];
			var member = {}; 
			member.loginName = "Demo1@domain.com"; 
			template.galleries[i].members.members.push(member); 
		}
		if(template.galleries[i].privacy)
		{
			template.galleries[i].privacy.enabled = true;
		}
		if(template.galleries[i].globalAddressList)
		{
			template.galleries[i].globalAddressList.enabled = true;
		}
		if(template.galleries[i].electionProfile)
		{
			template.galleries[i].electionProfile.value = 'xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx';
		}
		if(template.galleries[i].externalSharingSettingProfile)
		{
			template.galleries[i].externalSharingSettingProfile.value = 'xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx';
		}
		if(template.galleries[i].renewalProfile)
		{
			template.galleries[i].renewalProfile.value = 'xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx';
		}
		if(template.galleries[i].timeZone)
		{
			template.galleries[i].timeZone.timeZone = 38;
		}
		if(template.galleries[i].dynamicMembershipRules)
		{
			template.galleries[i].dynamicMembershipRules.dynamicMembershipRules = [];
			var rule = {}; 
			rule.category = 0; 
			rule.condition = 1; 
			rule.id = 'e3d704a9-8f0f-40b5-a746-0f5873a86f59'; 
			rule.metadataId = 'e3d704a9-8f0f-40b5-a746-0f5873a86f59'; 
			rule.metadataName = 'Display name'; 
			rule.metadataValue = 'demo'; 
			rule.order = 0; 
			rule.relation = 0; 
			template.galleries[i].dynamicMembershipRules.dynamicMembershipRules.push(rule); 
		}
		if(template.galleries[i].galleryMetadata)
		{
			for (var j = 0; j < template.galleries[i].galleryMetadata.length; j++) {
				template.galleries[i].galleryMetadata[j].singleLineOrMultipleLineValue = 'demo metadata value'
			}
		}
		
	}
	  
	sm = new sn_ws.RESTMessageV2('x_avepo_cg_modern.SubmitDynamicRequest', 'Submit Request By Template'); 
	sm.setStringParameter('data_center_url', gs.getProperty('x_avepo_cg_modern.data_center_url')); 
	sm.setStringParameter("gao_api_clientsecret", gs.getProperty('x_avepo_cg_modern.gao_api_clientsecret')); 
	sm.setStringParameter("gao_user_name", gs.getProperty('x_avepo_cg_modern.gao_user_name')); 
	sm.setRequestBody(global.JSON.stringify(template)); 

	response = sm.execute(); 
	var requestId = response.getBody().replace(/\"/g, ''); 
	var reg = new RegExp("^[0-9a-z]{8}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{12}$"); 
	if (requestId.match(reg) != null) { 
		gs.info('Successfully submitted the dynamic request via Cloud Governance API. Request Id: ' + requestId); 
	} else { 
		gs.error('An error occurred when submitting the dynamic request via Cloud Governance API. Details: ' + response.getBody()); 
	} 
	
} catch (ex) { 

    gs.error(ex); 

} 
