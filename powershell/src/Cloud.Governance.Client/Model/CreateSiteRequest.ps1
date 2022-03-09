#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CreateSiteRequest<PSCustomObject>
#>

function New-CreateSiteRequest {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PolicyId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TimeZone} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Language} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Template},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DeploymentManagerPlanName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryAdmin},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${AdditionalAdmins},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteDesign},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TeamSiteDesign},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Classification},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Sensitivity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${HubSiteSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${UserPermissions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${GroupPermissions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${YammerGroupSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeasePeriodSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MultiGeoLocation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${InputTitle},
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
        'Creating PSCustomObject: Cloud.Governance.Client => CreateSiteRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$SiteDescription -and $SiteDescription.length -gt 1024) {
            throw "invalid value for 'SiteDescription', the character length must be smaller than or equal to 1024."
        }

        
        $PSO = [PSCustomObject]@{
            "SiteTitle" = ${SiteTitle}
            "SiteDescription" = ${SiteDescription}
            "SiteUrl" = ${SiteUrl}
            "PolicyId" = ${PolicyId}
            "TimeZone" = ${TimeZone}
            "Language" = ${Language}
            "Template" = ${Template}
            "DeploymentManagerPlanName" = ${DeploymentManagerPlanName}
            "PrimaryAdmin" = ${PrimaryAdmin}
            "AdditionalAdmins" = ${AdditionalAdmins}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "SiteDesign" = ${SiteDesign}
            "TeamSiteDesign" = ${TeamSiteDesign}
            "Classification" = ${Classification}
            "Sensitivity" = ${Sensitivity}
            "HubSiteSettings" = ${HubSiteSettings}
            "UserPermissions" = ${UserPermissions}
            "GroupPermissions" = ${GroupPermissions}
            "YammerGroupSettings" = ${YammerGroupSettings}
            "LeasePeriodSettings" = ${LeasePeriodSettings}
            "MultiGeoLocation" = ${MultiGeoLocation}
            "InputTitle" = ${InputTitle}
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
CreateSiteRequest<PSCustomObject>
#>
function ConvertFrom-JsonToCreateSiteRequest {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CreateSiteRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CreateSiteRequest
        $AllProperties = $("SiteTitle", "SiteDescription", "SiteUrl", "PolicyId", "TimeZone", "Language", "Template", "DeploymentManagerPlanName", "PrimaryAdmin", "AdditionalAdmins", "PrimaryContact", "SecondaryContact", "SiteDesign", "TeamSiteDesign", "Classification", "Sensitivity", "HubSiteSettings", "UserPermissions", "GroupPermissions", "YammerGroupSettings", "LeasePeriodSettings", "MultiGeoLocation", "InputTitle", "Id", "ServiceId", "Summary", "NotesToApprovers", "QuestionnaireId", "QuestionnaireResponse", "Metadatas", "TicketNumber", "Type", "TypeDescription", "Requester", "RequesterLoginName", "Status", "ProgressStatus", "ProgressStatusDescription", "SubmittedTime", "LastUpdated", "CreatedTime", "AssignTo", "FullPath", "ApprovalStageName", "Participants", "ObjectID")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteTitle"))) { #optional property not found
            $SiteTitle = $null
        } else {
            $SiteTitle = $JsonParameters.PSobject.Properties["SiteTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteDescription"))) { #optional property not found
            $SiteDescription = $null
        } else {
            $SiteDescription = $JsonParameters.PSobject.Properties["SiteDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteUrl"))) { #optional property not found
            $SiteUrl = $null
        } else {
            $SiteUrl = $JsonParameters.PSobject.Properties["SiteUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyId"))) { #optional property not found
            $PolicyId = $null
        } else {
            $PolicyId = $JsonParameters.PSobject.Properties["PolicyId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TimeZone"))) { #optional property not found
            $TimeZone = $null
        } else {
            $TimeZone = $JsonParameters.PSobject.Properties["TimeZone"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Language"))) { #optional property not found
            $Language = $null
        } else {
            $Language = $JsonParameters.PSobject.Properties["Language"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Template"))) { #optional property not found
            $Template = $null
        } else {
            $Template = $JsonParameters.PSobject.Properties["Template"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeploymentManagerPlanName"))) { #optional property not found
            $DeploymentManagerPlanName = $null
        } else {
            $DeploymentManagerPlanName = $JsonParameters.PSobject.Properties["DeploymentManagerPlanName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryAdmin"))) { #optional property not found
            $PrimaryAdmin = $null
        } else {
            $PrimaryAdmin = $JsonParameters.PSobject.Properties["PrimaryAdmin"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdditionalAdmins"))) { #optional property not found
            $AdditionalAdmins = $null
        } else {
            $AdditionalAdmins = $JsonParameters.PSobject.Properties["AdditionalAdmins"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteDesign"))) { #optional property not found
            $SiteDesign = $null
        } else {
            $SiteDesign = $JsonParameters.PSobject.Properties["SiteDesign"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TeamSiteDesign"))) { #optional property not found
            $TeamSiteDesign = $null
        } else {
            $TeamSiteDesign = $JsonParameters.PSobject.Properties["TeamSiteDesign"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HubSiteSettings"))) { #optional property not found
            $HubSiteSettings = $null
        } else {
            $HubSiteSettings = $JsonParameters.PSobject.Properties["HubSiteSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserPermissions"))) { #optional property not found
            $UserPermissions = $null
        } else {
            $UserPermissions = $JsonParameters.PSobject.Properties["UserPermissions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupPermissions"))) { #optional property not found
            $GroupPermissions = $null
        } else {
            $GroupPermissions = $JsonParameters.PSobject.Properties["GroupPermissions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "YammerGroupSettings"))) { #optional property not found
            $YammerGroupSettings = $null
        } else {
            $YammerGroupSettings = $JsonParameters.PSobject.Properties["YammerGroupSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeasePeriodSettings"))) { #optional property not found
            $LeasePeriodSettings = $null
        } else {
            $LeasePeriodSettings = $JsonParameters.PSobject.Properties["LeasePeriodSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MultiGeoLocation"))) { #optional property not found
            $MultiGeoLocation = $null
        } else {
            $MultiGeoLocation = $JsonParameters.PSobject.Properties["MultiGeoLocation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InputTitle"))) { #optional property not found
            $InputTitle = $null
        } else {
            $InputTitle = $JsonParameters.PSobject.Properties["InputTitle"].value
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
            "SiteTitle" = ${SiteTitle}
            "SiteDescription" = ${SiteDescription}
            "SiteUrl" = ${SiteUrl}
            "PolicyId" = ${PolicyId}
            "TimeZone" = ${TimeZone}
            "Language" = ${Language}
            "Template" = ${Template}
            "DeploymentManagerPlanName" = ${DeploymentManagerPlanName}
            "PrimaryAdmin" = ${PrimaryAdmin}
            "AdditionalAdmins" = ${AdditionalAdmins}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "SiteDesign" = ${SiteDesign}
            "TeamSiteDesign" = ${TeamSiteDesign}
            "Classification" = ${Classification}
            "Sensitivity" = ${Sensitivity}
            "HubSiteSettings" = ${HubSiteSettings}
            "UserPermissions" = ${UserPermissions}
            "GroupPermissions" = ${GroupPermissions}
            "YammerGroupSettings" = ${YammerGroupSettings}
            "LeasePeriodSettings" = ${LeasePeriodSettings}
            "MultiGeoLocation" = ${MultiGeoLocation}
            "InputTitle" = ${InputTitle}
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

