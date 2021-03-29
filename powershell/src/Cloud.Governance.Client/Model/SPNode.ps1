#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SPNode<PSCustomObject>
#>

function New-SPNode {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FullUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type} = "Container",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsSelected} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SPNode' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "FullUrl" = ${FullUrl}
            "Type" = ${Type}
            "Name" = ${Name}
            "Title" = ${Title}
            "IsSelected" = ${IsSelected}
        }

        return $PSO
    }
}

<#
SPNode<PSCustomObject>
#>
function ConvertFrom-JsonToSPNode {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SPNode' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SPNode
        $AllProperties = $("Id", "FullUrl", "Type", "Name", "Title", "IsSelected")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FullUrl"))) { #optional property not found
            $FullUrl = $null
        } else {
            $FullUrl = $JsonParameters.PSobject.Properties["FullUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Title"))) { #optional property not found
            $Title = $null
        } else {
            $Title = $JsonParameters.PSobject.Properties["Title"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsSelected"))) { #optional property not found
            $IsSelected = $null
        } else {
            $IsSelected = $JsonParameters.PSobject.Properties["IsSelected"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "FullUrl" = ${FullUrl}
            "Type" = ${Type}
            "Name" = ${Name}
            "Title" = ${Title}
            "IsSelected" = ${IsSelected}
        }

        return $PSO
    }

}

