#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GeoLocationModel<PSCustomObject>
#>

function New-GeoLocationModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RootSiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TenantAdminUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GeoLocationModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "RootSiteUrl" = ${RootSiteUrl}
            "TenantAdminUrl" = ${TenantAdminUrl}
            "Name" = ${Name}
            "DisplayName" = ${DisplayName}
        }

        return $PSO
    }
}

<#
GeoLocationModel<PSCustomObject>
#>
function ConvertFrom-JsonToGeoLocationModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GeoLocationModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GeoLocationModel
        $AllProperties = $("RootSiteUrl", "TenantAdminUrl", "Name", "DisplayName")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RootSiteUrl"))) { #optional property not found
            $RootSiteUrl = $null
        } else {
            $RootSiteUrl = $JsonParameters.PSobject.Properties["RootSiteUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TenantAdminUrl"))) { #optional property not found
            $TenantAdminUrl = $null
        } else {
            $TenantAdminUrl = $JsonParameters.PSobject.Properties["TenantAdminUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayName"))) { #optional property not found
            $DisplayName = $null
        } else {
            $DisplayName = $JsonParameters.PSobject.Properties["DisplayName"].value
        }

        $PSO = [PSCustomObject]@{
            "RootSiteUrl" = ${RootSiteUrl}
            "TenantAdminUrl" = ${TenantAdminUrl}
            "Name" = ${Name}
            "DisplayName" = ${DisplayName}
        }

        return $PSO
    }

}

