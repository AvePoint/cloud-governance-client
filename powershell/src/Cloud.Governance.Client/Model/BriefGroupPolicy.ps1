#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
BriefGroupPolicy<PSCustomObject>
#>

function New-BriefGroupPolicy {
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
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableLeaseExpiration},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${LeaseExpiredInterval},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LeaseExpiredIntervalType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableManageGroupSharing},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableInviteAuthorizedGuestUser},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${EnableInviteGuestUser}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => BriefGroupPolicy' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "EnableLeaseExpiration" = ${EnableLeaseExpiration}
            "LeaseExpiredInterval" = ${LeaseExpiredInterval}
            "LeaseExpiredIntervalType" = ${LeaseExpiredIntervalType}
            "EnableManageGroupSharing" = ${EnableManageGroupSharing}
            "EnableInviteAuthorizedGuestUser" = ${EnableInviteAuthorizedGuestUser}
            "EnableInviteGuestUser" = ${EnableInviteGuestUser}
        }

        return $PSO
    }
}

<#
BriefGroupPolicy<PSCustomObject>
#>
function ConvertFrom-JsonToBriefGroupPolicy {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => BriefGroupPolicy' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in BriefGroupPolicy
        $AllProperties = $("Id", "Name", "Description", "EnableLeaseExpiration", "LeaseExpiredInterval", "LeaseExpiredIntervalType", "EnableManageGroupSharing", "EnableInviteAuthorizedGuestUser", "EnableInviteGuestUser")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableLeaseExpiration"))) { #optional property not found
            $EnableLeaseExpiration = $null
        } else {
            $EnableLeaseExpiration = $JsonParameters.PSobject.Properties["EnableLeaseExpiration"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseExpiredInterval"))) { #optional property not found
            $LeaseExpiredInterval = $null
        } else {
            $LeaseExpiredInterval = $JsonParameters.PSobject.Properties["LeaseExpiredInterval"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LeaseExpiredIntervalType"))) { #optional property not found
            $LeaseExpiredIntervalType = $null
        } else {
            $LeaseExpiredIntervalType = $JsonParameters.PSobject.Properties["LeaseExpiredIntervalType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableManageGroupSharing"))) { #optional property not found
            $EnableManageGroupSharing = $null
        } else {
            $EnableManageGroupSharing = $JsonParameters.PSobject.Properties["EnableManageGroupSharing"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableInviteAuthorizedGuestUser"))) { #optional property not found
            $EnableInviteAuthorizedGuestUser = $null
        } else {
            $EnableInviteAuthorizedGuestUser = $JsonParameters.PSobject.Properties["EnableInviteAuthorizedGuestUser"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnableInviteGuestUser"))) { #optional property not found
            $EnableInviteGuestUser = $null
        } else {
            $EnableInviteGuestUser = $JsonParameters.PSobject.Properties["EnableInviteGuestUser"].value
        }

        $PSO = [PSCustomObject]@{
            "Id" = ${Id}
            "Name" = ${Name}
            "Description" = ${Description}
            "EnableLeaseExpiration" = ${EnableLeaseExpiration}
            "LeaseExpiredInterval" = ${LeaseExpiredInterval}
            "LeaseExpiredIntervalType" = ${LeaseExpiredIntervalType}
            "EnableManageGroupSharing" = ${EnableManageGroupSharing}
            "EnableInviteAuthorizedGuestUser" = ${EnableInviteAuthorizedGuestUser}
            "EnableInviteGuestUser" = ${EnableInviteGuestUser}
        }

        return $PSO
    }

}

