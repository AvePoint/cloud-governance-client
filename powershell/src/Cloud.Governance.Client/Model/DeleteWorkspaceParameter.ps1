#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
DeleteWorkspaceParameter<PSCustomObject>
#>

function New-DeleteWorkspaceParameter {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableRemoveObject} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsSendCancelEmail} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CancelEmailTemplateId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Workspace},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsSelectAllWorkspace} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => DeleteWorkspaceParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "EnableRemoveObject" = ${EnableRemoveObject}
            "IsSendCancelEmail" = ${IsSendCancelEmail}
            "CancelEmailTemplateId" = ${CancelEmailTemplateId}
            "Workspace" = ${Workspace}
            "IsSelectAllWorkspace" = ${IsSelectAllWorkspace}
        }

        return $PSO
    }
}

<#
DeleteWorkspaceParameter<PSCustomObject>
#>
function ConvertFrom-JsonToDeleteWorkspaceParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => DeleteWorkspaceParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in DeleteWorkspaceParameter
        $AllProperties = $("EnableRemoveObject", "IsSendCancelEmail", "CancelEmailTemplateId", "Workspace", "IsSelectAllWorkspace")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableRemoveObject"))) { #optional property not found
            $EnableRemoveObject = $null
        } else {
            $EnableRemoveObject = $JsonParameters.PSobject.Properties["EnableRemoveObject"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsSendCancelEmail"))) { #optional property not found
            $IsSendCancelEmail = $null
        } else {
            $IsSendCancelEmail = $JsonParameters.PSobject.Properties["IsSendCancelEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CancelEmailTemplateId"))) { #optional property not found
            $CancelEmailTemplateId = $null
        } else {
            $CancelEmailTemplateId = $JsonParameters.PSobject.Properties["CancelEmailTemplateId"].value
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
            "EnableRemoveObject" = ${EnableRemoveObject}
            "IsSendCancelEmail" = ${IsSendCancelEmail}
            "CancelEmailTemplateId" = ${CancelEmailTemplateId}
            "Workspace" = ${Workspace}
            "IsSelectAllWorkspace" = ${IsSelectAllWorkspace}
        }

        return $PSO
    }

}

