#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
HookMessageList<PSCustomObject>
#>

function New-HookMessageList {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RenewalTaskCompleted},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TaskCreated},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AutoImportCompleted},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RequestsRelated},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LifecycleHookMessage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ElectionHookMessage}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => HookMessageList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "RenewalTaskCompleted" = ${RenewalTaskCompleted}
            "TaskCreated" = ${TaskCreated}
            "AutoImportCompleted" = ${AutoImportCompleted}
            "RequestsRelated" = ${RequestsRelated}
            "LifecycleHookMessage" = ${LifecycleHookMessage}
            "ElectionHookMessage" = ${ElectionHookMessage}
        }

        return $PSO
    }
}

<#
HookMessageList<PSCustomObject>
#>
function ConvertFrom-JsonToHookMessageList {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => HookMessageList' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in HookMessageList
        $AllProperties = $("RenewalTaskCompleted", "TaskCreated", "AutoImportCompleted", "RequestsRelated", "LifecycleHookMessage", "ElectionHookMessage")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RenewalTaskCompleted"))) { #optional property not found
            $RenewalTaskCompleted = $null
        } else {
            $RenewalTaskCompleted = $JsonParameters.PSobject.Properties["RenewalTaskCompleted"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TaskCreated"))) { #optional property not found
            $TaskCreated = $null
        } else {
            $TaskCreated = $JsonParameters.PSobject.Properties["TaskCreated"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoImportCompleted"))) { #optional property not found
            $AutoImportCompleted = $null
        } else {
            $AutoImportCompleted = $JsonParameters.PSobject.Properties["AutoImportCompleted"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequestsRelated"))) { #optional property not found
            $RequestsRelated = $null
        } else {
            $RequestsRelated = $JsonParameters.PSobject.Properties["RequestsRelated"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LifecycleHookMessage"))) { #optional property not found
            $LifecycleHookMessage = $null
        } else {
            $LifecycleHookMessage = $JsonParameters.PSobject.Properties["LifecycleHookMessage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ElectionHookMessage"))) { #optional property not found
            $ElectionHookMessage = $null
        } else {
            $ElectionHookMessage = $JsonParameters.PSobject.Properties["ElectionHookMessage"].value
        }

        $PSO = [PSCustomObject]@{
            "RenewalTaskCompleted" = ${RenewalTaskCompleted}
            "TaskCreated" = ${TaskCreated}
            "AutoImportCompleted" = ${AutoImportCompleted}
            "RequestsRelated" = ${RequestsRelated}
            "LifecycleHookMessage" = ${LifecycleHookMessage}
            "ElectionHookMessage" = ${ElectionHookMessage}
        }

        return $PSO
    }

}

