#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CreateGroupRequest<PSCustomObject>
#>

function New-CreateGroupRequest {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupIdWithoutPrefixSuffix},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupNameWithoutPrefixSuffix},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Policy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Owners},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Members},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Privacy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Subscribe},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${OutsideSender},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableTeamCollaboration},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Language},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Classification},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Sensitivity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeasePeriodSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TeamsSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AppliedSiteDesignId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableGroupMembershipHidden},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableAssignedMembership},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableDynamicMembership},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TemplateSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DynamicMembershipRules},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MultiGeoLocation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${HubSiteSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${YammerGroupInfo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Department},
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
        ${Metadatas}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CreateGroupRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$Summary -and $Summary.length -gt 255) {
            throw "invalid value for 'Summary', the character length must be smaller than or equal to 255."
        }

        if (!$NotesToApprovers -and $NotesToApprovers.length -gt 1000) {
            throw "invalid value for 'NotesToApprovers', the character length must be smaller than or equal to 1000."
        }

        
        $PSO = [PSCustomObject]@{
            "GroupType" = ${GroupType}
            "GroupId" = ${GroupId}
            "GroupIdWithoutPrefixSuffix" = ${GroupIdWithoutPrefixSuffix}
            "GroupName" = ${GroupName}
            "GroupNameWithoutPrefixSuffix" = ${GroupNameWithoutPrefixSuffix}
            "Policy" = ${Policy}
            "GroupDescription" = ${GroupDescription}
            "Owners" = ${Owners}
            "Members" = ${Members}
            "Privacy" = ${Privacy}
            "Subscribe" = ${Subscribe}
            "OutsideSender" = ${OutsideSender}
            "EnableTeamCollaboration" = ${EnableTeamCollaboration}
            "Language" = ${Language}
            "Classification" = ${Classification}
            "Sensitivity" = ${Sensitivity}
            "LeasePeriodSettings" = ${LeasePeriodSettings}
            "TeamsSettings" = ${TeamsSettings}
            "AppliedSiteDesignId" = ${AppliedSiteDesignId}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "EnableGroupMembershipHidden" = ${EnableGroupMembershipHidden}
            "EnableAssignedMembership" = ${EnableAssignedMembership}
            "EnableDynamicMembership" = ${EnableDynamicMembership}
            "TemplateSettings" = ${TemplateSettings}
            "DynamicMembershipRules" = ${DynamicMembershipRules}
            "MultiGeoLocation" = ${MultiGeoLocation}
            "HubSiteSettings" = ${HubSiteSettings}
            "YammerGroupInfo" = ${YammerGroupInfo}
            "Id" = ${Id}
            "ServiceId" = ${ServiceId}
            "Department" = ${Department}
            "Summary" = ${Summary}
            "NotesToApprovers" = ${NotesToApprovers}
            "QuestionnaireId" = ${QuestionnaireId}
            "Metadatas" = ${Metadatas}
        }

        return $PSO
    }
}

<#
CreateGroupRequest<PSCustomObject>
#>
function ConvertFrom-JsonToCreateGroupRequest {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CreateGroupRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CreateGroupRequest
        $AllProperties = $("GroupType", "GroupId", "GroupIdWithoutPrefixSuffix", "GroupName", "GroupNameWithoutPrefixSuffix", "GroupEmail", "Policy", "GroupDescription", "Owners", "Members", "Privacy", "Subscribe", "OutsideSender", "EnableTeamCollaboration", "Language", "Classification", "Sensitivity", "Links", "LeasePeriodSettings", "TeamsSettings", "AppliedSiteDesignId", "PrimaryContact", "SecondaryContact", "EnableGroupMembershipHidden", "EnableAssignedMembership", "EnableDynamicMembership", "TemplateSettings", "DynamicMembershipRules", "MultiGeoLocation", "HubSiteSettings", "YammerGroupInfo", "Id", "ServiceId", "Department", "Summary", "NotesToApprovers", "QuestionnaireId", "Metadatas", "TicketNumber", "Type", "TypeDescription", "Requester", "RequesterLoginName", "Status", "ProgressStatus", "ProgressStatusDescription", "SubmittedTime", "LastUpdated", "CreatedTime", "AssignTo", "FullPath")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupType"))) { #optional property not found
            $GroupType = $null
        } else {
            $GroupType = $JsonParameters.PSobject.Properties["GroupType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupId"))) { #optional property not found
            $GroupId = $null
        } else {
            $GroupId = $JsonParameters.PSobject.Properties["GroupId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupIdWithoutPrefixSuffix"))) { #optional property not found
            $GroupIdWithoutPrefixSuffix = $null
        } else {
            $GroupIdWithoutPrefixSuffix = $JsonParameters.PSobject.Properties["GroupIdWithoutPrefixSuffix"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupName"))) { #optional property not found
            $GroupName = $null
        } else {
            $GroupName = $JsonParameters.PSobject.Properties["GroupName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupNameWithoutPrefixSuffix"))) { #optional property not found
            $GroupNameWithoutPrefixSuffix = $null
        } else {
            $GroupNameWithoutPrefixSuffix = $JsonParameters.PSobject.Properties["GroupNameWithoutPrefixSuffix"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupEmail"))) { #optional property not found
            $GroupEmail = $null
        } else {
            $GroupEmail = $JsonParameters.PSobject.Properties["GroupEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Policy"))) { #optional property not found
            $Policy = $null
        } else {
            $Policy = $JsonParameters.PSobject.Properties["Policy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupDescription"))) { #optional property not found
            $GroupDescription = $null
        } else {
            $GroupDescription = $JsonParameters.PSobject.Properties["GroupDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Owners"))) { #optional property not found
            $Owners = $null
        } else {
            $Owners = $JsonParameters.PSobject.Properties["Owners"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Members"))) { #optional property not found
            $Members = $null
        } else {
            $Members = $JsonParameters.PSobject.Properties["Members"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Privacy"))) { #optional property not found
            $Privacy = $null
        } else {
            $Privacy = $JsonParameters.PSobject.Properties["Privacy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Subscribe"))) { #optional property not found
            $Subscribe = $null
        } else {
            $Subscribe = $JsonParameters.PSobject.Properties["Subscribe"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OutsideSender"))) { #optional property not found
            $OutsideSender = $null
        } else {
            $OutsideSender = $JsonParameters.PSobject.Properties["OutsideSender"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableTeamCollaboration"))) { #optional property not found
            $EnableTeamCollaboration = $null
        } else {
            $EnableTeamCollaboration = $JsonParameters.PSobject.Properties["EnableTeamCollaboration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Language"))) { #optional property not found
            $Language = $null
        } else {
            $Language = $JsonParameters.PSobject.Properties["Language"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Classification"))) { #optional property not found
            $Classification = $null
        } else {
            $Classification = $JsonParameters.PSobject.Properties["Classification"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Sensitivity"))) { #optional property not found
            $Sensitivity = $null
        } else {
            $Sensitivity = $JsonParameters.PSobject.Properties["Sensitivity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Links"))) { #optional property not found
            $Links = $null
        } else {
            $Links = $JsonParameters.PSobject.Properties["Links"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeasePeriodSettings"))) { #optional property not found
            $LeasePeriodSettings = $null
        } else {
            $LeasePeriodSettings = $JsonParameters.PSobject.Properties["LeasePeriodSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TeamsSettings"))) { #optional property not found
            $TeamsSettings = $null
        } else {
            $TeamsSettings = $JsonParameters.PSobject.Properties["TeamsSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AppliedSiteDesignId"))) { #optional property not found
            $AppliedSiteDesignId = $null
        } else {
            $AppliedSiteDesignId = $JsonParameters.PSobject.Properties["AppliedSiteDesignId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContact"))) { #optional property not found
            $PrimaryContact = $null
        } else {
            $PrimaryContact = $JsonParameters.PSobject.Properties["PrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContact"))) { #optional property not found
            $SecondaryContact = $null
        } else {
            $SecondaryContact = $JsonParameters.PSobject.Properties["SecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableGroupMembershipHidden"))) { #optional property not found
            $EnableGroupMembershipHidden = $null
        } else {
            $EnableGroupMembershipHidden = $JsonParameters.PSobject.Properties["EnableGroupMembershipHidden"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableAssignedMembership"))) { #optional property not found
            $EnableAssignedMembership = $null
        } else {
            $EnableAssignedMembership = $JsonParameters.PSobject.Properties["EnableAssignedMembership"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableDynamicMembership"))) { #optional property not found
            $EnableDynamicMembership = $null
        } else {
            $EnableDynamicMembership = $JsonParameters.PSobject.Properties["EnableDynamicMembership"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemplateSettings"))) { #optional property not found
            $TemplateSettings = $null
        } else {
            $TemplateSettings = $JsonParameters.PSobject.Properties["TemplateSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DynamicMembershipRules"))) { #optional property not found
            $DynamicMembershipRules = $null
        } else {
            $DynamicMembershipRules = $JsonParameters.PSobject.Properties["DynamicMembershipRules"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MultiGeoLocation"))) { #optional property not found
            $MultiGeoLocation = $null
        } else {
            $MultiGeoLocation = $JsonParameters.PSobject.Properties["MultiGeoLocation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HubSiteSettings"))) { #optional property not found
            $HubSiteSettings = $null
        } else {
            $HubSiteSettings = $JsonParameters.PSobject.Properties["HubSiteSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "YammerGroupInfo"))) { #optional property not found
            $YammerGroupInfo = $null
        } else {
            $YammerGroupInfo = $JsonParameters.PSobject.Properties["YammerGroupInfo"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Department"))) { #optional property not found
            $Department = $null
        } else {
            $Department = $JsonParameters.PSobject.Properties["Department"].value
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

        $PSO = [PSCustomObject]@{
            "GroupType" = ${GroupType}
            "GroupId" = ${GroupId}
            "GroupIdWithoutPrefixSuffix" = ${GroupIdWithoutPrefixSuffix}
            "GroupName" = ${GroupName}
            "GroupNameWithoutPrefixSuffix" = ${GroupNameWithoutPrefixSuffix}
            "GroupEmail" = ${GroupEmail}
            "Policy" = ${Policy}
            "GroupDescription" = ${GroupDescription}
            "Owners" = ${Owners}
            "Members" = ${Members}
            "Privacy" = ${Privacy}
            "Subscribe" = ${Subscribe}
            "OutsideSender" = ${OutsideSender}
            "EnableTeamCollaboration" = ${EnableTeamCollaboration}
            "Language" = ${Language}
            "Classification" = ${Classification}
            "Sensitivity" = ${Sensitivity}
            "Links" = ${Links}
            "LeasePeriodSettings" = ${LeasePeriodSettings}
            "TeamsSettings" = ${TeamsSettings}
            "AppliedSiteDesignId" = ${AppliedSiteDesignId}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "EnableGroupMembershipHidden" = ${EnableGroupMembershipHidden}
            "EnableAssignedMembership" = ${EnableAssignedMembership}
            "EnableDynamicMembership" = ${EnableDynamicMembership}
            "TemplateSettings" = ${TemplateSettings}
            "DynamicMembershipRules" = ${DynamicMembershipRules}
            "MultiGeoLocation" = ${MultiGeoLocation}
            "HubSiteSettings" = ${HubSiteSettings}
            "YammerGroupInfo" = ${YammerGroupInfo}
            "Id" = ${Id}
            "ServiceId" = ${ServiceId}
            "Department" = ${Department}
            "Summary" = ${Summary}
            "NotesToApprovers" = ${NotesToApprovers}
            "QuestionnaireId" = ${QuestionnaireId}
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
        }

        return $PSO
    }

}

