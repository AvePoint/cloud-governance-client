#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CreateListSPObject<PSCustomObject>
#>

function New-CreateListSPObject {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ParentUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteId}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CreateListSPObject' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ParentUrl" = ${ParentUrl}
            "SiteUrl" = ${SiteUrl}
            "SiteId" = ${SiteId}
        }

        return $PSO
    }
}

<#
CreateListSPObject<PSCustomObject>
#>
function ConvertFrom-JsonToCreateListSPObject {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CreateListSPObject' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CreateListSPObject
        $AllProperties = $("ParentUrl", "SiteUrl", "SiteId")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ParentUrl"))) { #optional property not found
            $ParentUrl = $null
        } else {
            $ParentUrl = $JsonParameters.PSobject.Properties["ParentUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteUrl"))) { #optional property not found
            $SiteUrl = $null
        } else {
            $SiteUrl = $JsonParameters.PSobject.Properties["SiteUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteId"))) { #optional property not found
            $SiteId = $null
        } else {
            $SiteId = $JsonParameters.PSobject.Properties["SiteId"].value
        }

        $PSO = [PSCustomObject]@{
            "ParentUrl" = ${ParentUrl}
            "SiteUrl" = ${SiteUrl}
            "SiteId" = ${SiteId}
        }

        return $PSO
    }

}

