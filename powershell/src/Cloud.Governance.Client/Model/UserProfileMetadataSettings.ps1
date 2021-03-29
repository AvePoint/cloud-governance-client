#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
UserProfileMetadataSettings<PSCustomObject>
#>

function New-UserProfileMetadataSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AdminCenter},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ValueType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableValueSync} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableRoleValueSync} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Value},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Property},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AllowReferenceAsRoleInApprovalProcess} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => UserProfileMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "AdminCenter" = ${AdminCenter}
            "ValueType" = ${ValueType}
            "EnableValueSync" = ${EnableValueSync}
            "EnableRoleValueSync" = ${EnableRoleValueSync}
            "Value" = ${Value}
            "Property" = ${Property}
            "AllowReferenceAsRoleInApprovalProcess" = ${AllowReferenceAsRoleInApprovalProcess}
        }

        return $PSO
    }
}

<#
UserProfileMetadataSettings<PSCustomObject>
#>
function ConvertFrom-JsonToUserProfileMetadataSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => UserProfileMetadataSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in UserProfileMetadataSettings
        $AllProperties = $("AdminCenter", "ValueType", "EnableValueSync", "EnableRoleValueSync", "Value", "Property", "AllowReferenceAsRoleInApprovalProcess")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdminCenter"))) { #optional property not found
            $AdminCenter = $null
        } else {
            $AdminCenter = $JsonParameters.PSobject.Properties["AdminCenter"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ValueType"))) { #optional property not found
            $ValueType = $null
        } else {
            $ValueType = $JsonParameters.PSobject.Properties["ValueType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableValueSync"))) { #optional property not found
            $EnableValueSync = $null
        } else {
            $EnableValueSync = $JsonParameters.PSobject.Properties["EnableValueSync"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableRoleValueSync"))) { #optional property not found
            $EnableRoleValueSync = $null
        } else {
            $EnableRoleValueSync = $JsonParameters.PSobject.Properties["EnableRoleValueSync"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Value"))) { #optional property not found
            $Value = $null
        } else {
            $Value = $JsonParameters.PSobject.Properties["Value"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Property"))) { #optional property not found
            $Property = $null
        } else {
            $Property = $JsonParameters.PSobject.Properties["Property"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllowReferenceAsRoleInApprovalProcess"))) { #optional property not found
            $AllowReferenceAsRoleInApprovalProcess = $null
        } else {
            $AllowReferenceAsRoleInApprovalProcess = $JsonParameters.PSobject.Properties["AllowReferenceAsRoleInApprovalProcess"].value
        }

        $PSO = [PSCustomObject]@{
            "AdminCenter" = ${AdminCenter}
            "ValueType" = ${ValueType}
            "EnableValueSync" = ${EnableValueSync}
            "EnableRoleValueSync" = ${EnableRoleValueSync}
            "Value" = ${Value}
            "Property" = ${Property}
            "AllowReferenceAsRoleInApprovalProcess" = ${AllowReferenceAsRoleInApprovalProcess}
        }

        return $PSO
    }

}

