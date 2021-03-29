#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ObjectPermissionManagementModel<PSCustomObject>
#>

function New-ObjectPermissionManagementModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ObjectType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ObjectInfo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Action} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Permissions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${OriginalPermissions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExternalUserType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Members},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GrantPermissionSetting},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${OriginalName}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ObjectPermissionManagementModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ObjectType" = ${ObjectType}
            "ObjectInfo" = ${ObjectInfo}
            "Action" = ${Action}
            "Permissions" = ${Permissions}
            "OriginalPermissions" = ${OriginalPermissions}
            "ExternalUserType" = ${ExternalUserType}
            "Members" = ${Members}
            "GrantPermissionSetting" = ${GrantPermissionSetting}
            "OriginalName" = ${OriginalName}
        }

        return $PSO
    }
}

<#
ObjectPermissionManagementModel<PSCustomObject>
#>
function ConvertFrom-JsonToObjectPermissionManagementModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ObjectPermissionManagementModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ObjectPermissionManagementModel
        $AllProperties = $("ObjectType", "ObjectInfo", "Action", "Permissions", "OriginalPermissions", "ExternalUserType", "Members", "GrantPermissionSetting", "OriginalName")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectType"))) { #optional property not found
            $ObjectType = $null
        } else {
            $ObjectType = $JsonParameters.PSobject.Properties["ObjectType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectInfo"))) { #optional property not found
            $ObjectInfo = $null
        } else {
            $ObjectInfo = $JsonParameters.PSobject.Properties["ObjectInfo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Action"))) { #optional property not found
            $Action = $null
        } else {
            $Action = $JsonParameters.PSobject.Properties["Action"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Permissions"))) { #optional property not found
            $Permissions = $null
        } else {
            $Permissions = $JsonParameters.PSobject.Properties["Permissions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalPermissions"))) { #optional property not found
            $OriginalPermissions = $null
        } else {
            $OriginalPermissions = $JsonParameters.PSobject.Properties["OriginalPermissions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExternalUserType"))) { #optional property not found
            $ExternalUserType = $null
        } else {
            $ExternalUserType = $JsonParameters.PSobject.Properties["ExternalUserType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Members"))) { #optional property not found
            $Members = $null
        } else {
            $Members = $JsonParameters.PSobject.Properties["Members"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GrantPermissionSetting"))) { #optional property not found
            $GrantPermissionSetting = $null
        } else {
            $GrantPermissionSetting = $JsonParameters.PSobject.Properties["GrantPermissionSetting"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalName"))) { #optional property not found
            $OriginalName = $null
        } else {
            $OriginalName = $JsonParameters.PSobject.Properties["OriginalName"].value
        }

        $PSO = [PSCustomObject]@{
            "ObjectType" = ${ObjectType}
            "ObjectInfo" = ${ObjectInfo}
            "Action" = ${Action}
            "Permissions" = ${Permissions}
            "OriginalPermissions" = ${OriginalPermissions}
            "ExternalUserType" = ${ExternalUserType}
            "Members" = ${Members}
            "GrantPermissionSetting" = ${GrantPermissionSetting}
            "OriginalName" = ${OriginalName}
        }

        return $PSO
    }

}

