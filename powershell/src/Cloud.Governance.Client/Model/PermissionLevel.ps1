#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
PermissionLevel<PSCustomObject>
#>

function New-PermissionLevel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${IdInSharePoint},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => PermissionLevel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "IdInSharePoint" = ${IdInSharePoint}
            "Name" = ${Name}
        }

        return $PSO
    }
}

<#
PermissionLevel<PSCustomObject>
#>
function ConvertFrom-JsonToPermissionLevel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => PermissionLevel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in PermissionLevel
        $AllProperties = $("Id", "IdInSharePoint", "Name", "Description", "IsExcluded", "Type")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IdInSharePoint"))) { #optional property not found
            $IdInSharePoint = $null
        } else {
            $IdInSharePoint = $JsonParameters.PSobject.Properties["IdInSharePoint"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsExcluded"))) { #optional property not found
            $IsExcluded = $null
        } else {
            $IsExcluded = $JsonParameters.PSobject.Properties["IsExcluded"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "IdInSharePoint" = ${IdInSharePoint}
            "Name" = ${Name}
            "Description" = ${Description}
            "IsExcluded" = ${IsExcluded}
            "Type" = ${Type}
        }

        return $PSO
    }

}

