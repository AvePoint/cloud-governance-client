#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeListSettingObjectInfo<PSCustomObject>
#>

function New-ChangeListSettingObjectInfo {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectTitle}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeListSettingObjectInfo' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "SiteUrl" = ${SiteUrl}
            "WebId" = ${WebId}
            "WebUrl" = ${WebUrl}
            "SiteId" = ${SiteId}
            "ObjectUrl" = ${ObjectUrl}
            "ObjectTitle" = ${ObjectTitle}
        }

        return $PSO
    }
}

<#
ChangeListSettingObjectInfo<PSCustomObject>
#>
function ConvertFrom-JsonToChangeListSettingObjectInfo {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeListSettingObjectInfo' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeListSettingObjectInfo
        $AllProperties = $("SiteUrl", "WebId", "WebUrl", "SiteId", "ObjectUrl", "ObjectTitle")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebId"))) { #optional property not found
            $WebId = $null
        } else {
            $WebId = $JsonParameters.PSobject.Properties["WebId"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectUrl"))) { #optional property not found
            $ObjectUrl = $null
        } else {
            $ObjectUrl = $JsonParameters.PSobject.Properties["ObjectUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectTitle"))) { #optional property not found
            $ObjectTitle = $null
        } else {
            $ObjectTitle = $JsonParameters.PSobject.Properties["ObjectTitle"].value
        }

        $PSO = [PSCustomObject]@{
            "SiteUrl" = ${SiteUrl}
            "WebId" = ${WebId}
            "WebUrl" = ${WebUrl}
            "SiteId" = ${SiteId}
            "ObjectUrl" = ${ObjectUrl}
            "ObjectTitle" = ${ObjectTitle}
        }

        return $PSO
    }

}

