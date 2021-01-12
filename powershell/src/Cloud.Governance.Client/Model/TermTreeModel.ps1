#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
TermTreeModel<PSCustomObject>
#>

function New-TermTreeModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Child}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TermTreeModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Name" = ${Name}
            "Id" = ${Id}
            "Child" = ${Child}
        }

        return $PSO
    }
}

<#
TermTreeModel<PSCustomObject>
#>
function ConvertFrom-JsonToTermTreeModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => TermTreeModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in TermTreeModel
        $AllProperties = $("Name", "Id", "Child")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Child"))) { #optional property not found
            $Child = $null
        } else {
            $Child = $JsonParameters.PSobject.Properties["Child"].value
        }

        $PSO = [PSCustomObject]@{
            "Name" = ${Name}
            "Id" = ${Id}
            "Child" = ${Child}
        }

        return $PSO
    }

}

