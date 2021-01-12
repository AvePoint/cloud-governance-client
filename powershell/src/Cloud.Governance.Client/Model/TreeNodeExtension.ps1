#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
TreeNodeExtension<PSCustomObject>
#>

function New-TreeNodeExtension {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Size},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UserName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Password}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => TreeNodeExtension' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Size" = ${Size}
            "UserName" = ${UserName}
            "Password" = ${Password}
        }

        return $PSO
    }
}

<#
TreeNodeExtension<PSCustomObject>
#>
function ConvertFrom-JsonToTreeNodeExtension {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => TreeNodeExtension' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in TreeNodeExtension
        $AllProperties = $("Size", "UserName", "Password")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Size"))) { #optional property not found
            $Size = $null
        } else {
            $Size = $JsonParameters.PSobject.Properties["Size"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserName"))) { #optional property not found
            $UserName = $null
        } else {
            $UserName = $JsonParameters.PSobject.Properties["UserName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Password"))) { #optional property not found
            $Password = $null
        } else {
            $Password = $JsonParameters.PSobject.Properties["Password"].value
        }

        $PSO = [PSCustomObject]@{
            "Size" = ${Size}
            "UserName" = ${UserName}
            "Password" = ${Password}
        }

        return $PSO
    }

}

