#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
HubSiteSettings<PSCustomObject>
#>

function New-HubSiteSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Enabled},
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
        'Creating PSCustomObject: Cloud.Governance.Client => HubSiteSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Enabled" = ${Enabled}
            "Action" = ${Action}
            "AssociatedHubSiteId" = ${AssociatedHubSiteId}
            "AssociatedHubSiteTitle" = ${AssociatedHubSiteTitle}
        }

        return $PSO
    }
}

<#
HubSiteSettings<PSCustomObject>
#>
function ConvertFrom-JsonToHubSiteSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => HubSiteSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in HubSiteSettings
        $AllProperties = $("Enabled", "Action", "AssociatedHubSiteId", "AssociatedHubSiteTitle")
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
            "Action" = ${Action}
            "AssociatedHubSiteId" = ${AssociatedHubSiteId}
            "AssociatedHubSiteTitle" = ${AssociatedHubSiteTitle}
        }

        return $PSO
    }

}

