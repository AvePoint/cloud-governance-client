#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SiteTemplate<PSCustomObject>
#>

function New-SiteTemplate {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Category}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SiteTemplate' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Title" = ${Title}
            "Category" = ${Category}
        }

        return $PSO
    }
}

<#
SiteTemplate<PSCustomObject>
#>
function ConvertFrom-JsonToSiteTemplate {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SiteTemplate' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SiteTemplate
        $AllProperties = $("Id", "Title", "Category")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Title"))) { #optional property not found
            $Title = $null
        } else {
            $Title = $JsonParameters.PSobject.Properties["Title"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Category"))) { #optional property not found
            $Category = $null
        } else {
            $Category = $JsonParameters.PSobject.Properties["Category"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Title" = ${Title}
            "Category" = ${Category}
        }

        return $PSO
    }

}

