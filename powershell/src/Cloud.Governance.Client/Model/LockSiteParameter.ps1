#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
LockSiteParameter<PSCustomObject>
#>

function New-LockSiteParameter {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LockType} = "NoAccess",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Workspace}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => LockSiteParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "LockType" = ${LockType}
            "Workspace" = ${Workspace}
        }

        return $PSO
    }
}

<#
LockSiteParameter<PSCustomObject>
#>
function ConvertFrom-JsonToLockSiteParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => LockSiteParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in LockSiteParameter
        $AllProperties = $("LockType", "Workspace")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LockType"))) { #optional property not found
            $LockType = $null
        } else {
            $LockType = $JsonParameters.PSobject.Properties["LockType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Workspace"))) { #optional property not found
            $Workspace = $null
        } else {
            $Workspace = $JsonParameters.PSobject.Properties["Workspace"].value
        }

        $PSO = [PSCustomObject]@{
            "LockType" = ${LockType}
            "Workspace" = ${Workspace}
        }

        return $PSO
    }

}

