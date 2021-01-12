#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ListTemplate<PSCustomObject>
#>

function New-ListTemplate {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Type},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${BaseType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsCustomTemplate}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ListTemplate' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Title" = ${Title}
            "Description" = ${Description}
            "Type" = ${Type}
            "BaseType" = ${BaseType}
            "Name" = ${Name}
            "IsCustomTemplate" = ${IsCustomTemplate}
        }

        return $PSO
    }
}

<#
ListTemplate<PSCustomObject>
#>
function ConvertFrom-JsonToListTemplate {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ListTemplate' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ListTemplate
        $AllProperties = $("Title", "Description", "Type", "BaseType", "Name", "IsCustomTemplate")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Title"))) { #optional property not found
            $Title = $null
        } else {
            $Title = $JsonParameters.PSobject.Properties["Title"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BaseType"))) { #optional property not found
            $BaseType = $null
        } else {
            $BaseType = $JsonParameters.PSobject.Properties["BaseType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsCustomTemplate"))) { #optional property not found
            $IsCustomTemplate = $null
        } else {
            $IsCustomTemplate = $JsonParameters.PSobject.Properties["IsCustomTemplate"].value
        }

        $PSO = [PSCustomObject]@{
            "Title" = ${Title}
            "Description" = ${Description}
            "Type" = ${Type}
            "BaseType" = ${BaseType}
            "Name" = ${Name}
            "IsCustomTemplate" = ${IsCustomTemplate}
        }

        return $PSO
    }

}

