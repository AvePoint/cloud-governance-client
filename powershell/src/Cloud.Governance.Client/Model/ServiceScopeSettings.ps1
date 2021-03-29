#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ServiceScopeSettings<PSCustomObject>
#>

function New-ServiceScopeSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SelectedNodes},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AutoPopulateUrlWithSPContext} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AutoPopulateUrlWithSPContextAssignBy} = "BusinessUser"
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ServiceScopeSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "SelectedNodes" = ${SelectedNodes}
            "AutoPopulateUrlWithSPContext" = ${AutoPopulateUrlWithSPContext}
            "AutoPopulateUrlWithSPContextAssignBy" = ${AutoPopulateUrlWithSPContextAssignBy}
        }

        return $PSO
    }
}

<#
ServiceScopeSettings<PSCustomObject>
#>
function ConvertFrom-JsonToServiceScopeSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ServiceScopeSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ServiceScopeSettings
        $AllProperties = $("SelectedNodes", "AutoPopulateUrlWithSPContext", "AutoPopulateUrlWithSPContextAssignBy")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedNodes"))) { #optional property not found
            $SelectedNodes = $null
        } else {
            $SelectedNodes = $JsonParameters.PSobject.Properties["SelectedNodes"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoPopulateUrlWithSPContext"))) { #optional property not found
            $AutoPopulateUrlWithSPContext = $null
        } else {
            $AutoPopulateUrlWithSPContext = $JsonParameters.PSobject.Properties["AutoPopulateUrlWithSPContext"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoPopulateUrlWithSPContextAssignBy"))) { #optional property not found
            $AutoPopulateUrlWithSPContextAssignBy = $null
        } else {
            $AutoPopulateUrlWithSPContextAssignBy = $JsonParameters.PSobject.Properties["AutoPopulateUrlWithSPContextAssignBy"].value
        }

        $PSO = [PSCustomObject]@{
            "SelectedNodes" = ${SelectedNodes}
            "AutoPopulateUrlWithSPContext" = ${AutoPopulateUrlWithSPContext}
            "AutoPopulateUrlWithSPContextAssignBy" = ${AutoPopulateUrlWithSPContextAssignBy}
        }

        return $PSO
    }

}

