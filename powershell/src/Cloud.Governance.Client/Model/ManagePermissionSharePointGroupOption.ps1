#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ManagePermissionSharePointGroupOption<PSCustomObject>
#>

function New-ManagePermissionSharePointGroupOption {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableCreateSPGroup},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableDeleteSPGroup},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableManageGroupSettings},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsEnableManageGroupMembers},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupOwner},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupOwnerAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SpGroupViewType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SpGroupEditType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SpGroupOptionAssignBy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAllowJoinOrLeaveRequest},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAutoAcceptRequest},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SendMembershipRequestEmailAddress},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GroupRequestAssignBy}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ManagePermissionSharePointGroupOption' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IsEnableCreateSPGroup" = ${IsEnableCreateSPGroup}
            "IsEnableDeleteSPGroup" = ${IsEnableDeleteSPGroup}
            "IsEnableManageGroupSettings" = ${IsEnableManageGroupSettings}
            "IsEnableManageGroupMembers" = ${IsEnableManageGroupMembers}
            "GroupOwner" = ${GroupOwner}
            "GroupOwnerAssignBy" = ${GroupOwnerAssignBy}
            "SpGroupViewType" = ${SpGroupViewType}
            "SpGroupEditType" = ${SpGroupEditType}
            "SpGroupOptionAssignBy" = ${SpGroupOptionAssignBy}
            "IsAllowJoinOrLeaveRequest" = ${IsAllowJoinOrLeaveRequest}
            "IsAutoAcceptRequest" = ${IsAutoAcceptRequest}
            "SendMembershipRequestEmailAddress" = ${SendMembershipRequestEmailAddress}
            "GroupRequestAssignBy" = ${GroupRequestAssignBy}
        }

        return $PSO
    }
}

<#
ManagePermissionSharePointGroupOption<PSCustomObject>
#>
function ConvertFrom-JsonToManagePermissionSharePointGroupOption {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ManagePermissionSharePointGroupOption' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ManagePermissionSharePointGroupOption
        $AllProperties = $("IsEnableCreateSPGroup", "IsEnableDeleteSPGroup", "IsEnableManageGroupSettings", "IsEnableManageGroupMembers", "GroupOwner", "GroupOwnerAssignBy", "SpGroupViewType", "SpGroupEditType", "SpGroupOptionAssignBy", "IsAllowJoinOrLeaveRequest", "IsAutoAcceptRequest", "SendMembershipRequestEmailAddress", "GroupRequestAssignBy")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableCreateSPGroup"))) { #optional property not found
            $IsEnableCreateSPGroup = $null
        } else {
            $IsEnableCreateSPGroup = $JsonParameters.PSobject.Properties["IsEnableCreateSPGroup"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableDeleteSPGroup"))) { #optional property not found
            $IsEnableDeleteSPGroup = $null
        } else {
            $IsEnableDeleteSPGroup = $JsonParameters.PSobject.Properties["IsEnableDeleteSPGroup"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableManageGroupSettings"))) { #optional property not found
            $IsEnableManageGroupSettings = $null
        } else {
            $IsEnableManageGroupSettings = $JsonParameters.PSobject.Properties["IsEnableManageGroupSettings"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsEnableManageGroupMembers"))) { #optional property not found
            $IsEnableManageGroupMembers = $null
        } else {
            $IsEnableManageGroupMembers = $JsonParameters.PSobject.Properties["IsEnableManageGroupMembers"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupOwner"))) { #optional property not found
            $GroupOwner = $null
        } else {
            $GroupOwner = $JsonParameters.PSobject.Properties["GroupOwner"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupOwnerAssignBy"))) { #optional property not found
            $GroupOwnerAssignBy = $null
        } else {
            $GroupOwnerAssignBy = $JsonParameters.PSobject.Properties["GroupOwnerAssignBy"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SpGroupOptionAssignBy"))) { #optional property not found
            $SpGroupOptionAssignBy = $null
        } else {
            $SpGroupOptionAssignBy = $JsonParameters.PSobject.Properties["SpGroupOptionAssignBy"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GroupRequestAssignBy"))) { #optional property not found
            $GroupRequestAssignBy = $null
        } else {
            $GroupRequestAssignBy = $JsonParameters.PSobject.Properties["GroupRequestAssignBy"].value
        }

        $PSO = [PSCustomObject]@{
            "IsEnableCreateSPGroup" = ${IsEnableCreateSPGroup}
            "IsEnableDeleteSPGroup" = ${IsEnableDeleteSPGroup}
            "IsEnableManageGroupSettings" = ${IsEnableManageGroupSettings}
            "IsEnableManageGroupMembers" = ${IsEnableManageGroupMembers}
            "GroupOwner" = ${GroupOwner}
            "GroupOwnerAssignBy" = ${GroupOwnerAssignBy}
            "SpGroupViewType" = ${SpGroupViewType}
            "SpGroupEditType" = ${SpGroupEditType}
            "SpGroupOptionAssignBy" = ${SpGroupOptionAssignBy}
            "IsAllowJoinOrLeaveRequest" = ${IsAllowJoinOrLeaveRequest}
            "IsAutoAcceptRequest" = ${IsAutoAcceptRequest}
            "SendMembershipRequestEmailAddress" = ${SendMembershipRequestEmailAddress}
            "GroupRequestAssignBy" = ${GroupRequestAssignBy}
        }

        return $PSO
    }

}

