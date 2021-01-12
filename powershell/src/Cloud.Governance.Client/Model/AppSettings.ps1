#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
AppSettings<PSCustomObject>
#>

function New-AppSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableInstallApp},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableAddSiteInfoCard},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableAddTimeLine},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableAddPanel}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => AppSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "EnableInstallApp" = ${EnableInstallApp}
            "EnableAddSiteInfoCard" = ${EnableAddSiteInfoCard}
            "EnableAddTimeLine" = ${EnableAddTimeLine}
            "EnableAddPanel" = ${EnableAddPanel}
        }

        return $PSO
    }
}

<#
AppSettings<PSCustomObject>
#>
function ConvertFrom-JsonToAppSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => AppSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in AppSettings
        $AllProperties = $("EnableInstallApp", "EnableAddSiteInfoCard", "EnableAddTimeLine", "EnableAddPanel")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableInstallApp"))) { #optional property not found
            $EnableInstallApp = $null
        } else {
            $EnableInstallApp = $JsonParameters.PSobject.Properties["EnableInstallApp"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableAddSiteInfoCard"))) { #optional property not found
            $EnableAddSiteInfoCard = $null
        } else {
            $EnableAddSiteInfoCard = $JsonParameters.PSobject.Properties["EnableAddSiteInfoCard"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableAddTimeLine"))) { #optional property not found
            $EnableAddTimeLine = $null
        } else {
            $EnableAddTimeLine = $JsonParameters.PSobject.Properties["EnableAddTimeLine"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableAddPanel"))) { #optional property not found
            $EnableAddPanel = $null
        } else {
            $EnableAddPanel = $JsonParameters.PSobject.Properties["EnableAddPanel"].value
        }

        $PSO = [PSCustomObject]@{
            "EnableInstallApp" = ${EnableInstallApp}
            "EnableAddSiteInfoCard" = ${EnableAddSiteInfoCard}
            "EnableAddTimeLine" = ${EnableAddTimeLine}
            "EnableAddPanel" = ${EnableAddPanel}
        }

        return $PSO
    }

}

