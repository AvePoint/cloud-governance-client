#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ApiTaskDynamicProperties<PSCustomObject>
#>

function New-ApiTaskDynamicProperties {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${None},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SecondaryContact},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExpirationDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupOwners},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AutoTaskActionHistories},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InactivityThresholdDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupEmail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PolicyName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrimaryAdministrator},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteTemplate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SiteDescription},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Requester},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${IsTeam},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupOwnersStr},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${TenantId}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ApiTaskDynamicProperties' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "None" = ${None}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "SiteId" = ${SiteId}
            "SiteUrl" = ${SiteUrl}
            "GroupName" = ${GroupName}
            "ExpirationDate" = ${ExpirationDate}
            "GroupOwners" = ${GroupOwners}
            "AutoTaskActionHistories" = ${AutoTaskActionHistories}
            "InactivityThresholdDate" = ${InactivityThresholdDate}
            "GroupEmail" = ${GroupEmail}
            "GroupId" = ${GroupId}
            "PolicyName" = ${PolicyName}
            "PrimaryAdministrator" = ${PrimaryAdministrator}
            "SiteTemplate" = ${SiteTemplate}
            "SiteTitle" = ${SiteTitle}
            "SiteDescription" = ${SiteDescription}
            "Requester" = ${Requester}
            "IsTeam" = ${IsTeam}
            "GroupOwnersStr" = ${GroupOwnersStr}
            "TenantId" = ${TenantId}
        }

        return $PSO
    }
}

<#
ApiTaskDynamicProperties<PSCustomObject>
#>
function ConvertFrom-JsonToApiTaskDynamicProperties {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ApiTaskDynamicProperties' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ApiTaskDynamicProperties
        $AllProperties = $("None", "PrimaryContact", "SecondaryContact", "SiteId", "SiteUrl", "GroupName", "ExpirationDate", "GroupOwners", "AutoTaskActionHistories", "InactivityThresholdDate", "GroupEmail", "GroupId", "PolicyName", "PrimaryAdministrator", "SiteTemplate", "SiteTitle", "SiteDescription", "Requester", "IsTeam", "GroupOwnersStr", "TenantId")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "None"))) { #optional property not found
            $None = $null
        } else {
            $None = $JsonParameters.PSobject.Properties["None"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryContact"))) { #optional property not found
            $PrimaryContact = $null
        } else {
            $PrimaryContact = $JsonParameters.PSobject.Properties["PrimaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecondaryContact"))) { #optional property not found
            $SecondaryContact = $null
        } else {
            $SecondaryContact = $JsonParameters.PSobject.Properties["SecondaryContact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteId"))) { #optional property not found
            $SiteId = $null
        } else {
            $SiteId = $JsonParameters.PSobject.Properties["SiteId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteUrl"))) { #optional property not found
            $SiteUrl = $null
        } else {
            $SiteUrl = $JsonParameters.PSobject.Properties["SiteUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupName"))) { #optional property not found
            $GroupName = $null
        } else {
            $GroupName = $JsonParameters.PSobject.Properties["GroupName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExpirationDate"))) { #optional property not found
            $ExpirationDate = $null
        } else {
            $ExpirationDate = $JsonParameters.PSobject.Properties["ExpirationDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupOwners"))) { #optional property not found
            $GroupOwners = $null
        } else {
            $GroupOwners = $JsonParameters.PSobject.Properties["GroupOwners"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoTaskActionHistories"))) { #optional property not found
            $AutoTaskActionHistories = $null
        } else {
            $AutoTaskActionHistories = $JsonParameters.PSobject.Properties["AutoTaskActionHistories"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InactivityThresholdDate"))) { #optional property not found
            $InactivityThresholdDate = $null
        } else {
            $InactivityThresholdDate = $JsonParameters.PSobject.Properties["InactivityThresholdDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupEmail"))) { #optional property not found
            $GroupEmail = $null
        } else {
            $GroupEmail = $JsonParameters.PSobject.Properties["GroupEmail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupId"))) { #optional property not found
            $GroupId = $null
        } else {
            $GroupId = $JsonParameters.PSobject.Properties["GroupId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PolicyName"))) { #optional property not found
            $PolicyName = $null
        } else {
            $PolicyName = $JsonParameters.PSobject.Properties["PolicyName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrimaryAdministrator"))) { #optional property not found
            $PrimaryAdministrator = $null
        } else {
            $PrimaryAdministrator = $JsonParameters.PSobject.Properties["PrimaryAdministrator"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteTemplate"))) { #optional property not found
            $SiteTemplate = $null
        } else {
            $SiteTemplate = $JsonParameters.PSobject.Properties["SiteTemplate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteTitle"))) { #optional property not found
            $SiteTitle = $null
        } else {
            $SiteTitle = $JsonParameters.PSobject.Properties["SiteTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SiteDescription"))) { #optional property not found
            $SiteDescription = $null
        } else {
            $SiteDescription = $JsonParameters.PSobject.Properties["SiteDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Requester"))) { #optional property not found
            $Requester = $null
        } else {
            $Requester = $JsonParameters.PSobject.Properties["Requester"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsTeam"))) { #optional property not found
            $IsTeam = $null
        } else {
            $IsTeam = $JsonParameters.PSobject.Properties["IsTeam"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupOwnersStr"))) { #optional property not found
            $GroupOwnersStr = $null
        } else {
            $GroupOwnersStr = $JsonParameters.PSobject.Properties["GroupOwnersStr"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TenantId"))) { #optional property not found
            $TenantId = $null
        } else {
            $TenantId = $JsonParameters.PSobject.Properties["TenantId"].value
        }

        $PSO = [PSCustomObject]@{
            "None" = ${None}
            "PrimaryContact" = ${PrimaryContact}
            "SecondaryContact" = ${SecondaryContact}
            "SiteId" = ${SiteId}
            "SiteUrl" = ${SiteUrl}
            "GroupName" = ${GroupName}
            "ExpirationDate" = ${ExpirationDate}
            "GroupOwners" = ${GroupOwners}
            "AutoTaskActionHistories" = ${AutoTaskActionHistories}
            "InactivityThresholdDate" = ${InactivityThresholdDate}
            "GroupEmail" = ${GroupEmail}
            "GroupId" = ${GroupId}
            "PolicyName" = ${PolicyName}
            "PrimaryAdministrator" = ${PrimaryAdministrator}
            "SiteTemplate" = ${SiteTemplate}
            "SiteTitle" = ${SiteTitle}
            "SiteDescription" = ${SiteDescription}
            "Requester" = ${Requester}
            "IsTeam" = ${IsTeam}
            "GroupOwnersStr" = ${GroupOwnersStr}
            "TenantId" = ${TenantId}
        }

        return $PSO
    }

}

