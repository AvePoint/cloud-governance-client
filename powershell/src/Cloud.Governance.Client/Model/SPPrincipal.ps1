#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SPPrincipal<PSCustomObject>
#>

function New-SPPrincipal {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Id} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LoginName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrincipalType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AzureUserType}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SPPrincipal' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "LoginName" = ${LoginName}
            "Name" = ${Name}
            "PrincipalType" = ${PrincipalType}
            "AzureUserType" = ${AzureUserType}
        }

        return $PSO
    }
}

<#
SPPrincipal<PSCustomObject>
#>
function ConvertFrom-JsonToSPPrincipal {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SPPrincipal' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SPPrincipal
        $AllProperties = $("Id", "LoginName", "Name", "PrincipalType", "AzureUserType")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LoginName"))) { #optional property not found
            $LoginName = $null
        } else {
            $LoginName = $JsonParameters.PSobject.Properties["LoginName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrincipalType"))) { #optional property not found
            $PrincipalType = $null
        } else {
            $PrincipalType = $JsonParameters.PSobject.Properties["PrincipalType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AzureUserType"))) { #optional property not found
            $AzureUserType = $null
        } else {
            $AzureUserType = $JsonParameters.PSobject.Properties["AzureUserType"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "LoginName" = ${LoginName}
            "Name" = ${Name}
            "PrincipalType" = ${PrincipalType}
            "AzureUserType" = ${AzureUserType}
        }

        return $PSO
    }

}

