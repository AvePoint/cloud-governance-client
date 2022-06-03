#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
WorkspaceSendCancelEmailParameter<PSCustomObject>
#>

function New-WorkspaceSendCancelEmailParameter {
    [CmdletBinding()]
    Param (
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
        'Creating PSCustomObject: Cloud.Governance.Client => WorkspaceSendCancelEmailParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsSendCancelEmail" = ${IsSendCancelEmail}
            "CancelEmailTemplateId" = ${CancelEmailTemplateId}
            "Workspace" = ${Workspace}
            "IsSelectAllWorkspace" = ${IsSelectAllWorkspace}
        }

        return $PSO
    }
}

<#
WorkspaceSendCancelEmailParameter<PSCustomObject>
#>
function ConvertFrom-JsonToWorkspaceSendCancelEmailParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => WorkspaceSendCancelEmailParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in WorkspaceSendCancelEmailParameter
        $AllProperties = $("IsSendCancelEmail", "CancelEmailTemplateId", "Workspace", "IsSelectAllWorkspace")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
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
            "IsSendCancelEmail" = ${IsSendCancelEmail}
            "CancelEmailTemplateId" = ${CancelEmailTemplateId}
            "Workspace" = ${Workspace}
            "IsSelectAllWorkspace" = ${IsSelectAllWorkspace}
        }

        return $PSO
    }

}

