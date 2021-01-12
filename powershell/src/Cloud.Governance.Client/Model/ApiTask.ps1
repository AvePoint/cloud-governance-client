#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ApiTask<PSCustomObject>
#>

function New-ApiTask {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DynamicProperties},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RequestGuid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StatusDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceTypeDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Comments},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${AllComments},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMessage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${LastModifiedTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TaskType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowReassign},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowEdit},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DynamicActions}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ApiTask' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "DynamicProperties" = ${DynamicProperties}
            "Id" = ${Id}
            "Title" = ${Title}
            "Description" = ${Description}
            "RequestGuid" = ${RequestGuid}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "Comments" = ${Comments}
            "AllComments" = ${AllComments}
            "ErrorMessage" = ${ErrorMessage}
            "LastModifiedTime" = ${LastModifiedTime}
            "TaskType" = ${TaskType}
            "AllowReassign" = ${AllowReassign}
            "AllowEdit" = ${AllowEdit}
            "DynamicActions" = ${DynamicActions}
        }

        return $PSO
    }
}

<#
ApiTask<PSCustomObject>
#>
function ConvertFrom-JsonToApiTask {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ApiTask' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ApiTask
        $AllProperties = $("DynamicProperties", "Id", "Title", "Description", "RequestGuid", "Status", "StatusDescription", "ServiceType", "ServiceTypeDescription", "Comments", "AllComments", "ErrorMessage", "LastModifiedTime", "TaskType", "AllowReassign", "AllowEdit", "DynamicActions")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DynamicProperties"))) { #optional property not found
            $DynamicProperties = $null
        } else {
            $DynamicProperties = $JsonParameters.PSobject.Properties["DynamicProperties"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Title"))) { #optional property not found
            $Title = $null
        } else {
            $Title = $JsonParameters.PSobject.Properties["Title"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestGuid"))) { #optional property not found
            $RequestGuid = $null
        } else {
            $RequestGuid = $JsonParameters.PSobject.Properties["RequestGuid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StatusDescription"))) { #optional property not found
            $StatusDescription = $null
        } else {
            $StatusDescription = $JsonParameters.PSobject.Properties["StatusDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceType"))) { #optional property not found
            $ServiceType = $null
        } else {
            $ServiceType = $JsonParameters.PSobject.Properties["ServiceType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceTypeDescription"))) { #optional property not found
            $ServiceTypeDescription = $null
        } else {
            $ServiceTypeDescription = $JsonParameters.PSobject.Properties["ServiceTypeDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Comments"))) { #optional property not found
            $Comments = $null
        } else {
            $Comments = $JsonParameters.PSobject.Properties["Comments"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllComments"))) { #optional property not found
            $AllComments = $null
        } else {
            $AllComments = $JsonParameters.PSobject.Properties["AllComments"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ErrorMessage"))) { #optional property not found
            $ErrorMessage = $null
        } else {
            $ErrorMessage = $JsonParameters.PSobject.Properties["ErrorMessage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastModifiedTime"))) { #optional property not found
            $LastModifiedTime = $null
        } else {
            $LastModifiedTime = $JsonParameters.PSobject.Properties["LastModifiedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TaskType"))) { #optional property not found
            $TaskType = $null
        } else {
            $TaskType = $JsonParameters.PSobject.Properties["TaskType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowReassign"))) { #optional property not found
            $AllowReassign = $null
        } else {
            $AllowReassign = $JsonParameters.PSobject.Properties["AllowReassign"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowEdit"))) { #optional property not found
            $AllowEdit = $null
        } else {
            $AllowEdit = $JsonParameters.PSobject.Properties["AllowEdit"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DynamicActions"))) { #optional property not found
            $DynamicActions = $null
        } else {
            $DynamicActions = $JsonParameters.PSobject.Properties["DynamicActions"].value
        }

        $PSO = [PSCustomObject]@{
            "DynamicProperties" = ${DynamicProperties}
            "Id" = ${Id}
            "Title" = ${Title}
            "Description" = ${Description}
            "RequestGuid" = ${RequestGuid}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "Comments" = ${Comments}
            "AllComments" = ${AllComments}
            "ErrorMessage" = ${ErrorMessage}
            "LastModifiedTime" = ${LastModifiedTime}
            "TaskType" = ${TaskType}
            "AllowReassign" = ${AllowReassign}
            "AllowEdit" = ${AllowEdit}
            "DynamicActions" = ${DynamicActions}
        }

        return $PSO
    }

}

