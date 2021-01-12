#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeListSettingValidateResult<PSCustomObject>
#>

function New-ChangeListSettingValidateResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SiteId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WebId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Lists},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsValid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ErrorMessage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MessageCode}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeListSettingValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "SiteUrl" = ${SiteUrl}
            "SiteId" = ${SiteId}
            "WebUrl" = ${WebUrl}
            "WebId" = ${WebId}
            "Lists" = ${Lists}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }
}

<#
ChangeListSettingValidateResult<PSCustomObject>
#>
function ConvertFrom-JsonToChangeListSettingValidateResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeListSettingValidateResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeListSettingValidateResult
        $AllProperties = $("SiteUrl", "SiteId", "WebUrl", "WebId", "Lists", "IsValid", "ErrorMessage", "MessageCode")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteId"))) { #optional property not found
            $SiteId = $null
        } else {
            $SiteId = $JsonParameters.PSobject.Properties["SiteId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebUrl"))) { #optional property not found
            $WebUrl = $null
        } else {
            $WebUrl = $JsonParameters.PSobject.Properties["WebUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WebId"))) { #optional property not found
            $WebId = $null
        } else {
            $WebId = $JsonParameters.PSobject.Properties["WebId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Lists"))) { #optional property not found
            $Lists = $null
        } else {
            $Lists = $JsonParameters.PSobject.Properties["Lists"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsValid"))) { #optional property not found
            $IsValid = $null
        } else {
            $IsValid = $JsonParameters.PSobject.Properties["IsValid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ErrorMessage"))) { #optional property not found
            $ErrorMessage = $null
        } else {
            $ErrorMessage = $JsonParameters.PSobject.Properties["ErrorMessage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MessageCode"))) { #optional property not found
            $MessageCode = $null
        } else {
            $MessageCode = $JsonParameters.PSobject.Properties["MessageCode"].value
        }

        $PSO = [PSCustomObject]@{
            "SiteUrl" = ${SiteUrl}
            "SiteId" = ${SiteId}
            "WebUrl" = ${WebUrl}
            "WebId" = ${WebId}
            "Lists" = ${Lists}
            "IsValid" = ${IsValid}
            "ErrorMessage" = ${ErrorMessage}
            "MessageCode" = ${MessageCode}
        }

        return $PSO
    }

}

