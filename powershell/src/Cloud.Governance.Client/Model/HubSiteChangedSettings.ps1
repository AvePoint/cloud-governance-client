#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
HubSiteChangedSettings<PSCustomObject>
#>

function New-HubSiteChangedSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsModernSite},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Action},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssociatedHubSiteId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AssociatedHubSiteTitle}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => HubSiteChangedSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsModernSite" = ${IsModernSite}
            "Action" = ${Action}
            "AssociatedHubSiteId" = ${AssociatedHubSiteId}
            "AssociatedHubSiteTitle" = ${AssociatedHubSiteTitle}
        }

        return $PSO
    }
}

<#
HubSiteChangedSettings<PSCustomObject>
#>
function ConvertFrom-JsonToHubSiteChangedSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => HubSiteChangedSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in HubSiteChangedSettings
        $AllProperties = $("Enabled", "IsModernSite", "Action", "AssociatedHubSiteId", "AssociatedHubSiteTitle")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Enabled"))) { #optional property not found
            $Enabled = $null
        } else {
            $Enabled = $JsonParameters.PSobject.Properties["Enabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsModernSite"))) { #optional property not found
            $IsModernSite = $null
        } else {
            $IsModernSite = $JsonParameters.PSobject.Properties["IsModernSite"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Action"))) { #optional property not found
            $Action = $null
        } else {
            $Action = $JsonParameters.PSobject.Properties["Action"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssociatedHubSiteId"))) { #optional property not found
            $AssociatedHubSiteId = $null
        } else {
            $AssociatedHubSiteId = $JsonParameters.PSobject.Properties["AssociatedHubSiteId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssociatedHubSiteTitle"))) { #optional property not found
            $AssociatedHubSiteTitle = $null
        } else {
            $AssociatedHubSiteTitle = $JsonParameters.PSobject.Properties["AssociatedHubSiteTitle"].value
        }

        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "IsModernSite" = ${IsModernSite}
            "Action" = ${Action}
            "AssociatedHubSiteId" = ${AssociatedHubSiteId}
            "AssociatedHubSiteTitle" = ${AssociatedHubSiteTitle}
        }

        return $PSO
    }

}

