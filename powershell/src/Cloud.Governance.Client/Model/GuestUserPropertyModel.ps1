#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GuestUserPropertyModel<PSCustomObject>
#>

function New-GuestUserPropertyModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FirstName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LastName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UserName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UsageLocation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${JobTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${JobDepartment}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GuestUserPropertyModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "DisplayName" = ${DisplayName}
            "FirstName" = ${FirstName}
            "LastName" = ${LastName}
            "UserName" = ${UserName}
            "UsageLocation" = ${UsageLocation}
            "JobTitle" = ${JobTitle}
            "JobDepartment" = ${JobDepartment}
        }

        return $PSO
    }
}

<#
GuestUserPropertyModel<PSCustomObject>
#>
function ConvertFrom-JsonToGuestUserPropertyModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GuestUserPropertyModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GuestUserPropertyModel
        $AllProperties = $("DisplayName", "FirstName", "LastName", "UserName", "UsageLocation", "JobTitle", "JobDepartment")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayName"))) { #optional property not found
            $DisplayName = $null
        } else {
            $DisplayName = $JsonParameters.PSobject.Properties["DisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FirstName"))) { #optional property not found
            $FirstName = $null
        } else {
            $FirstName = $JsonParameters.PSobject.Properties["FirstName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastName"))) { #optional property not found
            $LastName = $null
        } else {
            $LastName = $JsonParameters.PSobject.Properties["LastName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserName"))) { #optional property not found
            $UserName = $null
        } else {
            $UserName = $JsonParameters.PSobject.Properties["UserName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UsageLocation"))) { #optional property not found
            $UsageLocation = $null
        } else {
            $UsageLocation = $JsonParameters.PSobject.Properties["UsageLocation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "JobTitle"))) { #optional property not found
            $JobTitle = $null
        } else {
            $JobTitle = $JsonParameters.PSobject.Properties["JobTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "JobDepartment"))) { #optional property not found
            $JobDepartment = $null
        } else {
            $JobDepartment = $JsonParameters.PSobject.Properties["JobDepartment"].value
        }

        $PSO = [PSCustomObject]@{
            "DisplayName" = ${DisplayName}
            "FirstName" = ${FirstName}
            "LastName" = ${LastName}
            "UserName" = ${UserName}
            "UsageLocation" = ${UsageLocation}
            "JobTitle" = ${JobTitle}
            "JobDepartment" = ${JobDepartment}
        }

        return $PSO
    }

}

