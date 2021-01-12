#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GrantPermissionGroup<PSCustomObject>
#>

function New-GrantPermissionGroup {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${PermissionIds},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GrantPermissionGroup' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "DisplayName" = ${DisplayName}
            "PermissionIds" = ${PermissionIds}
            "Description" = ${Description}
        }

        return $PSO
    }
}

<#
GrantPermissionGroup<PSCustomObject>
#>
function ConvertFrom-JsonToGrantPermissionGroup {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GrantPermissionGroup' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GrantPermissionGroup
        $AllProperties = $("Id", "Name", "DisplayName", "PermissionIds", "Description")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayName"))) { #optional property not found
            $DisplayName = $null
        } else {
            $DisplayName = $JsonParameters.PSobject.Properties["DisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionIds"))) { #optional property not found
            $PermissionIds = $null
        } else {
            $PermissionIds = $JsonParameters.PSobject.Properties["PermissionIds"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "DisplayName" = ${DisplayName}
            "PermissionIds" = ${PermissionIds}
            "Description" = ${Description}
        }

        return $PSO
    }

}

