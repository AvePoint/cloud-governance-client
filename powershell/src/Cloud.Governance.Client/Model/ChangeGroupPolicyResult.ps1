#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangeGroupPolicyResult<PSCustomObject>
#>

function New-ChangeGroupPolicyResult {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CurrentPolicy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${AllPolicies},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ChangePolicyAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${StartDateType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${ServiceSpecifyDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableLeaseExpired},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LeaseDuration},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeaseDurationType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${CurrentStartDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAllowAutoCancel}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangeGroupPolicyResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "CurrentPolicy" = ${CurrentPolicy}
            "AllPolicies" = ${AllPolicies}
            "ChangePolicyAssignBy" = ${ChangePolicyAssignBy}
            "StartDateType" = ${StartDateType}
            "ServiceSpecifyDate" = ${ServiceSpecifyDate}
            "IsEnableLeaseExpired" = ${IsEnableLeaseExpired}
            "LeaseDuration" = ${LeaseDuration}
            "LeaseDurationType" = ${LeaseDurationType}
            "CurrentStartDate" = ${CurrentStartDate}
            "IsAllowAutoCancel" = ${IsAllowAutoCancel}
        }

        return $PSO
    }
}

<#
ChangeGroupPolicyResult<PSCustomObject>
#>
function ConvertFrom-JsonToChangeGroupPolicyResult {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangeGroupPolicyResult' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangeGroupPolicyResult
        $AllProperties = $("CurrentPolicy", "AllPolicies", "ChangePolicyAssignBy", "StartDateType", "ServiceSpecifyDate", "IsEnableLeaseExpired", "LeaseDuration", "LeaseDurationType", "CurrentStartDate", "IsAllowAutoCancel")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CurrentPolicy"))) { #optional property not found
            $CurrentPolicy = $null
        } else {
            $CurrentPolicy = $JsonParameters.PSobject.Properties["CurrentPolicy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AllPolicies"))) { #optional property not found
            $AllPolicies = $null
        } else {
            $AllPolicies = $JsonParameters.PSobject.Properties["AllPolicies"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ChangePolicyAssignBy"))) { #optional property not found
            $ChangePolicyAssignBy = $null
        } else {
            $ChangePolicyAssignBy = $JsonParameters.PSobject.Properties["ChangePolicyAssignBy"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StartDateType"))) { #optional property not found
            $StartDateType = $null
        } else {
            $StartDateType = $JsonParameters.PSobject.Properties["StartDateType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceSpecifyDate"))) { #optional property not found
            $ServiceSpecifyDate = $null
        } else {
            $ServiceSpecifyDate = $JsonParameters.PSobject.Properties["ServiceSpecifyDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableLeaseExpired"))) { #optional property not found
            $IsEnableLeaseExpired = $null
        } else {
            $IsEnableLeaseExpired = $JsonParameters.PSobject.Properties["IsEnableLeaseExpired"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseDuration"))) { #optional property not found
            $LeaseDuration = $null
        } else {
            $LeaseDuration = $JsonParameters.PSobject.Properties["LeaseDuration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseDurationType"))) { #optional property not found
            $LeaseDurationType = $null
        } else {
            $LeaseDurationType = $JsonParameters.PSobject.Properties["LeaseDurationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CurrentStartDate"))) { #optional property not found
            $CurrentStartDate = $null
        } else {
            $CurrentStartDate = $JsonParameters.PSobject.Properties["CurrentStartDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsAllowAutoCancel"))) { #optional property not found
            $IsAllowAutoCancel = $null
        } else {
            $IsAllowAutoCancel = $JsonParameters.PSobject.Properties["IsAllowAutoCancel"].value
        }

        $PSO = [PSCustomObject]@{
            "CurrentPolicy" = ${CurrentPolicy}
            "AllPolicies" = ${AllPolicies}
            "ChangePolicyAssignBy" = ${ChangePolicyAssignBy}
            "StartDateType" = ${StartDateType}
            "ServiceSpecifyDate" = ${ServiceSpecifyDate}
            "IsEnableLeaseExpired" = ${IsEnableLeaseExpired}
            "LeaseDuration" = ${LeaseDuration}
            "LeaseDurationType" = ${LeaseDurationType}
            "CurrentStartDate" = ${CurrentStartDate}
            "IsAllowAutoCancel" = ${IsAllowAutoCancel}
        }

        return $PSO
    }

}

