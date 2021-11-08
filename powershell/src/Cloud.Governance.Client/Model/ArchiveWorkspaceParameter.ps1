#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ArchiveWorkspaceParameter<PSCustomObject>
#>

function New-ArchiveWorkspaceParameter {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ArchiveProfile},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${WorkspaceType} = "Site",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsSendCancelEmail} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${CancelEmailTemplateId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Workspace}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ArchiveWorkspaceParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ArchiveProfile" = ${ArchiveProfile}
            "WorkspaceType" = ${WorkspaceType}
            "IsSendCancelEmail" = ${IsSendCancelEmail}
            "CancelEmailTemplateId" = ${CancelEmailTemplateId}
            "Workspace" = ${Workspace}
        }

        return $PSO
    }
}

<#
ArchiveWorkspaceParameter<PSCustomObject>
#>
function ConvertFrom-JsonToArchiveWorkspaceParameter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ArchiveWorkspaceParameter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ArchiveWorkspaceParameter
        $AllProperties = $("ArchiveProfile", "WorkspaceType", "IsSendCancelEmail", "CancelEmailTemplateId", "Workspace")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ArchiveProfile"))) { #optional property not found
            $ArchiveProfile = $null
        } else {
            $ArchiveProfile = $JsonParameters.PSobject.Properties["ArchiveProfile"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WorkspaceType"))) { #optional property not found
            $WorkspaceType = $null
        } else {
            $WorkspaceType = $JsonParameters.PSobject.Properties["WorkspaceType"].value
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

        $PSO = [PSCustomObject]@{
            "ArchiveProfile" = ${ArchiveProfile}
            "WorkspaceType" = ${WorkspaceType}
            "IsSendCancelEmail" = ${IsSendCancelEmail}
            "CancelEmailTemplateId" = ${CancelEmailTemplateId}
            "Workspace" = ${Workspace}
        }

        return $PSO
    }

}

