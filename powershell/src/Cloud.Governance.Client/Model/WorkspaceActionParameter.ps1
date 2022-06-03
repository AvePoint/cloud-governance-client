#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
WorkspaceActionParameter<PSCustomObject>
#>

function New-WorkspaceActionParameter {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Workspace},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsSelectAllWorkspace} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => WorkspaceActionParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Workspace" = ${Workspace}
            "IsSelectAllWorkspace" = ${IsSelectAllWorkspace}
        }

        return $PSO
    }
}

<#
WorkspaceActionParameter<PSCustomObject>
#>
function ConvertFrom-JsonToWorkspaceActionParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => WorkspaceActionParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in WorkspaceActionParameter
        $AllProperties = $("Workspace", "IsSelectAllWorkspace")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Workspace"))) { #optional property not found
            $Workspace = $null
        } else {
            $Workspace = $JsonParameters.PSobject.Properties["Workspace"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsSelectAllWorkspace"))) { #optional property not found
            $IsSelectAllWorkspace = $null
        } else {
            $IsSelectAllWorkspace = $JsonParameters.PSobject.Properties["IsSelectAllWorkspace"].value
        }

        $PSO = [PSCustomObject]@{
            "Workspace" = ${Workspace}
            "IsSelectAllWorkspace" = ${IsSelectAllWorkspace}
        }

        return $PSO
    }

}

