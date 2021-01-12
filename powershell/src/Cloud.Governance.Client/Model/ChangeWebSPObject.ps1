#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeWebSPObject<PSCustomObject>
#>

function New-ChangeWebSPObject {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebId}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeWebSPObject' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "SiteUrl" = ${SiteUrl}
            "WebUrl" = ${WebUrl}
            "SiteId" = ${SiteId}
            "WebId" = ${WebId}
        }

        return $PSO
    }
}

<#
ChangeWebSPObject<PSCustomObject>
#>
function ConvertFrom-JsonToChangeWebSPObject {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeWebSPObject' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeWebSPObject
        $AllProperties = $("SiteUrl", "WebUrl", "SiteId", "WebId")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteUrl"))) { #optional property not found
            $SiteUrl = $null
        } else {
            $SiteUrl = $JsonParameters.PSobject.Properties["SiteUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebUrl"))) { #optional property not found
            $WebUrl = $null
        } else {
            $WebUrl = $JsonParameters.PSobject.Properties["WebUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteId"))) { #optional property not found
            $SiteId = $null
        } else {
            $SiteId = $JsonParameters.PSobject.Properties["SiteId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebId"))) { #optional property not found
            $WebId = $null
        } else {
            $WebId = $JsonParameters.PSobject.Properties["WebId"].value
        }

        $PSO = [PSCustomObject]@{
            "SiteUrl" = ${SiteUrl}
            "WebUrl" = ${WebUrl}
            "SiteId" = ${SiteId}
            "WebId" = ${WebId}
        }

        return $PSO
    }

}

