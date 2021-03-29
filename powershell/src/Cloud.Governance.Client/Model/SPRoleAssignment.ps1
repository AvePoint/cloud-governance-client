#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SPRoleAssignment<PSCustomObject>
#>

function New-SPRoleAssignment {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Id} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LoginName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AzureUserType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrincipalType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PrincipalTypeDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${PermissionLevels}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SPRoleAssignment' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "LoginName" = ${LoginName}
            "AzureUserType" = ${AzureUserType}
            "PrincipalType" = ${PrincipalType}
            "PrincipalTypeDescription" = ${PrincipalTypeDescription}
            "PermissionLevels" = ${PermissionLevels}
        }

        return $PSO
    }
}

<#
SPRoleAssignment<PSCustomObject>
#>
function ConvertFrom-JsonToSPRoleAssignment {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SPRoleAssignment' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SPRoleAssignment
        $AllProperties = $("Id", "Name", "LoginName", "AzureUserType", "PrincipalType", "PrincipalTypeDescription", "PermissionLevels")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LoginName"))) { #optional property not found
            $LoginName = $null
        } else {
            $LoginName = $JsonParameters.PSobject.Properties["LoginName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AzureUserType"))) { #optional property not found
            $AzureUserType = $null
        } else {
            $AzureUserType = $JsonParameters.PSobject.Properties["AzureUserType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrincipalType"))) { #optional property not found
            $PrincipalType = $null
        } else {
            $PrincipalType = $JsonParameters.PSobject.Properties["PrincipalType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrincipalTypeDescription"))) { #optional property not found
            $PrincipalTypeDescription = $null
        } else {
            $PrincipalTypeDescription = $JsonParameters.PSobject.Properties["PrincipalTypeDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionLevels"))) { #optional property not found
            $PermissionLevels = $null
        } else {
            $PermissionLevels = $JsonParameters.PSobject.Properties["PermissionLevels"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "LoginName" = ${LoginName}
            "AzureUserType" = ${AzureUserType}
            "PrincipalType" = ${PrincipalType}
            "PrincipalTypeDescription" = ${PrincipalTypeDescription}
            "PermissionLevels" = ${PermissionLevels}
        }

        return $PSO
    }

}

