#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SitePolicyRef<PSCustomObject>
#>

function New-SitePolicyRef {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteSharingOptions} = "Disabled",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Category},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TenantId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status} = "Inactive"
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SitePolicyRef' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "SiteSharingOptions" = ${SiteSharingOptions}
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Category" = ${Category}
            "TenantId" = ${TenantId}
            "Status" = ${Status}
        }

        return $PSO
    }
}

<#
SitePolicyRef<PSCustomObject>
#>
function ConvertFrom-JsonToSitePolicyRef {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SitePolicyRef' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SitePolicyRef
        $AllProperties = $("SiteSharingOptions", "Id", "Name", "Description", "Category", "TenantId", "Status")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteSharingOptions"))) { #optional property not found
            $SiteSharingOptions = $null
        } else {
            $SiteSharingOptions = $JsonParameters.PSobject.Properties["SiteSharingOptions"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Category"))) { #optional property not found
            $Category = $null
        } else {
            $Category = $JsonParameters.PSobject.Properties["Category"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TenantId"))) { #optional property not found
            $TenantId = $null
        } else {
            $TenantId = $JsonParameters.PSobject.Properties["TenantId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        $PSO = [PSCustomObject]@{
            "SiteSharingOptions" = ${SiteSharingOptions}
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Category" = ${Category}
            "TenantId" = ${TenantId}
            "Status" = ${Status}
        }

        return $PSO
    }

}

