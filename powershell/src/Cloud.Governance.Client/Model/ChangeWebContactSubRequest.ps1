#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeWebContactSubRequest<PSCustomObject>
#>

function New-ChangeWebContactSubRequest {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AssignTo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Reason},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StatusDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ContactChangeSettings}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeWebContactSubRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "AssignTo" = ${AssignTo}
            "Reason" = ${Reason}
            "StatusDescription" = ${StatusDescription}
            "ContactChangeSettings" = ${ContactChangeSettings}
        }

        return $PSO
    }
}

<#
ChangeWebContactSubRequest<PSCustomObject>
#>
function ConvertFrom-JsonToChangeWebContactSubRequest {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeWebContactSubRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeWebContactSubRequest
        $AllProperties = $("Id", "AssignTo", "Reason", "Status", "StatusDescription", "ProgressStatus", "ContactChangeSettings")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProgressStatus"))) { #optional property not found
            $ProgressStatus = $null
        } else {
            $ProgressStatus = $JsonParameters.PSobject.Properties["ProgressStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ContactChangeSettings"))) { #optional property not found
            $ContactChangeSettings = $null
        } else {
            $ContactChangeSettings = $JsonParameters.PSobject.Properties["ContactChangeSettings"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "AssignTo" = ${AssignTo}
            "Reason" = ${Reason}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "ProgressStatus" = ${ProgressStatus}
            "ContactChangeSettings" = ${ContactChangeSettings}
        }

        return $PSO
    }

}

