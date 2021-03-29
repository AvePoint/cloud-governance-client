#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ServiceGridModel<PSCustomObject>
#>

function New-ServiceGridModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceTypeDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status} = "Inactive",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StatusDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Language} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${ModifiedTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CreatedByDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CreatedBy}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ServiceGridModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Description" = ${Description}
            "Name" = ${Name}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "Language" = ${Language}
            "ModifiedTime" = ${ModifiedTime}
            "CreatedByDisplayName" = ${CreatedByDisplayName}
            "CreatedBy" = ${CreatedBy}
        }

        return $PSO
    }
}

<#
ServiceGridModel<PSCustomObject>
#>
function ConvertFrom-JsonToServiceGridModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ServiceGridModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ServiceGridModel
        $AllProperties = $("Id", "Description", "Name", "ServiceType", "ServiceTypeDescription", "Status", "StatusDescription", "Language", "ModifiedTime", "CreatedByDisplayName", "CreatedBy")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceType"))) { #optional property not found
            $ServiceType = $null
        } else {
            $ServiceType = $JsonParameters.PSobject.Properties["ServiceType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceTypeDescription"))) { #optional property not found
            $ServiceTypeDescription = $null
        } else {
            $ServiceTypeDescription = $JsonParameters.PSobject.Properties["ServiceTypeDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StatusDescription"))) { #optional property not found
            $StatusDescription = $null
        } else {
            $StatusDescription = $JsonParameters.PSobject.Properties["StatusDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Language"))) { #optional property not found
            $Language = $null
        } else {
            $Language = $JsonParameters.PSobject.Properties["Language"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ModifiedTime"))) { #optional property not found
            $ModifiedTime = $null
        } else {
            $ModifiedTime = $JsonParameters.PSobject.Properties["ModifiedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreatedByDisplayName"))) { #optional property not found
            $CreatedByDisplayName = $null
        } else {
            $CreatedByDisplayName = $JsonParameters.PSobject.Properties["CreatedByDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreatedBy"))) { #optional property not found
            $CreatedBy = $null
        } else {
            $CreatedBy = $JsonParameters.PSobject.Properties["CreatedBy"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Description" = ${Description}
            "Name" = ${Name}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "Language" = ${Language}
            "ModifiedTime" = ${ModifiedTime}
            "CreatedByDisplayName" = ${CreatedByDisplayName}
            "CreatedBy" = ${CreatedBy}
        }

        return $PSO
    }

}

