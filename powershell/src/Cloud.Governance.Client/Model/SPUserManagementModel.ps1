#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SPUserManagementModel<PSCustomObject>
#>

function New-SPUserManagementModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${IdentityName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsGroup} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AzureUserType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Action} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExternalUserType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Email}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SPUserManagementModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IdentityName" = ${IdentityName}
            "DisplayName" = ${DisplayName}
            "IsGroup" = ${IsGroup}
            "AzureUserType" = ${AzureUserType}
            "Action" = ${Action}
            "ExternalUserType" = ${ExternalUserType}
            "Email" = ${Email}
        }

        return $PSO
    }
}

<#
SPUserManagementModel<PSCustomObject>
#>
function ConvertFrom-JsonToSPUserManagementModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SPUserManagementModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SPUserManagementModel
        $AllProperties = $("IdentityName", "DisplayName", "IsGroup", "AzureUserType", "Action", "ExternalUserType", "Email")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IdentityName"))) { #optional property not found
            $IdentityName = $null
        } else {
            $IdentityName = $JsonParameters.PSobject.Properties["IdentityName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayName"))) { #optional property not found
            $DisplayName = $null
        } else {
            $DisplayName = $JsonParameters.PSobject.Properties["DisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsGroup"))) { #optional property not found
            $IsGroup = $null
        } else {
            $IsGroup = $JsonParameters.PSobject.Properties["IsGroup"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AzureUserType"))) { #optional property not found
            $AzureUserType = $null
        } else {
            $AzureUserType = $JsonParameters.PSobject.Properties["AzureUserType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Action"))) { #optional property not found
            $Action = $null
        } else {
            $Action = $JsonParameters.PSobject.Properties["Action"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExternalUserType"))) { #optional property not found
            $ExternalUserType = $null
        } else {
            $ExternalUserType = $JsonParameters.PSobject.Properties["ExternalUserType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Email"))) { #optional property not found
            $Email = $null
        } else {
            $Email = $JsonParameters.PSobject.Properties["Email"].value
        }

        $PSO = [PSCustomObject]@{
            "IdentityName" = ${IdentityName}
            "DisplayName" = ${DisplayName}
            "IsGroup" = ${IsGroup}
            "AzureUserType" = ${AzureUserType}
            "Action" = ${Action}
            "ExternalUserType" = ${ExternalUserType}
            "Email" = ${Email}
        }

        return $PSO
    }

}

