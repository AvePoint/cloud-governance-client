#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
WorkerJobModel<PSCustomObject>
#>

function New-WorkerJobModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TenantId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Type},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Method},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Params},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${UpdateTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsTimer} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Status} = "Created",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${StatusDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Message},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Priority} = "Lowest",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PriorityDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${InstanceId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${IntervalSeconds} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${NextRunTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${JobType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ServiceType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceTypeDescription}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => WorkerJobModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "TenantId" = ${TenantId}
            "Name" = ${Name}
            "Type" = ${Type}
            "Method" = ${Method}
            "Params" = ${Params}
            "UpdateTime" = ${UpdateTime}
            "IsTimer" = ${IsTimer}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "Message" = ${Message}
            "Priority" = ${Priority}
            "PriorityDescription" = ${PriorityDescription}
            "InstanceId" = ${InstanceId}
            "IntervalSeconds" = ${IntervalSeconds}
            "NextRunTime" = ${NextRunTime}
            "JobType" = ${JobType}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
        }

        return $PSO
    }
}

<#
WorkerJobModel<PSCustomObject>
#>
function ConvertFrom-JsonToWorkerJobModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => WorkerJobModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in WorkerJobModel
        $AllProperties = $("Id", "TenantId", "Name", "Type", "Method", "Params", "UpdateTime", "IsTimer", "Status", "StatusDescription", "Message", "Priority", "PriorityDescription", "InstanceId", "IntervalSeconds", "NextRunTime", "JobType", "ServiceType", "ServiceTypeDescription")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TenantId"))) { #optional property not found
            $TenantId = $null
        } else {
            $TenantId = $JsonParameters.PSobject.Properties["TenantId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Method"))) { #optional property not found
            $Method = $null
        } else {
            $Method = $JsonParameters.PSobject.Properties["Method"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Params"))) { #optional property not found
            $Params = $null
        } else {
            $Params = $JsonParameters.PSobject.Properties["Params"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UpdateTime"))) { #optional property not found
            $UpdateTime = $null
        } else {
            $UpdateTime = $JsonParameters.PSobject.Properties["UpdateTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsTimer"))) { #optional property not found
            $IsTimer = $null
        } else {
            $IsTimer = $JsonParameters.PSobject.Properties["IsTimer"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StatusDescription"))) { #optional property not found
            $StatusDescription = $null
        } else {
            $StatusDescription = $JsonParameters.PSobject.Properties["StatusDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Message"))) { #optional property not found
            $Message = $null
        } else {
            $Message = $JsonParameters.PSobject.Properties["Message"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Priority"))) { #optional property not found
            $Priority = $null
        } else {
            $Priority = $JsonParameters.PSobject.Properties["Priority"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PriorityDescription"))) { #optional property not found
            $PriorityDescription = $null
        } else {
            $PriorityDescription = $JsonParameters.PSobject.Properties["PriorityDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InstanceId"))) { #optional property not found
            $InstanceId = $null
        } else {
            $InstanceId = $JsonParameters.PSobject.Properties["InstanceId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IntervalSeconds"))) { #optional property not found
            $IntervalSeconds = $null
        } else {
            $IntervalSeconds = $JsonParameters.PSobject.Properties["IntervalSeconds"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NextRunTime"))) { #optional property not found
            $NextRunTime = $null
        } else {
            $NextRunTime = $JsonParameters.PSobject.Properties["NextRunTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "JobType"))) { #optional property not found
            $JobType = $null
        } else {
            $JobType = $JsonParameters.PSobject.Properties["JobType"].value
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

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "TenantId" = ${TenantId}
            "Name" = ${Name}
            "Type" = ${Type}
            "Method" = ${Method}
            "Params" = ${Params}
            "UpdateTime" = ${UpdateTime}
            "IsTimer" = ${IsTimer}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "Message" = ${Message}
            "Priority" = ${Priority}
            "PriorityDescription" = ${PriorityDescription}
            "InstanceId" = ${InstanceId}
            "IntervalSeconds" = ${IntervalSeconds}
            "NextRunTime" = ${NextRunTime}
            "JobType" = ${JobType}
            "ServiceType" = ${ServiceType}
            "ServiceTypeDescription" = ${ServiceTypeDescription}
        }

        return $PSO
    }

}

