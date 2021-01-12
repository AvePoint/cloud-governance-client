#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
TemplateWithPermissions<PSCustomObject>
#>

function New-TemplateWithPermissions {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TemplateId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsUseCommon},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${UserPermissions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${GroupPermissions}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TemplateWithPermissions' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "TemplateId" = ${TemplateId}
            "IsUseCommon" = ${IsUseCommon}
            "UserPermissions" = ${UserPermissions}
            "GroupPermissions" = ${GroupPermissions}
        }

        return $PSO
    }
}

<#
TemplateWithPermissions<PSCustomObject>
#>
function ConvertFrom-JsonToTemplateWithPermissions {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => TemplateWithPermissions' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in TemplateWithPermissions
        $AllProperties = $("TemplateId", "IsUseCommon", "UserPermissions", "GroupPermissions")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemplateId"))) { #optional property not found
            $TemplateId = $null
        } else {
            $TemplateId = $JsonParameters.PSobject.Properties["TemplateId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsUseCommon"))) { #optional property not found
            $IsUseCommon = $null
        } else {
            $IsUseCommon = $JsonParameters.PSobject.Properties["IsUseCommon"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserPermissions"))) { #optional property not found
            $UserPermissions = $null
        } else {
            $UserPermissions = $JsonParameters.PSobject.Properties["UserPermissions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupPermissions"))) { #optional property not found
            $GroupPermissions = $null
        } else {
            $GroupPermissions = $JsonParameters.PSobject.Properties["GroupPermissions"].value
        }

        $PSO = [PSCustomObject]@{
            "TemplateId" = ${TemplateId}
            "IsUseCommon" = ${IsUseCommon}
            "UserPermissions" = ${UserPermissions}
            "GroupPermissions" = ${GroupPermissions}
        }

        return $PSO
    }

}

