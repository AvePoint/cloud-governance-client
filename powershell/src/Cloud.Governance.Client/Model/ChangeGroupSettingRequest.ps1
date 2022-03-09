#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeGroupSettingRequest<PSCustomObject>
#>

function New-ChangeGroupSettingRequest {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${OriginalGroupName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${OriginalGroupDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${OriginalYammerGroupInfo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OriginalPrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OriginalSecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${GroupOwners},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${GroupMembers},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsDynamicMembership} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DynamicMembershipRules},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnabledSubscribe} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${OriginalEnabledSubscribe} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnabledOutsideSender} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${OriginalEnabledOutsideSender} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${HubSiteActionType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssociateHubSiteId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssociateHubSiteTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Classification},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${OriginalClassification},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Sensitivity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${OriginalSensitivity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableTeams} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${OriginalEnableTeams} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${GroupMetadatas},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${OriginalGroupMetadata},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ChangedDynamicGroupType} = "Manually",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${YammerGroupInfo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupObjectType} = "Group",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NetworkId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupObjectId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableTeamCollaboration} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TimeZoneSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OriginalTimeZoneSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LocaleSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${OriginalLocaleSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Summary},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NotesToApprovers},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${QuestionnaireId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${QuestionnaireResponse},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeGroupSettingRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "GroupId" = ${GroupId}
            "GroupEmail" = ${GroupEmail}
            "GroupName" = ${GroupName}
            "OriginalGroupName" = ${OriginalGroupName}
            "GroupDescription" = ${GroupDescription}
            "OriginalGroupDescription" = ${OriginalGroupDescription}
            "OriginalYammerGroupInfo" = ${OriginalYammerGroupInfo}
            "PrimaryContact" = ${PrimaryContact}
            "OriginalPrimaryContact" = ${OriginalPrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "OriginalSecondaryContact" = ${OriginalSecondaryContact}
            "GroupOwners" = ${GroupOwners}
            "GroupMembers" = ${GroupMembers}
            "IsDynamicMembership" = ${IsDynamicMembership}
            "DynamicMembershipRules" = ${DynamicMembershipRules}
            "EnabledSubscribe" = ${EnabledSubscribe}
            "OriginalEnabledSubscribe" = ${OriginalEnabledSubscribe}
            "EnabledOutsideSender" = ${EnabledOutsideSender}
            "OriginalEnabledOutsideSender" = ${OriginalEnabledOutsideSender}
            "HubSiteActionType" = ${HubSiteActionType}
            "AssociateHubSiteId" = ${AssociateHubSiteId}
            "AssociateHubSiteTitle" = ${AssociateHubSiteTitle}
            "Classification" = ${Classification}
            "OriginalClassification" = ${OriginalClassification}
            "Sensitivity" = ${Sensitivity}
            "OriginalSensitivity" = ${OriginalSensitivity}
            "EnableTeams" = ${EnableTeams}
            "OriginalEnableTeams" = ${OriginalEnableTeams}
            "GroupMetadatas" = ${GroupMetadatas}
            "OriginalGroupMetadata" = ${OriginalGroupMetadata}
            "ChangedDynamicGroupType" = ${ChangedDynamicGroupType}
            "YammerGroupInfo" = ${YammerGroupInfo}
            "GroupObjectType" = ${GroupObjectType}
            "NetworkId" = ${NetworkId}
            "GroupObjectId" = ${GroupObjectId}
            "EnableTeamCollaboration" = ${EnableTeamCollaboration}
            "TimeZoneSettings" = ${TimeZoneSettings}
            "OriginalTimeZoneSettings" = ${OriginalTimeZoneSettings}
            "LocaleSettings" = ${LocaleSettings}
            "OriginalLocaleSettings" = ${OriginalLocaleSettings}
            "Id" = ${Id}
            "ServiceId" = ${ServiceId}
            "Summary" = ${Summary}
            "NotesToApprovers" = ${NotesToApprovers}
            "QuestionnaireId" = ${QuestionnaireId}
            "QuestionnaireResponse" = ${QuestionnaireResponse}
            "Metadatas" = ${Metadatas}
        }

        return $PSO
    }
}

<#
ChangeGroupSettingRequest<PSCustomObject>
#>
function ConvertFrom-JsonToChangeGroupSettingRequest {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeGroupSettingRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeGroupSettingRequest
        $AllProperties = $("GroupId", "GroupEmail", "GroupName", "OriginalGroupName", "GroupDescription", "OriginalGroupDescription", "OriginalYammerGroupInfo", "PrimaryContact", "OriginalPrimaryContact", "SecondaryContact", "OriginalSecondaryContact", "GroupOwners", "GroupMembers", "IsDynamicMembership", "DynamicMembershipRules", "EnabledSubscribe", "OriginalEnabledSubscribe", "EnabledOutsideSender", "OriginalEnabledOutsideSender", "HubSiteActionType", "AssociateHubSiteId", "AssociateHubSiteTitle", "Classification", "OriginalClassification", "Sensitivity", "OriginalSensitivity", "EnableTeams", "OriginalEnableTeams", "GroupMetadatas", "OriginalGroupMetadata", "ChangedDynamicGroupType", "YammerGroupInfo", "GroupObjectType", "NetworkId", "GroupObjectId", "EnableTeamCollaboration", "TimeZoneSettings", "OriginalTimeZoneSettings", "LocaleSettings", "OriginalLocaleSettings", "Id", "ServiceId", "Summary", "NotesToApprovers", "QuestionnaireId", "QuestionnaireResponse", "Metadatas", "TicketNumber", "Type", "TypeDescription", "Requester", "RequesterLoginName", "Status", "ProgressStatus", "ProgressStatusDescription", "SubmittedTime", "LastUpdated", "CreatedTime", "AssignTo", "FullPath", "ApprovalStageName", "Participants", "ObjectID")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupId"))) { #optional property not found
            $GroupId = $null
        } else {
            $GroupId = $JsonParameters.PSobject.Properties["GroupId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupEmail"))) { #optional property not found
            $GroupEmail = $null
        } else {
            $GroupEmail = $JsonParameters.PSobject.Properties["GroupEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupName"))) { #optional property not found
            $GroupName = $null
        } else {
            $GroupName = $JsonParameters.PSobject.Properties["GroupName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalGroupName"))) { #optional property not found
            $OriginalGroupName = $null
        } else {
            $OriginalGroupName = $JsonParameters.PSobject.Properties["OriginalGroupName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupDescription"))) { #optional property not found
            $GroupDescription = $null
        } else {
            $GroupDescription = $JsonParameters.PSobject.Properties["GroupDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalGroupDescription"))) { #optional property not found
            $OriginalGroupDescription = $null
        } else {
            $OriginalGroupDescription = $JsonParameters.PSobject.Properties["OriginalGroupDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalYammerGroupInfo"))) { #optional property not found
            $OriginalYammerGroupInfo = $null
        } else {
            $OriginalYammerGroupInfo = $JsonParameters.PSobject.Properties["OriginalYammerGroupInfo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContact"))) { #optional property not found
            $PrimaryContact = $null
        } else {
            $PrimaryContact = $JsonParameters.PSobject.Properties["PrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalPrimaryContact"))) { #optional property not found
            $OriginalPrimaryContact = $null
        } else {
            $OriginalPrimaryContact = $JsonParameters.PSobject.Properties["OriginalPrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContact"))) { #optional property not found
            $SecondaryContact = $null
        } else {
            $SecondaryContact = $JsonParameters.PSobject.Properties["SecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalSecondaryContact"))) { #optional property not found
            $OriginalSecondaryContact = $null
        } else {
            $OriginalSecondaryContact = $JsonParameters.PSobject.Properties["OriginalSecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupOwners"))) { #optional property not found
            $GroupOwners = $null
        } else {
            $GroupOwners = $JsonParameters.PSobject.Properties["GroupOwners"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupMembers"))) { #optional property not found
            $GroupMembers = $null
        } else {
            $GroupMembers = $JsonParameters.PSobject.Properties["GroupMembers"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsDynamicMembership"))) { #optional property not found
            $IsDynamicMembership = $null
        } else {
            $IsDynamicMembership = $JsonParameters.PSobject.Properties["IsDynamicMembership"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DynamicMembershipRules"))) { #optional property not found
            $DynamicMembershipRules = $null
        } else {
            $DynamicMembershipRules = $JsonParameters.PSobject.Properties["DynamicMembershipRules"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnabledSubscribe"))) { #optional property not found
            $EnabledSubscribe = $null
        } else {
            $EnabledSubscribe = $JsonParameters.PSobject.Properties["EnabledSubscribe"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalEnabledSubscribe"))) { #optional property not found
            $OriginalEnabledSubscribe = $null
        } else {
            $OriginalEnabledSubscribe = $JsonParameters.PSobject.Properties["OriginalEnabledSubscribe"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnabledOutsideSender"))) { #optional property not found
            $EnabledOutsideSender = $null
        } else {
            $EnabledOutsideSender = $JsonParameters.PSobject.Properties["EnabledOutsideSender"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalEnabledOutsideSender"))) { #optional property not found
            $OriginalEnabledOutsideSender = $null
        } else {
            $OriginalEnabledOutsideSender = $JsonParameters.PSobject.Properties["OriginalEnabledOutsideSender"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HubSiteActionType"))) { #optional property not found
            $HubSiteActionType = $null
        } else {
            $HubSiteActionType = $JsonParameters.PSobject.Properties["HubSiteActionType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssociateHubSiteId"))) { #optional property not found
            $AssociateHubSiteId = $null
        } else {
            $AssociateHubSiteId = $JsonParameters.PSobject.Properties["AssociateHubSiteId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssociateHubSiteTitle"))) { #optional property not found
            $AssociateHubSiteTitle = $null
        } else {
            $AssociateHubSiteTitle = $JsonParameters.PSobject.Properties["AssociateHubSiteTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Classification"))) { #optional property not found
            $Classification = $null
        } else {
            $Classification = $JsonParameters.PSobject.Properties["Classification"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalClassification"))) { #optional property not found
            $OriginalClassification = $null
        } else {
            $OriginalClassification = $JsonParameters.PSobject.Properties["OriginalClassification"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Sensitivity"))) { #optional property not found
            $Sensitivity = $null
        } else {
            $Sensitivity = $JsonParameters.PSobject.Properties["Sensitivity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalSensitivity"))) { #optional property not found
            $OriginalSensitivity = $null
        } else {
            $OriginalSensitivity = $JsonParameters.PSobject.Properties["OriginalSensitivity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableTeams"))) { #optional property not found
            $EnableTeams = $null
        } else {
            $EnableTeams = $JsonParameters.PSobject.Properties["EnableTeams"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalEnableTeams"))) { #optional property not found
            $OriginalEnableTeams = $null
        } else {
            $OriginalEnableTeams = $JsonParameters.PSobject.Properties["OriginalEnableTeams"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupMetadatas"))) { #optional property not found
            $GroupMetadatas = $null
        } else {
            $GroupMetadatas = $JsonParameters.PSobject.Properties["GroupMetadatas"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalGroupMetadata"))) { #optional property not found
            $OriginalGroupMetadata = $null
        } else {
            $OriginalGroupMetadata = $JsonParameters.PSobject.Properties["OriginalGroupMetadata"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChangedDynamicGroupType"))) { #optional property not found
            $ChangedDynamicGroupType = $null
        } else {
            $ChangedDynamicGroupType = $JsonParameters.PSobject.Properties["ChangedDynamicGroupType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "YammerGroupInfo"))) { #optional property not found
            $YammerGroupInfo = $null
        } else {
            $YammerGroupInfo = $JsonParameters.PSobject.Properties["YammerGroupInfo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupObjectType"))) { #optional property not found
            $GroupObjectType = $null
        } else {
            $GroupObjectType = $JsonParameters.PSobject.Properties["GroupObjectType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NetworkId"))) { #optional property not found
            $NetworkId = $null
        } else {
            $NetworkId = $JsonParameters.PSobject.Properties["NetworkId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupObjectId"))) { #optional property not found
            $GroupObjectId = $null
        } else {
            $GroupObjectId = $JsonParameters.PSobject.Properties["GroupObjectId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableTeamCollaboration"))) { #optional property not found
            $EnableTeamCollaboration = $null
        } else {
            $EnableTeamCollaboration = $JsonParameters.PSobject.Properties["EnableTeamCollaboration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TimeZoneSettings"))) { #optional property not found
            $TimeZoneSettings = $null
        } else {
            $TimeZoneSettings = $JsonParameters.PSobject.Properties["TimeZoneSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalTimeZoneSettings"))) { #optional property not found
            $OriginalTimeZoneSettings = $null
        } else {
            $OriginalTimeZoneSettings = $JsonParameters.PSobject.Properties["OriginalTimeZoneSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LocaleSettings"))) { #optional property not found
            $LocaleSettings = $null
        } else {
            $LocaleSettings = $JsonParameters.PSobject.Properties["LocaleSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalLocaleSettings"))) { #optional property not found
            $OriginalLocaleSettings = $null
        } else {
            $OriginalLocaleSettings = $JsonParameters.PSobject.Properties["OriginalLocaleSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceId"))) { #optional property not found
            $ServiceId = $null
        } else {
            $ServiceId = $JsonParameters.PSobject.Properties["ServiceId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Summary"))) { #optional property not found
            $Summary = $null
        } else {
            $Summary = $JsonParameters.PSobject.Properties["Summary"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NotesToApprovers"))) { #optional property not found
            $NotesToApprovers = $null
        } else {
            $NotesToApprovers = $JsonParameters.PSobject.Properties["NotesToApprovers"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "QuestionnaireId"))) { #optional property not found
            $QuestionnaireId = $null
        } else {
            $QuestionnaireId = $JsonParameters.PSobject.Properties["QuestionnaireId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "QuestionnaireResponse"))) { #optional property not found
            $QuestionnaireResponse = $null
        } else {
            $QuestionnaireResponse = $JsonParameters.PSobject.Properties["QuestionnaireResponse"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadatas"))) { #optional property not found
            $Metadatas = $null
        } else {
            $Metadatas = $JsonParameters.PSobject.Properties["Metadatas"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TicketNumber"))) { #optional property not found
            $TicketNumber = $null
        } else {
            $TicketNumber = $JsonParameters.PSobject.Properties["TicketNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TypeDescription"))) { #optional property not found
            $TypeDescription = $null
        } else {
            $TypeDescription = $JsonParameters.PSobject.Properties["TypeDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Requester"))) { #optional property not found
            $Requester = $null
        } else {
            $Requester = $JsonParameters.PSobject.Properties["Requester"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequesterLoginName"))) { #optional property not found
            $RequesterLoginName = $null
        } else {
            $RequesterLoginName = $JsonParameters.PSobject.Properties["RequesterLoginName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProgressStatus"))) { #optional property not found
            $ProgressStatus = $null
        } else {
            $ProgressStatus = $JsonParameters.PSobject.Properties["ProgressStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProgressStatusDescription"))) { #optional property not found
            $ProgressStatusDescription = $null
        } else {
            $ProgressStatusDescription = $JsonParameters.PSobject.Properties["ProgressStatusDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SubmittedTime"))) { #optional property not found
            $SubmittedTime = $null
        } else {
            $SubmittedTime = $JsonParameters.PSobject.Properties["SubmittedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastUpdated"))) { #optional property not found
            $LastUpdated = $null
        } else {
            $LastUpdated = $JsonParameters.PSobject.Properties["LastUpdated"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreatedTime"))) { #optional property not found
            $CreatedTime = $null
        } else {
            $CreatedTime = $JsonParameters.PSobject.Properties["CreatedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssignTo"))) { #optional property not found
            $AssignTo = $null
        } else {
            $AssignTo = $JsonParameters.PSobject.Properties["AssignTo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FullPath"))) { #optional property not found
            $FullPath = $null
        } else {
            $FullPath = $JsonParameters.PSobject.Properties["FullPath"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ApprovalStageName"))) { #optional property not found
            $ApprovalStageName = $null
        } else {
            $ApprovalStageName = $JsonParameters.PSobject.Properties["ApprovalStageName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Participants"))) { #optional property not found
            $Participants = $null
        } else {
            $Participants = $JsonParameters.PSobject.Properties["Participants"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectID"))) { #optional property not found
            $ObjectID = $null
        } else {
            $ObjectID = $JsonParameters.PSobject.Properties["ObjectID"].value
        }

        $PSO = [PSCustomObject]@{
            "GroupId" = ${GroupId}
            "GroupEmail" = ${GroupEmail}
            "GroupName" = ${GroupName}
            "OriginalGroupName" = ${OriginalGroupName}
            "GroupDescription" = ${GroupDescription}
            "OriginalGroupDescription" = ${OriginalGroupDescription}
            "OriginalYammerGroupInfo" = ${OriginalYammerGroupInfo}
            "PrimaryContact" = ${PrimaryContact}
            "OriginalPrimaryContact" = ${OriginalPrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "OriginalSecondaryContact" = ${OriginalSecondaryContact}
            "GroupOwners" = ${GroupOwners}
            "GroupMembers" = ${GroupMembers}
            "IsDynamicMembership" = ${IsDynamicMembership}
            "DynamicMembershipRules" = ${DynamicMembershipRules}
            "EnabledSubscribe" = ${EnabledSubscribe}
            "OriginalEnabledSubscribe" = ${OriginalEnabledSubscribe}
            "EnabledOutsideSender" = ${EnabledOutsideSender}
            "OriginalEnabledOutsideSender" = ${OriginalEnabledOutsideSender}
            "HubSiteActionType" = ${HubSiteActionType}
            "AssociateHubSiteId" = ${AssociateHubSiteId}
            "AssociateHubSiteTitle" = ${AssociateHubSiteTitle}
            "Classification" = ${Classification}
            "OriginalClassification" = ${OriginalClassification}
            "Sensitivity" = ${Sensitivity}
            "OriginalSensitivity" = ${OriginalSensitivity}
            "EnableTeams" = ${EnableTeams}
            "OriginalEnableTeams" = ${OriginalEnableTeams}
            "GroupMetadatas" = ${GroupMetadatas}
            "OriginalGroupMetadata" = ${OriginalGroupMetadata}
            "ChangedDynamicGroupType" = ${ChangedDynamicGroupType}
            "YammerGroupInfo" = ${YammerGroupInfo}
            "GroupObjectType" = ${GroupObjectType}
            "NetworkId" = ${NetworkId}
            "GroupObjectId" = ${GroupObjectId}
            "EnableTeamCollaboration" = ${EnableTeamCollaboration}
            "TimeZoneSettings" = ${TimeZoneSettings}
            "OriginalTimeZoneSettings" = ${OriginalTimeZoneSettings}
            "LocaleSettings" = ${LocaleSettings}
            "OriginalLocaleSettings" = ${OriginalLocaleSettings}
            "Id" = ${Id}
            "ServiceId" = ${ServiceId}
            "Summary" = ${Summary}
            "NotesToApprovers" = ${NotesToApprovers}
            "QuestionnaireId" = ${QuestionnaireId}
            "QuestionnaireResponse" = ${QuestionnaireResponse}
            "Metadatas" = ${Metadatas}
            "TicketNumber" = ${TicketNumber}
            "Type" = ${Type}
            "TypeDescription" = ${TypeDescription}
            "Requester" = ${Requester}
            "RequesterLoginName" = ${RequesterLoginName}
            "Status" = ${Status}
            "ProgressStatus" = ${ProgressStatus}
            "ProgressStatusDescription" = ${ProgressStatusDescription}
            "SubmittedTime" = ${SubmittedTime}
            "LastUpdated" = ${LastUpdated}
            "CreatedTime" = ${CreatedTime}
            "AssignTo" = ${AssignTo}
            "FullPath" = ${FullPath}
            "ApprovalStageName" = ${ApprovalStageName}
            "Participants" = ${Participants}
            "ObjectID" = ${ObjectID}
        }

        return $PSO
    }

}

