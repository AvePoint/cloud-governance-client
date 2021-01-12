#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
RequestList<PSCustomObject>
#>

function New-RequestList {
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
        [PSCustomObject]
        ${Status},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ProcessStatus},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StatusDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${Modified},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${SubmitStatus},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Assigned},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceAdmin},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnabledCopy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${QuestionnaireId}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => RequestList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "ServiceId" = ${ServiceId}
            "ServiceName" = ${ServiceName}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "TicketNumber" = ${TicketNumber}
            "Summary" = ${Summary}
            "Status" = ${Status}
            "ProcessStatus" = ${ProcessStatus}
            "StatusDescription" = ${StatusDescription}
            "Modified" = ${Modified}
            "SubmitStatus" = ${SubmitStatus}
            "Assigned" = ${Assigned}
            "ServiceAdmin" = ${ServiceAdmin}
            "EnabledCopy" = ${EnabledCopy}
            "QuestionnaireId" = ${QuestionnaireId}
        }

        return $PSO
    }
}

<#
RequestList<PSCustomObject>
#>
function ConvertFrom-JsonToRequestList {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => RequestList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in RequestList
        $AllProperties = $("Id", "ServiceId", "ServiceName", "ServiceType", "ServiceTypeDescription", "TicketNumber", "Summary", "Status", "ProcessStatus", "StatusDescription", "Modified", "SubmitStatus", "Assigned", "ServiceAdmin", "EnabledCopy", "QuestionnaireId")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProcessStatus"))) { #optional property not found
            $ProcessStatus = $null
        } else {
            $ProcessStatus = $JsonParameters.PSobject.Properties["ProcessStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StatusDescription"))) { #optional property not found
            $StatusDescription = $null
        } else {
            $StatusDescription = $JsonParameters.PSobject.Properties["StatusDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Modified"))) { #optional property not found
            $Modified = $null
        } else {
            $Modified = $JsonParameters.PSobject.Properties["Modified"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SubmitStatus"))) { #optional property not found
            $SubmitStatus = $null
        } else {
            $SubmitStatus = $JsonParameters.PSobject.Properties["SubmitStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Assigned"))) { #optional property not found
            $Assigned = $null
        } else {
            $Assigned = $JsonParameters.PSobject.Properties["Assigned"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceAdmin"))) { #optional property not found
            $ServiceAdmin = $null
        } else {
            $ServiceAdmin = $JsonParameters.PSobject.Properties["ServiceAdmin"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnabledCopy"))) { #optional property not found
            $EnabledCopy = $null
        } else {
            $EnabledCopy = $JsonParameters.PSobject.Properties["EnabledCopy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "QuestionnaireId"))) { #optional property not found
            $QuestionnaireId = $null
        } else {
            $QuestionnaireId = $JsonParameters.PSobject.Properties["QuestionnaireId"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "ServiceId" = ${ServiceId}
            "ServiceName" = ${ServiceName}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "TicketNumber" = ${TicketNumber}
            "Summary" = ${Summary}
            "Status" = ${Status}
            "ProcessStatus" = ${ProcessStatus}
            "StatusDescription" = ${StatusDescription}
            "Modified" = ${Modified}
            "SubmitStatus" = ${SubmitStatus}
            "Assigned" = ${Assigned}
            "ServiceAdmin" = ${ServiceAdmin}
            "EnabledCopy" = ${EnabledCopy}
            "QuestionnaireId" = ${QuestionnaireId}
        }

        return $PSO
    }

}

