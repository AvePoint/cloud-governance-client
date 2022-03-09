#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ClonePermissionRequest<PSCustomObject>
#>

function New-ClonePermissionRequest {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Urls},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SourceUser},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TargetUser},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CloneOption} = "Append",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AdditionalCloneOption} = "AddUserToTheSameGroup",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnabledRemoveExplicitPermission} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnabledRemoveUserFromSPGroup} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnabledDeleteUserPermission} = $false,
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
        'Creating PSCustomObject: Cloud.Governance.Client => ClonePermissionRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Urls" = ${Urls}
            "SourceUser" = ${SourceUser}
            "TargetUser" = ${TargetUser}
            "CloneOption" = ${CloneOption}
            "AdditionalCloneOption" = ${AdditionalCloneOption}
            "EnabledRemoveExplicitPermission" = ${EnabledRemoveExplicitPermission}
            "EnabledRemoveUserFromSPGroup" = ${EnabledRemoveUserFromSPGroup}
            "EnabledDeleteUserPermission" = ${EnabledDeleteUserPermission}
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
ClonePermissionRequest<PSCustomObject>
#>
function ConvertFrom-JsonToClonePermissionRequest {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ClonePermissionRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ClonePermissionRequest
        $AllProperties = $("Urls", "SourceUser", "TargetUser", "CloneOption", "AdditionalCloneOption", "EnabledRemoveExplicitPermission", "EnabledRemoveUserFromSPGroup", "EnabledDeleteUserPermission", "Id", "ServiceId", "Summary", "NotesToApprovers", "QuestionnaireId", "QuestionnaireResponse", "Metadatas", "TicketNumber", "Type", "TypeDescription", "Requester", "RequesterLoginName", "Status", "ProgressStatus", "ProgressStatusDescription", "SubmittedTime", "LastUpdated", "CreatedTime", "AssignTo", "FullPath", "ApprovalStageName", "Participants", "ObjectID")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Urls"))) { #optional property not found
            $Urls = $null
        } else {
            $Urls = $JsonParameters.PSobject.Properties["Urls"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SourceUser"))) { #optional property not found
            $SourceUser = $null
        } else {
            $SourceUser = $JsonParameters.PSobject.Properties["SourceUser"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TargetUser"))) { #optional property not found
            $TargetUser = $null
        } else {
            $TargetUser = $JsonParameters.PSobject.Properties["TargetUser"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CloneOption"))) { #optional property not found
            $CloneOption = $null
        } else {
            $CloneOption = $JsonParameters.PSobject.Properties["CloneOption"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdditionalCloneOption"))) { #optional property not found
            $AdditionalCloneOption = $null
        } else {
            $AdditionalCloneOption = $JsonParameters.PSobject.Properties["AdditionalCloneOption"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnabledRemoveExplicitPermission"))) { #optional property not found
            $EnabledRemoveExplicitPermission = $null
        } else {
            $EnabledRemoveExplicitPermission = $JsonParameters.PSobject.Properties["EnabledRemoveExplicitPermission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnabledRemoveUserFromSPGroup"))) { #optional property not found
            $EnabledRemoveUserFromSPGroup = $null
        } else {
            $EnabledRemoveUserFromSPGroup = $JsonParameters.PSobject.Properties["EnabledRemoveUserFromSPGroup"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnabledDeleteUserPermission"))) { #optional property not found
            $EnabledDeleteUserPermission = $null
        } else {
            $EnabledDeleteUserPermission = $JsonParameters.PSobject.Properties["EnabledDeleteUserPermission"].value
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
            "Urls" = ${Urls}
            "SourceUser" = ${SourceUser}
            "TargetUser" = ${TargetUser}
            "CloneOption" = ${CloneOption}
            "AdditionalCloneOption" = ${AdditionalCloneOption}
            "EnabledRemoveExplicitPermission" = ${EnabledRemoveExplicitPermission}
            "EnabledRemoveUserFromSPGroup" = ${EnabledRemoveUserFromSPGroup}
            "EnabledDeleteUserPermission" = ${EnabledDeleteUserPermission}
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

