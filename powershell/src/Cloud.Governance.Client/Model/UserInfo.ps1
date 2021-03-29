#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
UserInfo<PSCustomObject>
#>

function New-UserInfo {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${IdentityName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UserDisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${DomainGroup} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Department},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MobilePhone},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Manager},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Permission},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsDeleted} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${SecurityToken},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${UserType} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AzureUserType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${LegalPerson} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AuthenticationType} = "LocalSystem",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${AdminCenterUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InviteType} = "User",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Type},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsRegisteredAosGroup} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${IsExternalUser} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsAPIExceptional} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TenantId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Version} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${JobTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UsageLocation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PhysicalDeliveryOfficeName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsOtherTenantUser} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NetworkId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsValidateByProfile} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${ProxyAddresses},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PrincipalType} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Id} = 0,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Title},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Email},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsValid} = $false,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${ExistInAOS} = $false
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => UserInfo' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "IdentityName" = ${IdentityName}
            "UserDisplayName" = ${UserDisplayName}
            "DomainGroup" = ${DomainGroup}
            "Department" = ${Department}
            "MobilePhone" = ${MobilePhone}
            "Manager" = ${Manager}
            "Permission" = ${Permission}
            "IsDeleted" = ${IsDeleted}
            "SecurityToken" = ${SecurityToken}
            "UserType" = ${UserType}
            "AzureUserType" = ${AzureUserType}
            "LegalPerson" = ${LegalPerson}
            "AuthenticationType" = ${AuthenticationType}
            "AdminCenterUrl" = ${AdminCenterUrl}
            "InviteType" = ${InviteType}
            "Type" = ${Type}
            "IsRegisteredAosGroup" = ${IsRegisteredAosGroup}
            "IsExternalUser" = ${IsExternalUser}
            "IsAPIExceptional" = ${IsAPIExceptional}
            "TenantId" = ${TenantId}
            "ObjectId" = ${ObjectId}
            "Version" = ${Version}
            "JobTitle" = ${JobTitle}
            "UsageLocation" = ${UsageLocation}
            "PhysicalDeliveryOfficeName" = ${PhysicalDeliveryOfficeName}
            "IsOtherTenantUser" = ${IsOtherTenantUser}
            "NetworkId" = ${NetworkId}
            "IsValidateByProfile" = ${IsValidateByProfile}
            "ProxyAddresses" = ${ProxyAddresses}
            "PrincipalType" = ${PrincipalType}
            "Id" = ${Id}
            "DisplayName" = ${DisplayName}
            "Title" = ${Title}
            "Email" = ${Email}
            "IsValid" = ${IsValid}
            "ExistInAOS" = ${ExistInAOS}
        }

        return $PSO
    }
}

<#
UserInfo<PSCustomObject>
#>
function ConvertFrom-JsonToUserInfo {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => UserInfo' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in UserInfo
        $AllProperties = $("IdentityName", "UserDisplayName", "DomainGroup", "Department", "MobilePhone", "Manager", "Permission", "IsDeleted", "SecurityToken", "UserType", "AzureUserType", "LegalPerson", "AuthenticationType", "AdminCenterUrl", "InviteType", "Type", "IsRegisteredAosGroup", "IsExternalUser", "IsAPIExceptional", "TenantId", "ObjectId", "Version", "JobTitle", "UsageLocation", "PhysicalDeliveryOfficeName", "IsOtherTenantUser", "NetworkId", "IsValidateByProfile", "ProxyAddresses", "PrincipalType", "Id", "DisplayName", "Title", "Email", "IsValid", "ExistInAOS")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IdentityName"))) { #optional property not found
            $IdentityName = $null
        } else {
            $IdentityName = $JsonParameters.PSobject.Properties["IdentityName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserDisplayName"))) { #optional property not found
            $UserDisplayName = $null
        } else {
            $UserDisplayName = $JsonParameters.PSobject.Properties["UserDisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DomainGroup"))) { #optional property not found
            $DomainGroup = $null
        } else {
            $DomainGroup = $JsonParameters.PSobject.Properties["DomainGroup"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Department"))) { #optional property not found
            $Department = $null
        } else {
            $Department = $JsonParameters.PSobject.Properties["Department"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MobilePhone"))) { #optional property not found
            $MobilePhone = $null
        } else {
            $MobilePhone = $JsonParameters.PSobject.Properties["MobilePhone"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Manager"))) { #optional property not found
            $Manager = $null
        } else {
            $Manager = $JsonParameters.PSobject.Properties["Manager"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Permission"))) { #optional property not found
            $Permission = $null
        } else {
            $Permission = $JsonParameters.PSobject.Properties["Permission"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsDeleted"))) { #optional property not found
            $IsDeleted = $null
        } else {
            $IsDeleted = $JsonParameters.PSobject.Properties["IsDeleted"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SecurityToken"))) { #optional property not found
            $SecurityToken = $null
        } else {
            $SecurityToken = $JsonParameters.PSobject.Properties["SecurityToken"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserType"))) { #optional property not found
            $UserType = $null
        } else {
            $UserType = $JsonParameters.PSobject.Properties["UserType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AzureUserType"))) { #optional property not found
            $AzureUserType = $null
        } else {
            $AzureUserType = $JsonParameters.PSobject.Properties["AzureUserType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LegalPerson"))) { #optional property not found
            $LegalPerson = $null
        } else {
            $LegalPerson = $JsonParameters.PSobject.Properties["LegalPerson"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AuthenticationType"))) { #optional property not found
            $AuthenticationType = $null
        } else {
            $AuthenticationType = $JsonParameters.PSobject.Properties["AuthenticationType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdminCenterUrl"))) { #optional property not found
            $AdminCenterUrl = $null
        } else {
            $AdminCenterUrl = $JsonParameters.PSobject.Properties["AdminCenterUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InviteType"))) { #optional property not found
            $InviteType = $null
        } else {
            $InviteType = $JsonParameters.PSobject.Properties["InviteType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsRegisteredAosGroup"))) { #optional property not found
            $IsRegisteredAosGroup = $null
        } else {
            $IsRegisteredAosGroup = $JsonParameters.PSobject.Properties["IsRegisteredAosGroup"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsExternalUser"))) { #optional property not found
            $IsExternalUser = $null
        } else {
            $IsExternalUser = $JsonParameters.PSobject.Properties["IsExternalUser"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsAPIExceptional"))) { #optional property not found
            $IsAPIExceptional = $null
        } else {
            $IsAPIExceptional = $JsonParameters.PSobject.Properties["IsAPIExceptional"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TenantId"))) { #optional property not found
            $TenantId = $null
        } else {
            $TenantId = $JsonParameters.PSobject.Properties["TenantId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectId"))) { #optional property not found
            $ObjectId = $null
        } else {
            $ObjectId = $JsonParameters.PSobject.Properties["ObjectId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Version"))) { #optional property not found
            $Version = $null
        } else {
            $Version = $JsonParameters.PSobject.Properties["Version"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "JobTitle"))) { #optional property not found
            $JobTitle = $null
        } else {
            $JobTitle = $JsonParameters.PSobject.Properties["JobTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UsageLocation"))) { #optional property not found
            $UsageLocation = $null
        } else {
            $UsageLocation = $JsonParameters.PSobject.Properties["UsageLocation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhysicalDeliveryOfficeName"))) { #optional property not found
            $PhysicalDeliveryOfficeName = $null
        } else {
            $PhysicalDeliveryOfficeName = $JsonParameters.PSobject.Properties["PhysicalDeliveryOfficeName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsOtherTenantUser"))) { #optional property not found
            $IsOtherTenantUser = $null
        } else {
            $IsOtherTenantUser = $JsonParameters.PSobject.Properties["IsOtherTenantUser"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NetworkId"))) { #optional property not found
            $NetworkId = $null
        } else {
            $NetworkId = $JsonParameters.PSobject.Properties["NetworkId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsValidateByProfile"))) { #optional property not found
            $IsValidateByProfile = $null
        } else {
            $IsValidateByProfile = $JsonParameters.PSobject.Properties["IsValidateByProfile"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProxyAddresses"))) { #optional property not found
            $ProxyAddresses = $null
        } else {
            $ProxyAddresses = $JsonParameters.PSobject.Properties["ProxyAddresses"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PrincipalType"))) { #optional property not found
            $PrincipalType = $null
        } else {
            $PrincipalType = $JsonParameters.PSobject.Properties["PrincipalType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayName"))) { #optional property not found
            $DisplayName = $null
        } else {
            $DisplayName = $JsonParameters.PSobject.Properties["DisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Title"))) { #optional property not found
            $Title = $null
        } else {
            $Title = $JsonParameters.PSobject.Properties["Title"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Email"))) { #optional property not found
            $Email = $null
        } else {
            $Email = $JsonParameters.PSobject.Properties["Email"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsValid"))) { #optional property not found
            $IsValid = $null
        } else {
            $IsValid = $JsonParameters.PSobject.Properties["IsValid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExistInAOS"))) { #optional property not found
            $ExistInAOS = $null
        } else {
            $ExistInAOS = $JsonParameters.PSobject.Properties["ExistInAOS"].value
        }

        $PSO = [PSCustomObject]@{
            "IdentityName" = ${IdentityName}
            "UserDisplayName" = ${UserDisplayName}
            "DomainGroup" = ${DomainGroup}
            "Department" = ${Department}
            "MobilePhone" = ${MobilePhone}
            "Manager" = ${Manager}
            "Permission" = ${Permission}
            "IsDeleted" = ${IsDeleted}
            "SecurityToken" = ${SecurityToken}
            "UserType" = ${UserType}
            "AzureUserType" = ${AzureUserType}
            "LegalPerson" = ${LegalPerson}
            "AuthenticationType" = ${AuthenticationType}
            "AdminCenterUrl" = ${AdminCenterUrl}
            "InviteType" = ${InviteType}
            "Type" = ${Type}
            "IsRegisteredAosGroup" = ${IsRegisteredAosGroup}
            "IsExternalUser" = ${IsExternalUser}
            "IsAPIExceptional" = ${IsAPIExceptional}
            "TenantId" = ${TenantId}
            "ObjectId" = ${ObjectId}
            "Version" = ${Version}
            "JobTitle" = ${JobTitle}
            "UsageLocation" = ${UsageLocation}
            "PhysicalDeliveryOfficeName" = ${PhysicalDeliveryOfficeName}
            "IsOtherTenantUser" = ${IsOtherTenantUser}
            "NetworkId" = ${NetworkId}
            "IsValidateByProfile" = ${IsValidateByProfile}
            "ProxyAddresses" = ${ProxyAddresses}
            "PrincipalType" = ${PrincipalType}
            "Id" = ${Id}
            "DisplayName" = ${DisplayName}
            "Title" = ${Title}
            "Email" = ${Email}
            "IsValid" = ${IsValid}
            "ExistInAOS" = ${ExistInAOS}
        }

        return $PSO
    }

}

