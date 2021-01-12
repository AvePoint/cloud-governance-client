#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
AllRequestList<PSCustomObject>
#>

function New-AllRequestList {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceTypeDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TicketNumber},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Summary},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Requester},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RequesterDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DetailStatus},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DetailStatusDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ProgressStatus},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ProgressStatusDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${Modified},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssignTo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssignToDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceAdmin},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CreatedTime}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => AllRequestList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "ServiceId" = ${ServiceId}
            "ServiceName" = ${ServiceName}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "TicketNumber" = ${TicketNumber}
            "Summary" = ${Summary}
            "Requester" = ${Requester}
            "RequesterDisplayName" = ${RequesterDisplayName}
            "DetailStatus" = ${DetailStatus}
            "DetailStatusDescription" = ${DetailStatusDescription}
            "ProgressStatus" = ${ProgressStatus}
            "ProgressStatusDescription" = ${ProgressStatusDescription}
            "Modified" = ${Modified}
            "AssignTo" = ${AssignTo}
            "AssignToDisplayName" = ${AssignToDisplayName}
            "ServiceAdmin" = ${ServiceAdmin}
            "ObjectUrl" = ${ObjectUrl}
            "CreatedTime" = ${CreatedTime}
        }

        return $PSO
    }
}

<#
AllRequestList<PSCustomObject>
#>
function ConvertFrom-JsonToAllRequestList {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => AllRequestList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in AllRequestList
        $AllProperties = $("Id", "ServiceId", "ServiceName", "ServiceType", "ServiceTypeDescription", "TicketNumber", "Summary", "Requester", "RequesterDisplayName", "DetailStatus", "DetailStatusDescription", "ProgressStatus", "ProgressStatusDescription", "Modified", "AssignTo", "AssignToDisplayName", "ServiceAdmin", "ObjectUrl", "CreatedTime")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceName"))) { #optional property not found
            $ServiceName = $null
        } else {
            $ServiceName = $JsonParameters.PSobject.Properties["ServiceName"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TicketNumber"))) { #optional property not found
            $TicketNumber = $null
        } else {
            $TicketNumber = $JsonParameters.PSobject.Properties["TicketNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Summary"))) { #optional property not found
            $Summary = $null
        } else {
            $Summary = $JsonParameters.PSobject.Properties["Summary"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Requester"))) { #optional property not found
            $Requester = $null
        } else {
            $Requester = $JsonParameters.PSobject.Properties["Requester"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequesterDisplayName"))) { #optional property not found
            $RequesterDisplayName = $null
        } else {
            $RequesterDisplayName = $JsonParameters.PSobject.Properties["RequesterDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DetailStatus"))) { #optional property not found
            $DetailStatus = $null
        } else {
            $DetailStatus = $JsonParameters.PSobject.Properties["DetailStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DetailStatusDescription"))) { #optional property not found
            $DetailStatusDescription = $null
        } else {
            $DetailStatusDescription = $JsonParameters.PSobject.Properties["DetailStatusDescription"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Modified"))) { #optional property not found
            $Modified = $null
        } else {
            $Modified = $JsonParameters.PSobject.Properties["Modified"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssignTo"))) { #optional property not found
            $AssignTo = $null
        } else {
            $AssignTo = $JsonParameters.PSobject.Properties["AssignTo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssignToDisplayName"))) { #optional property not found
            $AssignToDisplayName = $null
        } else {
            $AssignToDisplayName = $JsonParameters.PSobject.Properties["AssignToDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceAdmin"))) { #optional property not found
            $ServiceAdmin = $null
        } else {
            $ServiceAdmin = $JsonParameters.PSobject.Properties["ServiceAdmin"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectUrl"))) { #optional property not found
            $ObjectUrl = $null
        } else {
            $ObjectUrl = $JsonParameters.PSobject.Properties["ObjectUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreatedTime"))) { #optional property not found
            $CreatedTime = $null
        } else {
            $CreatedTime = $JsonParameters.PSobject.Properties["CreatedTime"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "ServiceId" = ${ServiceId}
            "ServiceName" = ${ServiceName}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "TicketNumber" = ${TicketNumber}
            "Summary" = ${Summary}
            "Requester" = ${Requester}
            "RequesterDisplayName" = ${RequesterDisplayName}
            "DetailStatus" = ${DetailStatus}
            "DetailStatusDescription" = ${DetailStatusDescription}
            "ProgressStatus" = ${ProgressStatus}
            "ProgressStatusDescription" = ${ProgressStatusDescription}
            "Modified" = ${Modified}
            "AssignTo" = ${AssignTo}
            "AssignToDisplayName" = ${AssignToDisplayName}
            "ServiceAdmin" = ${ServiceAdmin}
            "ObjectUrl" = ${ObjectUrl}
            "CreatedTime" = ${CreatedTime}
        }

        return $PSO
    }

}

