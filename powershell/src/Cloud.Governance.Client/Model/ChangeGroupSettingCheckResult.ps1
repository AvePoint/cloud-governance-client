#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeGroupSettingCheckResult<PSCustomObject>
#>

function New-ChangeGroupSettingCheckResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableSubscribeMembers},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableOutsideSender},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Classification},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsTeamsEnabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableManageGroupSharing},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableInviteAuthorizedGuestUser},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableInviteGuestUser},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableDynamicMembership},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableTeamCollaboration},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsHubSite},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssociatedHubSiteId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DynamicMembershipRules},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableChangeMembershipType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${YammerGroupInfo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupObjectType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NetworkId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${GroupObjectId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsValid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMessage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MessageCode}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeGroupSettingCheckResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "GroupId" = ${GroupId}
            "GroupName" = ${GroupName}
            "GroupEmail" = ${GroupEmail}
            "GroupDescription" = ${GroupDescription}
            "IsEnableSubscribeMembers" = ${IsEnableSubscribeMembers}
            "IsEnableOutsideSender" = ${IsEnableOutsideSender}
            "Classification" = ${Classification}
            "IsTeamsEnabled" = ${IsTeamsEnabled}
            "EnableManageGroupSharing" = ${EnableManageGroupSharing}
            "EnableInviteAuthorizedGuestUser" = ${EnableInviteAuthorizedGuestUser}
            "EnableInviteGuestUser" = ${EnableInviteGuestUser}
            "EnableDynamicMembership" = ${EnableDynamicMembership}
            "EnableTeamCollaboration" = ${EnableTeamCollaboration}
            "IsHubSite" = ${IsHubSite}
            "AssociatedHubSiteId" = ${AssociatedHubSiteId}
            "DynamicMembershipRules" = ${DynamicMembershipRules}
            "Metadatas" = ${Metadatas}
            "EnableChangeMembershipType" = ${EnableChangeMembershipType}
            "YammerGroupInfo" = ${YammerGroupInfo}
            "GroupObjectType" = ${GroupObjectType}
            "NetworkId" = ${NetworkId}
            "GroupObjectId" = ${GroupObjectId}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }
}

<#
ChangeGroupSettingCheckResult<PSCustomObject>
#>
function ConvertFrom-JsonToChangeGroupSettingCheckResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeGroupSettingCheckResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeGroupSettingCheckResult
        $AllProperties = $("PrimaryContact", "SecondaryContact", "GroupId", "GroupName", "GroupEmail", "GroupDescription", "IsEnableSubscribeMembers", "IsEnableOutsideSender", "Classification", "IsTeamsEnabled", "EnableManageGroupSharing", "EnableInviteAuthorizedGuestUser", "EnableInviteGuestUser", "EnableDynamicMembership", "EnableTeamCollaboration", "IsHubSite", "AssociatedHubSiteId", "DynamicMembershipRules", "Metadatas", "EnableChangeMembershipType", "YammerGroupInfo", "GroupObjectType", "NetworkId", "GroupObjectId", "IsValid", "ErrorMessage", "MessageCode")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupId"))) { #optional property not found
            $GroupId = $null
        } else {
            $GroupId = $JsonParameters.PSobject.Properties["GroupId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupName"))) { #optional property not found
            $GroupName = $null
        } else {
            $GroupName = $JsonParameters.PSobject.Properties["GroupName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupEmail"))) { #optional property not found
            $GroupEmail = $null
        } else {
            $GroupEmail = $JsonParameters.PSobject.Properties["GroupEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupDescription"))) { #optional property not found
            $GroupDescription = $null
        } else {
            $GroupDescription = $JsonParameters.PSobject.Properties["GroupDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableSubscribeMembers"))) { #optional property not found
            $IsEnableSubscribeMembers = $null
        } else {
            $IsEnableSubscribeMembers = $JsonParameters.PSobject.Properties["IsEnableSubscribeMembers"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableOutsideSender"))) { #optional property not found
            $IsEnableOutsideSender = $null
        } else {
            $IsEnableOutsideSender = $JsonParameters.PSobject.Properties["IsEnableOutsideSender"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Classification"))) { #optional property not found
            $Classification = $null
        } else {
            $Classification = $JsonParameters.PSobject.Properties["Classification"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsTeamsEnabled"))) { #optional property not found
            $IsTeamsEnabled = $null
        } else {
            $IsTeamsEnabled = $JsonParameters.PSobject.Properties["IsTeamsEnabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableManageGroupSharing"))) { #optional property not found
            $EnableManageGroupSharing = $null
        } else {
            $EnableManageGroupSharing = $JsonParameters.PSobject.Properties["EnableManageGroupSharing"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableInviteAuthorizedGuestUser"))) { #optional property not found
            $EnableInviteAuthorizedGuestUser = $null
        } else {
            $EnableInviteAuthorizedGuestUser = $JsonParameters.PSobject.Properties["EnableInviteAuthorizedGuestUser"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableInviteGuestUser"))) { #optional property not found
            $EnableInviteGuestUser = $null
        } else {
            $EnableInviteGuestUser = $JsonParameters.PSobject.Properties["EnableInviteGuestUser"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableDynamicMembership"))) { #optional property not found
            $EnableDynamicMembership = $null
        } else {
            $EnableDynamicMembership = $JsonParameters.PSobject.Properties["EnableDynamicMembership"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableTeamCollaboration"))) { #optional property not found
            $EnableTeamCollaboration = $null
        } else {
            $EnableTeamCollaboration = $JsonParameters.PSobject.Properties["EnableTeamCollaboration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsHubSite"))) { #optional property not found
            $IsHubSite = $null
        } else {
            $IsHubSite = $JsonParameters.PSobject.Properties["IsHubSite"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssociatedHubSiteId"))) { #optional property not found
            $AssociatedHubSiteId = $null
        } else {
            $AssociatedHubSiteId = $JsonParameters.PSobject.Properties["AssociatedHubSiteId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DynamicMembershipRules"))) { #optional property not found
            $DynamicMembershipRules = $null
        } else {
            $DynamicMembershipRules = $JsonParameters.PSobject.Properties["DynamicMembershipRules"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadatas"))) { #optional property not found
            $Metadatas = $null
        } else {
            $Metadatas = $JsonParameters.PSobject.Properties["Metadatas"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableChangeMembershipType"))) { #optional property not found
            $EnableChangeMembershipType = $null
        } else {
            $EnableChangeMembershipType = $JsonParameters.PSobject.Properties["EnableChangeMembershipType"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsValid"))) { #optional property not found
            $IsValid = $null
        } else {
            $IsValid = $JsonParameters.PSobject.Properties["IsValid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ErrorMessage"))) { #optional property not found
            $ErrorMessage = $null
        } else {
            $ErrorMessage = $JsonParameters.PSobject.Properties["ErrorMessage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MessageCode"))) { #optional property not found
            $MessageCode = $null
        } else {
            $MessageCode = $JsonParameters.PSobject.Properties["MessageCode"].value
        }

        $PSO = [PSCustomObject]@{
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "GroupId" = ${GroupId}
            "GroupName" = ${GroupName}
            "GroupEmail" = ${GroupEmail}
            "GroupDescription" = ${GroupDescription}
            "IsEnableSubscribeMembers" = ${IsEnableSubscribeMembers}
            "IsEnableOutsideSender" = ${IsEnableOutsideSender}
            "Classification" = ${Classification}
            "IsTeamsEnabled" = ${IsTeamsEnabled}
            "EnableManageGroupSharing" = ${EnableManageGroupSharing}
            "EnableInviteAuthorizedGuestUser" = ${EnableInviteAuthorizedGuestUser}
            "EnableInviteGuestUser" = ${EnableInviteGuestUser}
            "EnableDynamicMembership" = ${EnableDynamicMembership}
            "EnableTeamCollaboration" = ${EnableTeamCollaboration}
            "IsHubSite" = ${IsHubSite}
            "AssociatedHubSiteId" = ${AssociatedHubSiteId}
            "DynamicMembershipRules" = ${DynamicMembershipRules}
            "Metadatas" = ${Metadatas}
            "EnableChangeMembershipType" = ${EnableChangeMembershipType}
            "YammerGroupInfo" = ${YammerGroupInfo}
            "GroupObjectType" = ${GroupObjectType}
            "NetworkId" = ${NetworkId}
            "GroupObjectId" = ${GroupObjectId}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }

}

