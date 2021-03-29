#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
WorksapceOngoingTasksModel<PSCustomObject>
#>

function New-WorksapceOngoingTasksModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TaskName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceTypeDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${InstanceId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WorkspaceId}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => WorksapceOngoingTasksModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "TaskName" = ${TaskName}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "InstanceId" = ${InstanceId}
            "WorkspaceId" = ${WorkspaceId}
        }

        return $PSO
    }
}

<#
WorksapceOngoingTasksModel<PSCustomObject>
#>
function ConvertFrom-JsonToWorksapceOngoingTasksModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => WorksapceOngoingTasksModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in WorksapceOngoingTasksModel
        $AllProperties = $("TaskName", "ServiceType", "ServiceTypeDescription", "InstanceId", "WorkspaceId")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TaskName"))) { #optional property not found
            $TaskName = $null
        } else {
            $TaskName = $JsonParameters.PSobject.Properties["TaskName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceType"))) { #optional property not found
            $ServiceType = $null
        } else {
            $ServiceType = $JsonParameters.PSobject.Properties["ServiceType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceTypeDescription"))) { #optional property not found
            $ServiceTypeDescription = $null
        } else {
            $ServiceTypeDescription = $JsonParameters.PSobject.Properties["ServiceTypeDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InstanceId"))) { #optional property not found
            $InstanceId = $null
        } else {
            $InstanceId = $JsonParameters.PSobject.Properties["InstanceId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WorkspaceId"))) { #optional property not found
            $WorkspaceId = $null
        } else {
            $WorkspaceId = $JsonParameters.PSobject.Properties["WorkspaceId"].value
        }

        $PSO = [PSCustomObject]@{
            "TaskName" = ${TaskName}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
            "InstanceId" = ${InstanceId}
            "WorkspaceId" = ${WorkspaceId}
        }

        return $PSO
    }

}

