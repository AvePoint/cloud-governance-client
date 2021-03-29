#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
WorkerJobGridModel<PSCustomObject>
#>

function New-WorkerJobGridModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
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
        [System.Nullable[System.DateTime]]
        ${UpdateTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${NextRunTime},
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
        [System.Nullable[Int32]]
        ${IntervalSeconds} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${JobType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${JobTypeDescription}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => WorkerJobGridModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Type" = ${Type}
            "Method" = ${Method}
            "UpdateTime" = ${UpdateTime}
            "NextRunTime" = ${NextRunTime}
            "IsTimer" = ${IsTimer}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "Message" = ${Message}
            "Priority" = ${Priority}
            "PriorityDescription" = ${PriorityDescription}
            "IntervalSeconds" = ${IntervalSeconds}
            "JobType" = ${JobType}
            "JobTypeDescription" = ${JobTypeDescription}
        }

        return $PSO
    }
}

<#
WorkerJobGridModel<PSCustomObject>
#>
function ConvertFrom-JsonToWorkerJobGridModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => WorkerJobGridModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in WorkerJobGridModel
        $AllProperties = $("Id", "Name", "Type", "Method", "UpdateTime", "NextRunTime", "IsTimer", "Status", "StatusDescription", "Message", "Priority", "PriorityDescription", "IntervalSeconds", "JobType", "JobTypeDescription")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UpdateTime"))) { #optional property not found
            $UpdateTime = $null
        } else {
            $UpdateTime = $JsonParameters.PSobject.Properties["UpdateTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NextRunTime"))) { #optional property not found
            $NextRunTime = $null
        } else {
            $NextRunTime = $JsonParameters.PSobject.Properties["NextRunTime"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IntervalSeconds"))) { #optional property not found
            $IntervalSeconds = $null
        } else {
            $IntervalSeconds = $JsonParameters.PSobject.Properties["IntervalSeconds"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "JobType"))) { #optional property not found
            $JobType = $null
        } else {
            $JobType = $JsonParameters.PSobject.Properties["JobType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "JobTypeDescription"))) { #optional property not found
            $JobTypeDescription = $null
        } else {
            $JobTypeDescription = $JsonParameters.PSobject.Properties["JobTypeDescription"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Type" = ${Type}
            "Method" = ${Method}
            "UpdateTime" = ${UpdateTime}
            "NextRunTime" = ${NextRunTime}
            "IsTimer" = ${IsTimer}
            "Status" = ${Status}
            "StatusDescription" = ${StatusDescription}
            "Message" = ${Message}
            "Priority" = ${Priority}
            "PriorityDescription" = ${PriorityDescription}
            "IntervalSeconds" = ${IntervalSeconds}
            "JobType" = ${JobType}
            "JobTypeDescription" = ${JobTypeDescription}
        }

        return $PSO
    }

}

