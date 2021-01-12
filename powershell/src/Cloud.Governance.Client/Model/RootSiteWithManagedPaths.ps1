#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
RootSiteWithManagedPaths<PSCustomObject>
#>

function New-RootSiteWithManagedPaths {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RootSite},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${ManagedPaths}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => RootSiteWithManagedPaths' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "RootSite" = ${RootSite}
            "ManagedPaths" = ${ManagedPaths}
        }

        return $PSO
    }
}

<#
RootSiteWithManagedPaths<PSCustomObject>
#>
function ConvertFrom-JsonToRootSiteWithManagedPaths {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => RootSiteWithManagedPaths' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in RootSiteWithManagedPaths
        $AllProperties = $("RootSite", "ManagedPaths")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RootSite"))) { #optional property not found
            $RootSite = $null
        } else {
            $RootSite = $JsonParameters.PSobject.Properties["RootSite"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ManagedPaths"))) { #optional property not found
            $ManagedPaths = $null
        } else {
            $ManagedPaths = $JsonParameters.PSobject.Properties["ManagedPaths"].value
        }

        $PSO = [PSCustomObject]@{
            "RootSite" = ${RootSite}
            "ManagedPaths" = ${ManagedPaths}
        }

        return $PSO
    }

}

