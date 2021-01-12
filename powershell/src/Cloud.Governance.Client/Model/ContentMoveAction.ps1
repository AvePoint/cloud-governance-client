#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ContentMoveAction<PSCustomObject>
#>

function New-ContentMoveAction {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ContentMoveAction' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
        }

        return $PSO
    }
}

<#
ContentMoveAction<PSCustomObject>
#>
function ConvertFrom-JsonToContentMoveAction {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ContentMoveAction' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ContentMoveAction
        $AllProperties = $()
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        $PSO = [PSCustomObject]@{
        }

        return $PSO
    }

}

