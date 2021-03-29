#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ConflictResolutionSetting<PSCustomObject>
#>

function New-ConflictResolutionSetting {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ContainerConflictSolution} = "Skip",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsCheckLowerObject} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableContentConflictResolution} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ContentConflictSolution} = "Skip",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AppConflictSolution} = "Skip"
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ConflictResolutionSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ContainerConflictSolution" = ${ContainerConflictSolution}
            "IsCheckLowerObject" = ${IsCheckLowerObject}
            "IsEnableContentConflictResolution" = ${IsEnableContentConflictResolution}
            "ContentConflictSolution" = ${ContentConflictSolution}
            "AppConflictSolution" = ${AppConflictSolution}
        }

        return $PSO
    }
}

<#
ConflictResolutionSetting<PSCustomObject>
#>
function ConvertFrom-JsonToConflictResolutionSetting {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ConflictResolutionSetting' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ConflictResolutionSetting
        $AllProperties = $("ContainerConflictSolution", "IsCheckLowerObject", "IsEnableContentConflictResolution", "ContentConflictSolution", "AppConflictSolution")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ContainerConflictSolution"))) { #optional property not found
            $ContainerConflictSolution = $null
        } else {
            $ContainerConflictSolution = $JsonParameters.PSobject.Properties["ContainerConflictSolution"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsCheckLowerObject"))) { #optional property not found
            $IsCheckLowerObject = $null
        } else {
            $IsCheckLowerObject = $JsonParameters.PSobject.Properties["IsCheckLowerObject"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableContentConflictResolution"))) { #optional property not found
            $IsEnableContentConflictResolution = $null
        } else {
            $IsEnableContentConflictResolution = $JsonParameters.PSobject.Properties["IsEnableContentConflictResolution"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ContentConflictSolution"))) { #optional property not found
            $ContentConflictSolution = $null
        } else {
            $ContentConflictSolution = $JsonParameters.PSobject.Properties["ContentConflictSolution"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AppConflictSolution"))) { #optional property not found
            $AppConflictSolution = $null
        } else {
            $AppConflictSolution = $JsonParameters.PSobject.Properties["AppConflictSolution"].value
        }

        $PSO = [PSCustomObject]@{
            "ContainerConflictSolution" = ${ContainerConflictSolution}
            "IsCheckLowerObject" = ${IsCheckLowerObject}
            "IsEnableContentConflictResolution" = ${IsEnableContentConflictResolution}
            "ContentConflictSolution" = ${ContentConflictSolution}
            "AppConflictSolution" = ${AppConflictSolution}
        }

        return $PSO
    }

}

