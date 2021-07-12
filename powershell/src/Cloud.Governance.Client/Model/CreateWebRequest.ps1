#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CreateWebRequest<PSCustomObject>
#>

function New-CreateWebRequest {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${WebLanguage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ParentSiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ParentWebUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
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
        [System.Nullable[Boolean]]
        ${IsOnQuickLaunch} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsOnTopLinkBar} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsInheritance} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DeploymentManagerPlanName},
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
        ${Metadatas}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CreateWebRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$Summary -and $Summary.length -gt 255) {
            throw "invalid value for 'Summary', the character length must be smaller than or equal to 255."
        }

        if (!$NotesToApprovers -and $NotesToApprovers.length -gt 1000) {
            throw "invalid value for 'NotesToApprovers', the character length must be smaller than or equal to 1000."
        }

        
        $PSO = [PSCustomObject]@{
            "WebName" = ${WebName}
            "WebTitle" = ${WebTitle}
            "WebDescription" = ${WebDescription}
            "WebLanguage" = ${WebLanguage}
            "WebTemplate" = ${WebTemplate}
            "ParentSiteUrl" = ${ParentSiteUrl}
            "ParentWebUrl" = ${ParentWebUrl}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "UserPermissions" = ${UserPermissions}
            "GroupPermissions" = ${GroupPermissions}
            "YammerGroupSettings" = ${YammerGroupSettings}
            "IsOnQuickLaunch" = ${IsOnQuickLaunch}
            "IsOnTopLinkBar" = ${IsOnTopLinkBar}
            "IsInheritance" = ${IsInheritance}
            "DeploymentManagerPlanName" = ${DeploymentManagerPlanName}
            "Id" = ${Id}
            "ServiceId" = ${ServiceId}
            "Summary" = ${Summary}
            "NotesToApprovers" = ${NotesToApprovers}
            "QuestionnaireId" = ${QuestionnaireId}
            "Metadatas" = ${Metadatas}
        }

        return $PSO
    }
}

<#
CreateWebRequest<PSCustomObject>
#>
function ConvertFrom-JsonToCreateWebRequest {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CreateWebRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CreateWebRequest
        $AllProperties = $("WebName", "WebTitle", "WebDescription", "WebLanguage", "WebTemplate", "ParentSiteUrl", "ParentWebUrl", "PrimaryContact", "SecondaryContact", "UserPermissions", "GroupPermissions", "YammerGroupSettings", "IsOnQuickLaunch", "IsOnTopLinkBar", "IsInheritance", "DeploymentManagerPlanName", "Id", "ServiceId", "Summary", "NotesToApprovers", "QuestionnaireId", "Metadatas", "TicketNumber", "Type", "TypeDescription", "Requester", "RequesterLoginName", "Status", "ProgressStatus", "ProgressStatusDescription", "SubmittedTime", "LastUpdated", "CreatedTime", "AssignTo", "FullPath")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebName"))) { #optional property not found
            $WebName = $null
        } else {
            $WebName = $JsonParameters.PSobject.Properties["WebName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebTitle"))) { #optional property not found
            $WebTitle = $null
        } else {
            $WebTitle = $JsonParameters.PSobject.Properties["WebTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebDescription"))) { #optional property not found
            $WebDescription = $null
        } else {
            $WebDescription = $JsonParameters.PSobject.Properties["WebDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebLanguage"))) { #optional property not found
            $WebLanguage = $null
        } else {
            $WebLanguage = $JsonParameters.PSobject.Properties["WebLanguage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebTemplate"))) { #optional property not found
            $WebTemplate = $null
        } else {
            $WebTemplate = $JsonParameters.PSobject.Properties["WebTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ParentSiteUrl"))) { #optional property not found
            $ParentSiteUrl = $null
        } else {
            $ParentSiteUrl = $JsonParameters.PSobject.Properties["ParentSiteUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ParentWebUrl"))) { #optional property not found
            $ParentWebUrl = $null
        } else {
            $ParentWebUrl = $JsonParameters.PSobject.Properties["ParentWebUrl"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsOnQuickLaunch"))) { #optional property not found
            $IsOnQuickLaunch = $null
        } else {
            $IsOnQuickLaunch = $JsonParameters.PSobject.Properties["IsOnQuickLaunch"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsOnTopLinkBar"))) { #optional property not found
            $IsOnTopLinkBar = $null
        } else {
            $IsOnTopLinkBar = $JsonParameters.PSobject.Properties["IsOnTopLinkBar"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsInheritance"))) { #optional property not found
            $IsInheritance = $null
        } else {
            $IsInheritance = $JsonParameters.PSobject.Properties["IsInheritance"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeploymentManagerPlanName"))) { #optional property not found
            $DeploymentManagerPlanName = $null
        } else {
            $DeploymentManagerPlanName = $JsonParameters.PSobject.Properties["DeploymentManagerPlanName"].value
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
            "WebName" = ${WebName}
            "WebTitle" = ${WebTitle}
            "WebDescription" = ${WebDescription}
            "WebLanguage" = ${WebLanguage}
            "WebTemplate" = ${WebTemplate}
            "ParentSiteUrl" = ${ParentSiteUrl}
            "ParentWebUrl" = ${ParentWebUrl}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "UserPermissions" = ${UserPermissions}
            "GroupPermissions" = ${GroupPermissions}
            "YammerGroupSettings" = ${YammerGroupSettings}
            "IsOnQuickLaunch" = ${IsOnQuickLaunch}
            "IsOnTopLinkBar" = ${IsOnTopLinkBar}
            "IsInheritance" = ${IsInheritance}
            "DeploymentManagerPlanName" = ${DeploymentManagerPlanName}
            "Id" = ${Id}
            "ServiceId" = ${ServiceId}
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

