#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
CustomActionSettings<PSCustomObject>
#>

function New-CustomActionSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${BeforeApprovalProcessExecution},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AfterApprovalProcessExecution},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PostExecution},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${BeforeSubmission},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${WhenErrorTaskGenerated}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => CustomActionSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "BeforeApprovalProcessExecution" = ${BeforeApprovalProcessExecution}
            "AfterApprovalProcessExecution" = ${AfterApprovalProcessExecution}
            "PostExecution" = ${PostExecution}
            "BeforeSubmission" = ${BeforeSubmission}
            "WhenErrorTaskGenerated" = ${WhenErrorTaskGenerated}
        }

        return $PSO
    }
}

<#
CustomActionSettings<PSCustomObject>
#>
function ConvertFrom-JsonToCustomActionSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => CustomActionSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in CustomActionSettings
        $AllProperties = $("BeforeApprovalProcessExecution", "AfterApprovalProcessExecution", "PostExecution", "BeforeSubmission", "WhenErrorTaskGenerated")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BeforeApprovalProcessExecution"))) { #optional property not found
            $BeforeApprovalProcessExecution = $null
        } else {
            $BeforeApprovalProcessExecution = $JsonParameters.PSobject.Properties["BeforeApprovalProcessExecution"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AfterApprovalProcessExecution"))) { #optional property not found
            $AfterApprovalProcessExecution = $null
        } else {
            $AfterApprovalProcessExecution = $JsonParameters.PSobject.Properties["AfterApprovalProcessExecution"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PostExecution"))) { #optional property not found
            $PostExecution = $null
        } else {
            $PostExecution = $JsonParameters.PSobject.Properties["PostExecution"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BeforeSubmission"))) { #optional property not found
            $BeforeSubmission = $null
        } else {
            $BeforeSubmission = $JsonParameters.PSobject.Properties["BeforeSubmission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WhenErrorTaskGenerated"))) { #optional property not found
            $WhenErrorTaskGenerated = $null
        } else {
            $WhenErrorTaskGenerated = $JsonParameters.PSobject.Properties["WhenErrorTaskGenerated"].value
        }

        $PSO = [PSCustomObject]@{
            "BeforeApprovalProcessExecution" = ${BeforeApprovalProcessExecution}
            "AfterApprovalProcessExecution" = ${AfterApprovalProcessExecution}
            "PostExecution" = ${PostExecution}
            "BeforeSubmission" = ${BeforeSubmission}
            "WhenErrorTaskGenerated" = ${WhenErrorTaskGenerated}
        }

        return $PSO
    }

}

