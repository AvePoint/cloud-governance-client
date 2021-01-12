#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ReportActionResult<PSCustomObject>
#>

function New-ReportActionResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Reason},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UrlOrEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ReportActionResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Reason" = ${Reason}
            "UrlOrEmail" = ${UrlOrEmail}
            "Title" = ${Title}
        }

        return $PSO
    }
}

<#
ReportActionResult<PSCustomObject>
#>
function ConvertFrom-JsonToReportActionResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ReportActionResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ReportActionResult
        $AllProperties = $("Reason", "UrlOrEmail", "Title")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Reason"))) { #optional property not found
            $Reason = $null
        } else {
            $Reason = $JsonParameters.PSobject.Properties["Reason"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UrlOrEmail"))) { #optional property not found
            $UrlOrEmail = $null
        } else {
            $UrlOrEmail = $JsonParameters.PSobject.Properties["UrlOrEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Title"))) { #optional property not found
            $Title = $null
        } else {
            $Title = $JsonParameters.PSobject.Properties["Title"].value
        }

        $PSO = [PSCustomObject]@{
            "Reason" = ${Reason}
            "UrlOrEmail" = ${UrlOrEmail}
            "Title" = ${Title}
        }

        return $PSO
    }

}

