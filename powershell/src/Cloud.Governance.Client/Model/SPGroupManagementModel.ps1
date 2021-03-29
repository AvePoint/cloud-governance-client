#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
SPGroupManagementModel<PSCustomObject>
#>

function New-SPGroupManagementModel {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Id} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Owner},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Members},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SpGroupViewType} = "GroupMembers",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SpGroupEditType} = "GroupOwner",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Permissions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Action} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAllowJoinOrLeaveRequest} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAutoAcceptRequest} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SendMembershipRequestEmailAddress},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsTemporaryGroup} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${RoleID}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => SPGroupManagementModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Owner" = ${Owner}
            "Members" = ${Members}
            "SpGroupViewType" = ${SpGroupViewType}
            "SpGroupEditType" = ${SpGroupEditType}
            "Permissions" = ${Permissions}
            "Action" = ${Action}
            "IsAllowJoinOrLeaveRequest" = ${IsAllowJoinOrLeaveRequest}
            "IsAutoAcceptRequest" = ${IsAutoAcceptRequest}
            "SendMembershipRequestEmailAddress" = ${SendMembershipRequestEmailAddress}
            "IsTemporaryGroup" = ${IsTemporaryGroup}
            "RoleID" = ${RoleID}
        }

        return $PSO
    }
}

<#
SPGroupManagementModel<PSCustomObject>
#>
function ConvertFrom-JsonToSPGroupManagementModel {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => SPGroupManagementModel' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in SPGroupManagementModel
        $AllProperties = $("Id", "Name", "Description", "Owner", "Members", "SpGroupViewType", "SpGroupEditType", "Permissions", "Action", "IsAllowJoinOrLeaveRequest", "IsAutoAcceptRequest", "SendMembershipRequestEmailAddress", "IsTemporaryGroup", "RoleID")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Owner"))) { #optional property not found
            $Owner = $null
        } else {
            $Owner = $JsonParameters.PSobject.Properties["Owner"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Members"))) { #optional property not found
            $Members = $null
        } else {
            $Members = $JsonParameters.PSobject.Properties["Members"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SpGroupViewType"))) { #optional property not found
            $SpGroupViewType = $null
        } else {
            $SpGroupViewType = $JsonParameters.PSobject.Properties["SpGroupViewType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SpGroupEditType"))) { #optional property not found
            $SpGroupEditType = $null
        } else {
            $SpGroupEditType = $JsonParameters.PSobject.Properties["SpGroupEditType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Permissions"))) { #optional property not found
            $Permissions = $null
        } else {
            $Permissions = $JsonParameters.PSobject.Properties["Permissions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Action"))) { #optional property not found
            $Action = $null
        } else {
            $Action = $JsonParameters.PSobject.Properties["Action"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsAllowJoinOrLeaveRequest"))) { #optional property not found
            $IsAllowJoinOrLeaveRequest = $null
        } else {
            $IsAllowJoinOrLeaveRequest = $JsonParameters.PSobject.Properties["IsAllowJoinOrLeaveRequest"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsAutoAcceptRequest"))) { #optional property not found
            $IsAutoAcceptRequest = $null
        } else {
            $IsAutoAcceptRequest = $JsonParameters.PSobject.Properties["IsAutoAcceptRequest"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SendMembershipRequestEmailAddress"))) { #optional property not found
            $SendMembershipRequestEmailAddress = $null
        } else {
            $SendMembershipRequestEmailAddress = $JsonParameters.PSobject.Properties["SendMembershipRequestEmailAddress"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsTemporaryGroup"))) { #optional property not found
            $IsTemporaryGroup = $null
        } else {
            $IsTemporaryGroup = $JsonParameters.PSobject.Properties["IsTemporaryGroup"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RoleID"))) { #optional property not found
            $RoleID = $null
        } else {
            $RoleID = $JsonParameters.PSobject.Properties["RoleID"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "Owner" = ${Owner}
            "Members" = ${Members}
            "SpGroupViewType" = ${SpGroupViewType}
            "SpGroupEditType" = ${SpGroupEditType}
            "Permissions" = ${Permissions}
            "Action" = ${Action}
            "IsAllowJoinOrLeaveRequest" = ${IsAllowJoinOrLeaveRequest}
            "IsAutoAcceptRequest" = ${IsAutoAcceptRequest}
            "SendMembershipRequestEmailAddress" = ${SendMembershipRequestEmailAddress}
            "IsTemporaryGroup" = ${IsTemporaryGroup}
            "RoleID" = ${RoleID}
        }

        return $PSO
    }

}

