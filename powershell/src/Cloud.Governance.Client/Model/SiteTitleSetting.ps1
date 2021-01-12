#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SiteTitleSetting<PSCustomObject>
#>

function New-SiteTitleSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${TitleAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableTitleConstructure},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${TitlePrefixes},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${TitleSuffixes}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SiteTitleSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "TitleAssignBy" = ${TitleAssignBy}
            "EnableTitleConstructure" = ${EnableTitleConstructure}
            "TitlePrefixes" = ${TitlePrefixes}
            "TitleSuffixes" = ${TitleSuffixes}
        }

        return $PSO
    }
}

<#
SiteTitleSetting<PSCustomObject>
#>
function ConvertFrom-JsonToSiteTitleSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SiteTitleSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SiteTitleSetting
        $AllProperties = $("TitleAssignBy", "EnableTitleConstructure", "TitlePrefixes", "TitleSuffixes")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TitleAssignBy"))) { #optional property not found
            $TitleAssignBy = $null
        } else {
            $TitleAssignBy = $JsonParameters.PSobject.Properties["TitleAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableTitleConstructure"))) { #optional property not found
            $EnableTitleConstructure = $null
        } else {
            $EnableTitleConstructure = $JsonParameters.PSobject.Properties["EnableTitleConstructure"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TitlePrefixes"))) { #optional property not found
            $TitlePrefixes = $null
        } else {
            $TitlePrefixes = $JsonParameters.PSobject.Properties["TitlePrefixes"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TitleSuffixes"))) { #optional property not found
            $TitleSuffixes = $null
        } else {
            $TitleSuffixes = $JsonParameters.PSobject.Properties["TitleSuffixes"].value
        }

        $PSO = [PSCustomObject]@{
            "TitleAssignBy" = ${TitleAssignBy}
            "EnableTitleConstructure" = ${EnableTitleConstructure}
            "TitlePrefixes" = ${TitlePrefixes}
            "TitleSuffixes" = ${TitleSuffixes}
        }

        return $PSO
    }

}

