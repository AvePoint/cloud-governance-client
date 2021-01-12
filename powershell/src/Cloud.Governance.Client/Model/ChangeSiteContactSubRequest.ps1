#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeSiteContactSubRequest<PSCustomObject>
#>

function New-ChangeSiteContactSubRequest {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${AssignTo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Reason},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AdminContactSettings}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeSiteContactSubRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "AssignTo" = ${AssignTo}
            "Reason" = ${Reason}
            "AdminContactSettings" = ${AdminContactSettings}
        }

        return $PSO
    }
}

<#
ChangeSiteContactSubRequest<PSCustomObject>
#>
function ConvertFrom-JsonToChangeSiteContactSubRequest {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeSiteContactSubRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeSiteContactSubRequest
        $AllProperties = $("Id", "AssignTo", "Reason", "Status", "StatusDescription", "AdminContactSettings", "ProgressStatus")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssignTo"))) { #optional property not found
            $AssignTo = $null
        } else {
            $AssignTo = $JsonParameters.PSobject.Properties["AssignTo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Reason"))) { #optional property not found
            $Reason = $null
        } else {
            $Reason = $JsonParameters.PSobject.Properties["Reason"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdminContactSettings"))) { #optional property not found
            $AdminContactSettings = $null
        } else {
            $AdminContactSettings = $JsonParameters.PSobject.Properties["AdminContactSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProgressStatus"))) { #optional property not found
            $ProgressStatus = $null
        } else {
            $ProgressStatus = $JsonParameters.PSobject.Properties["ProgressStatus"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "AssignTo" = ${AssignTo}
            "Reason" = ${Reason}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "AdminContactSettings" = ${AdminContactSettings}
            "ProgressStatus" = ${ProgressStatus}
        }

        return $PSO
    }

}

