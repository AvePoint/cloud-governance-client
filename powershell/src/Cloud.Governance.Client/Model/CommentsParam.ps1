#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CommentsParam<PSCustomObject>
#>

function New-CommentsParam {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Comments}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CommentsParam' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Comments" = ${Comments}
        }

        return $PSO
    }
}

<#
CommentsParam<PSCustomObject>
#>
function ConvertFrom-JsonToCommentsParam {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CommentsParam' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CommentsParam
        $AllProperties = $("Comments")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Comments"))) { #optional property not found
            $Comments = $null
        } else {
            $Comments = $JsonParameters.PSobject.Properties["Comments"].value
        }

        $PSO = [PSCustomObject]@{
            "Comments" = ${Comments}
        }

        return $PSO
    }

}

