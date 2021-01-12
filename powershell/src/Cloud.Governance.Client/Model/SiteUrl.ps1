#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SiteUrl<PSCustomObject>
#>

function New-SiteUrl {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Root},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ManagedPath},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SiteUrl' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Root" = ${Root}
            "ManagedPath" = ${ManagedPath}
            "Name" = ${Name}
        }

        return $PSO
    }
}

<#
SiteUrl<PSCustomObject>
#>
function ConvertFrom-JsonToSiteUrl {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SiteUrl' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SiteUrl
        $AllProperties = $("Root", "ManagedPath", "Name")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Root"))) { #optional property not found
            $Root = $null
        } else {
            $Root = $JsonParameters.PSobject.Properties["Root"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ManagedPath"))) { #optional property not found
            $ManagedPath = $null
        } else {
            $ManagedPath = $JsonParameters.PSobject.Properties["ManagedPath"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        $PSO = [PSCustomObject]@{
            "Root" = ${Root}
            "ManagedPath" = ${ManagedPath}
            "Name" = ${Name}
        }

        return $PSO
    }

}

