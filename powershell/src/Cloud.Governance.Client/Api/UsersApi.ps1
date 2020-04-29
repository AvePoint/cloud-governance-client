#
# Cloud Governance Api
# No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
# Version: 1.0
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

check user exists in Aos

.DESCRIPTION

No description available.

.PARAMETER Name
No description available.

.OUTPUTS

Boolean
#>
function Invoke-CheckUserExistsInAOS {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Name}
    )

    Process {
        'Calling method: Invoke-CheckUserExistsInAOS' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json', 'text/json')

        $LocalVarUri = '/users/avepointonlineservices/validate'

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientId"]) {
            $LocalVarHeaderParameters['ClientId'] = $Configuration["ApiKey"]["ClientId"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientSecret"]) {
            $LocalVarHeaderParameters['ClientSecret'] = $Configuration["ApiKey"]["ClientSecret"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["UserPrincipalName"]) {
            $LocalVarHeaderParameters['UserPrincipalName'] = $Configuration["ApiKey"]["UserPrincipalName"]
        }

        $LocalVarResult = Invoke-ApiClient -Method 'GET' `
                                -Uri $LocalVarUri `
                                -Accepts $LocalVarAccepts `
                                -ContentTypes $LocalVarContentTypes `
                                -Body $LocalVarBodyParameter `
                                -HeaderParameters $LocalVarHeaderParameters `
                                -QueryParameters $LocalVarQueryParameters `
                                -FormParameters $LocalVarFormParameters `
                                -CookieParameters $LocalVarCookieParameters `
                                -ReturnType "Boolean"

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

get user's property value by property name from azure ad

.DESCRIPTION

No description available.

.PARAMETER Username
No description available.

.PARAMETER PropertyName
No description available.

.OUTPUTS

StringModel
#>
function Get-AzureAdUserPropertyValue {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Username},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${PropertyName}
    )

    Process {
        'Calling method: Get-AzureAdUserPropertyValue' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json', 'text/json')

        $LocalVarUri = '/users/{username}/azuread/property'
        if (!$Username) {
            throw "Error! The required parameter `Username` missing when calling getAzureAdUserPropertyValue."
        }
        $LocalVarUri = $LocalVarUri.replace('{username}', $Username)

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientId"]) {
            $LocalVarHeaderParameters['ClientId'] = $Configuration["ApiKey"]["ClientId"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientSecret"]) {
            $LocalVarHeaderParameters['ClientSecret'] = $Configuration["ApiKey"]["ClientSecret"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["UserPrincipalName"]) {
            $LocalVarHeaderParameters['UserPrincipalName'] = $Configuration["ApiKey"]["UserPrincipalName"]
        }

        $LocalVarResult = Invoke-ApiClient -Method 'GET' `
                                -Uri $LocalVarUri `
                                -Accepts $LocalVarAccepts `
                                -ContentTypes $LocalVarContentTypes `
                                -Body $LocalVarBodyParameter `
                                -HeaderParameters $LocalVarHeaderParameters `
                                -QueryParameters $LocalVarQueryParameters `
                                -FormParameters $LocalVarFormParameters `
                                -CookieParameters $LocalVarCookieParameters `
                                -ReturnType "StringModel"

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

get user's property value by property name from user profile service

.DESCRIPTION

No description available.

.PARAMETER Username
No description available.

.PARAMETER PropertyName
No description available.

.OUTPUTS

StringModel
#>
function Get-UpsUserPropertyValue {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Username},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${PropertyName}
    )

    Process {
        'Calling method: Get-UpsUserPropertyValue' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json', 'text/json')

        $LocalVarUri = '/users/{username}/userprofile/property'
        if (!$Username) {
            throw "Error! The required parameter `Username` missing when calling getUpsUserPropertyValue."
        }
        $LocalVarUri = $LocalVarUri.replace('{username}', $Username)

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientId"]) {
            $LocalVarHeaderParameters['ClientId'] = $Configuration["ApiKey"]["ClientId"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientSecret"]) {
            $LocalVarHeaderParameters['ClientSecret'] = $Configuration["ApiKey"]["ClientSecret"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["UserPrincipalName"]) {
            $LocalVarHeaderParameters['UserPrincipalName'] = $Configuration["ApiKey"]["UserPrincipalName"]
        }

        $LocalVarResult = Invoke-ApiClient -Method 'GET' `
                                -Uri $LocalVarUri `
                                -Accepts $LocalVarAccepts `
                                -ContentTypes $LocalVarContentTypes `
                                -Body $LocalVarBodyParameter `
                                -HeaderParameters $LocalVarHeaderParameters `
                                -QueryParameters $LocalVarQueryParameters `
                                -FormParameters $LocalVarFormParameters `
                                -CookieParameters $LocalVarCookieParameters `
                                -ReturnType "StringModel"

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

get my basic properties, City, Country, Office, Department, JobTitle,State

.DESCRIPTION

No description available.

.OUTPUTS

None
#>
function Get-UserBasicProperties {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Calling method: Get-UserBasicProperties' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter

        $Configuration = Get-Configuration
        $LocalVarUri = '/users/me/properties'

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientId"]) {
            $LocalVarHeaderParameters['ClientId'] = $Configuration["ApiKey"]["ClientId"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientSecret"]) {
            $LocalVarHeaderParameters['ClientSecret'] = $Configuration["ApiKey"]["ClientSecret"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["UserPrincipalName"]) {
            $LocalVarHeaderParameters['UserPrincipalName'] = $Configuration["ApiKey"]["UserPrincipalName"]
        }

        $LocalVarResult = Invoke-ApiClient -Method 'GET' `
                                -Uri $LocalVarUri `
                                -Accepts $LocalVarAccepts `
                                -ContentTypes $LocalVarContentTypes `
                                -Body $LocalVarBodyParameter `
                                -HeaderParameters $LocalVarHeaderParameters `
                                -QueryParameters $LocalVarQueryParameters `
                                -FormParameters $LocalVarFormParameters `
                                -CookieParameters $LocalVarCookieParameters `
                                -ReturnType ""

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

get my basic property value, Department, Email, DisplayName, Manager

.DESCRIPTION

No description available.

.PARAMETER Name
No description available.

.OUTPUTS

None
#>
function Get-UserBasicPropertyValue {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Name}
    )

    Process {
        'Calling method: Get-UserBasicPropertyValue' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter

        $Configuration = Get-Configuration
        $LocalVarUri = '/users/me/property/{name}'
        if (!$Name) {
            throw "Error! The required parameter `Name` missing when calling getUserBasicPropertyValue."
        }
        $LocalVarUri = $LocalVarUri.replace('{name}', $Name)

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientId"]) {
            $LocalVarHeaderParameters['ClientId'] = $Configuration["ApiKey"]["ClientId"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientSecret"]) {
            $LocalVarHeaderParameters['ClientSecret'] = $Configuration["ApiKey"]["ClientSecret"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["UserPrincipalName"]) {
            $LocalVarHeaderParameters['UserPrincipalName'] = $Configuration["ApiKey"]["UserPrincipalName"]
        }

        $LocalVarResult = Invoke-ApiClient -Method 'GET' `
                                -Uri $LocalVarUri `
                                -Accepts $LocalVarAccepts `
                                -ContentTypes $LocalVarContentTypes `
                                -Body $LocalVarBodyParameter `
                                -HeaderParameters $LocalVarHeaderParameters `
                                -QueryParameters $LocalVarQueryParameters `
                                -FormParameters $LocalVarFormParameters `
                                -CookieParameters $LocalVarCookieParameters `
                                -ReturnType ""

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

get user's photo

.DESCRIPTION

No description available.

.PARAMETER Username
No description available.

.PARAMETER Size
No description available.

.OUTPUTS

None
#>
function Get-UserPhoto {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Username},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Size}
    )

    Process {
        'Calling method: Get-UserPhoto' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter

        $Configuration = Get-Configuration
        $LocalVarUri = '/users/{username}/photo'
        if (!$Username) {
            throw "Error! The required parameter `Username` missing when calling getUserPhoto."
        }
        $LocalVarUri = $LocalVarUri.replace('{username}', $Username)

        $LocalVarQueryParameters['size'] = $Size

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientId"]) {
            $LocalVarHeaderParameters['ClientId'] = $Configuration["ApiKey"]["ClientId"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientSecret"]) {
            $LocalVarHeaderParameters['ClientSecret'] = $Configuration["ApiKey"]["ClientSecret"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["UserPrincipalName"]) {
            $LocalVarHeaderParameters['UserPrincipalName'] = $Configuration["ApiKey"]["UserPrincipalName"]
        }

        $LocalVarResult = Invoke-ApiClient -Method 'GET' `
                                -Uri $LocalVarUri `
                                -Accepts $LocalVarAccepts `
                                -ContentTypes $LocalVarContentTypes `
                                -Body $LocalVarBodyParameter `
                                -HeaderParameters $LocalVarHeaderParameters `
                                -QueryParameters $LocalVarQueryParameters `
                                -FormParameters $LocalVarFormParameters `
                                -CookieParameters $LocalVarCookieParameters `
                                -ReturnType ""

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

get user relationship

.DESCRIPTION

No description available.

.PARAMETER Username
No description available.

.OUTPUTS

UserRelationShip
#>
function Get-UserRelationship {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Username}
    )

    Process {
        'Calling method: Get-UserRelationship' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json', 'text/json')

        $LocalVarUri = '/users/{username}/relationship'
        if (!$Username) {
            throw "Error! The required parameter `Username` missing when calling getUserRelationship."
        }
        $LocalVarUri = $LocalVarUri.replace('{username}', $Username)

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientId"]) {
            $LocalVarHeaderParameters['ClientId'] = $Configuration["ApiKey"]["ClientId"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientSecret"]) {
            $LocalVarHeaderParameters['ClientSecret'] = $Configuration["ApiKey"]["ClientSecret"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["UserPrincipalName"]) {
            $LocalVarHeaderParameters['UserPrincipalName'] = $Configuration["ApiKey"]["UserPrincipalName"]
        }

        $LocalVarResult = Invoke-ApiClient -Method 'GET' `
                                -Uri $LocalVarUri `
                                -Accepts $LocalVarAccepts `
                                -ContentTypes $LocalVarContentTypes `
                                -Body $LocalVarBodyParameter `
                                -HeaderParameters $LocalVarHeaderParameters `
                                -QueryParameters $LocalVarQueryParameters `
                                -FormParameters $LocalVarFormParameters `
                                -CookieParameters $LocalVarCookieParameters `
                                -ReturnType "UserRelationShip"

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

get users from sharepoint

.DESCRIPTION

No description available.

.PARAMETER Username
No description available.

.PARAMETER RequestBody
No description available.

.OUTPUTS

ApiUser
#>
function Get-UsersFromSharePoint {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Username},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String[]]
        ${RequestBody}
    )

    Process {
        'Calling method: Get-UsersFromSharePoint' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json', 'text/json')

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json-patch+json', 'application/json', 'text/json', 'application/*+json')

        $LocalVarUri = '/users/sharepoint/validate'

        $LocalVarQueryParameters['username'] = $Username

        $LocalVarBodyParameter = $RequestBody | ConvertTo-Json

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientId"]) {
            $LocalVarHeaderParameters['ClientId'] = $Configuration["ApiKey"]["ClientId"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientSecret"]) {
            $LocalVarHeaderParameters['ClientSecret'] = $Configuration["ApiKey"]["ClientSecret"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["UserPrincipalName"]) {
            $LocalVarHeaderParameters['UserPrincipalName'] = $Configuration["ApiKey"]["UserPrincipalName"]
        }

        $LocalVarResult = Invoke-ApiClient -Method 'POST' `
                                -Uri $LocalVarUri `
                                -Accepts $LocalVarAccepts `
                                -ContentTypes $LocalVarContentTypes `
                                -Body $LocalVarBodyParameter `
                                -HeaderParameters $LocalVarHeaderParameters `
                                -QueryParameters $LocalVarQueryParameters `
                                -FormParameters $LocalVarFormParameters `
                                -CookieParameters $LocalVarCookieParameters `
                                -ReturnType "ApiUser"

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

resolve users

.DESCRIPTION

No description available.

.PARAMETER Keyword
No description available.

.PARAMETER UserType
All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4

.PARAMETER UserSource
All=0, Local=1, Azure=2, SharePoint=3

.PARAMETER SharingOptions
Disabled=0, VerifiedGuestUser=1, Anyone=2, ExistingGuestUser=3

.PARAMETER SiteUrlOrTenantId
No description available.

.OUTPUTS

ApiUser[]
#>
function Resolve-Users {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Keyword},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${UserType},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${UserSource},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${SharingOptions},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${SiteUrlOrTenantId}
    )

    Process {
        'Calling method: Resolve-Users' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json', 'text/json')

        $LocalVarUri = '/users/resolve'

        if (!$UserType) {
            throw "Error! The required parameter `UserType` missing when calling resolveUsers."
        }
        $LocalVarQueryParameters['userType'] = $UserType

        if (!$UserSource) {
            throw "Error! The required parameter `UserSource` missing when calling resolveUsers."
        }
        $LocalVarQueryParameters['userSource'] = $UserSource

        if (!$SharingOptions) {
            throw "Error! The required parameter `SharingOptions` missing when calling resolveUsers."
        }
        $LocalVarQueryParameters['sharingOptions'] = $SharingOptions

        $LocalVarQueryParameters['siteUrlOrTenantId'] = $SiteUrlOrTenantId

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientId"]) {
            $LocalVarHeaderParameters['ClientId'] = $Configuration["ApiKey"]["ClientId"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientSecret"]) {
            $LocalVarHeaderParameters['ClientSecret'] = $Configuration["ApiKey"]["ClientSecret"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["UserPrincipalName"]) {
            $LocalVarHeaderParameters['UserPrincipalName'] = $Configuration["ApiKey"]["UserPrincipalName"]
        }

        $LocalVarResult = Invoke-ApiClient -Method 'GET' `
                                -Uri $LocalVarUri `
                                -Accepts $LocalVarAccepts `
                                -ContentTypes $LocalVarContentTypes `
                                -Body $LocalVarBodyParameter `
                                -HeaderParameters $LocalVarHeaderParameters `
                                -QueryParameters $LocalVarQueryParameters `
                                -FormParameters $LocalVarFormParameters `
                                -CookieParameters $LocalVarCookieParameters `
                                -ReturnType "ApiUser[]"

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

resolve user including external users

.DESCRIPTION

No description available.

.PARAMETER Keyword
No description available.

.PARAMETER SiteUrlOrTenantId
No description available.

.PARAMETER ExternalSharingOption
No description available.

.PARAMETER UserType
All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4

.PARAMETER UserSource
All=0, Local=1, Azure=2, SharePoint=3

.OUTPUTS

SharingEnabledUser[]
#>
function Resolve-UsersWithExternalSharingOption {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Keyword},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${SiteUrlOrTenantId},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${ExternalSharingOption},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${UserType},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${UserSource}
    )

    Process {
        'Calling method: Resolve-UsersWithExternalSharingOption' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json', 'text/json')

        $LocalVarUri = '/users/resolve/{externalSharingOption}'
        if (!$ExternalSharingOption) {
            throw "Error! The required parameter `ExternalSharingOption` missing when calling resolveUsersWithExternalSharingOption."
        }
        $LocalVarUri = $LocalVarUri.replace('{externalSharingOption}', $ExternalSharingOption)

        if (!$UserType) {
            throw "Error! The required parameter `UserType` missing when calling resolveUsersWithExternalSharingOption."
        }
        $LocalVarQueryParameters['userType'] = $UserType

        if (!$UserSource) {
            throw "Error! The required parameter `UserSource` missing when calling resolveUsersWithExternalSharingOption."
        }
        $LocalVarQueryParameters['userSource'] = $UserSource

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientId"]) {
            $LocalVarHeaderParameters['ClientId'] = $Configuration["ApiKey"]["ClientId"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientSecret"]) {
            $LocalVarHeaderParameters['ClientSecret'] = $Configuration["ApiKey"]["ClientSecret"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["UserPrincipalName"]) {
            $LocalVarHeaderParameters['UserPrincipalName'] = $Configuration["ApiKey"]["UserPrincipalName"]
        }

        $LocalVarResult = Invoke-ApiClient -Method 'GET' `
                                -Uri $LocalVarUri `
                                -Accepts $LocalVarAccepts `
                                -ContentTypes $LocalVarContentTypes `
                                -Body $LocalVarBodyParameter `
                                -HeaderParameters $LocalVarHeaderParameters `
                                -QueryParameters $LocalVarQueryParameters `
                                -FormParameters $LocalVarFormParameters `
                                -CookieParameters $LocalVarCookieParameters `
                                -ReturnType "SharingEnabledUser[]"

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

search users

.DESCRIPTION

No description available.

.PARAMETER Keyword
No description available.

.PARAMETER UserType
All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4

.PARAMETER UserSource
All=0, Local=1, Azure=2, SharePoint=3

.PARAMETER SharingOptions
Disabled=0, VerifiedGuestUser=1, Anyone=2, ExistingGuestUser=3

.PARAMETER SiteUrlOrTenantId
No description available.

.OUTPUTS

ApiUser[]
#>
function Search-Users {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Keyword},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${UserType},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${UserSource},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${SharingOptions},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${SiteUrlOrTenantId}
    )

    Process {
        'Calling method: Search-Users' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json', 'text/json')

        $LocalVarUri = '/users/search'

        if (!$UserType) {
            throw "Error! The required parameter `UserType` missing when calling searchUsers."
        }
        $LocalVarQueryParameters['userType'] = $UserType

        if (!$UserSource) {
            throw "Error! The required parameter `UserSource` missing when calling searchUsers."
        }
        $LocalVarQueryParameters['userSource'] = $UserSource

        if (!$SharingOptions) {
            throw "Error! The required parameter `SharingOptions` missing when calling searchUsers."
        }
        $LocalVarQueryParameters['sharingOptions'] = $SharingOptions

        $LocalVarQueryParameters['siteUrlOrTenantId'] = $SiteUrlOrTenantId

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientId"]) {
            $LocalVarHeaderParameters['ClientId'] = $Configuration["ApiKey"]["ClientId"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientSecret"]) {
            $LocalVarHeaderParameters['ClientSecret'] = $Configuration["ApiKey"]["ClientSecret"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["UserPrincipalName"]) {
            $LocalVarHeaderParameters['UserPrincipalName'] = $Configuration["ApiKey"]["UserPrincipalName"]
        }

        $LocalVarResult = Invoke-ApiClient -Method 'GET' `
                                -Uri $LocalVarUri `
                                -Accepts $LocalVarAccepts `
                                -ContentTypes $LocalVarContentTypes `
                                -Body $LocalVarBodyParameter `
                                -HeaderParameters $LocalVarHeaderParameters `
                                -QueryParameters $LocalVarQueryParameters `
                                -FormParameters $LocalVarFormParameters `
                                -CookieParameters $LocalVarCookieParameters `
                                -ReturnType "ApiUser[]"

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

search user including external users

.DESCRIPTION

No description available.

.PARAMETER Keyword
No description available.

.PARAMETER SiteUrlOrTenantId
No description available.

.PARAMETER ExternalSharingOption
No description available.

.PARAMETER UserType
All=0, User=1, Group=2, DistributionList=3, UserAndGroup=4

.PARAMETER UserSource
All=0, Local=1, Azure=2, SharePoint=3

.OUTPUTS

SharingEnabledUser[]
#>
function Search-UsersWithExternalSharingOption {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Keyword},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${SiteUrlOrTenantId},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${ExternalSharingOption},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${UserType},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${UserSource}
    )

    Process {
        'Calling method: Search-UsersWithExternalSharingOption' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json', 'text/json')

        $LocalVarUri = '/users/search/{externalSharingOption}'
        if (!$ExternalSharingOption) {
            throw "Error! The required parameter `ExternalSharingOption` missing when calling searchUsersWithExternalSharingOption."
        }
        $LocalVarUri = $LocalVarUri.replace('{externalSharingOption}', $ExternalSharingOption)

        if (!$UserType) {
            throw "Error! The required parameter `UserType` missing when calling searchUsersWithExternalSharingOption."
        }
        $LocalVarQueryParameters['userType'] = $UserType

        if (!$UserSource) {
            throw "Error! The required parameter `UserSource` missing when calling searchUsersWithExternalSharingOption."
        }
        $LocalVarQueryParameters['userSource'] = $UserSource

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientId"]) {
            $LocalVarHeaderParameters['ClientId'] = $Configuration["ApiKey"]["ClientId"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientSecret"]) {
            $LocalVarHeaderParameters['ClientSecret'] = $Configuration["ApiKey"]["ClientSecret"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["UserPrincipalName"]) {
            $LocalVarHeaderParameters['UserPrincipalName'] = $Configuration["ApiKey"]["UserPrincipalName"]
        }

        $LocalVarResult = Invoke-ApiClient -Method 'GET' `
                                -Uri $LocalVarUri `
                                -Accepts $LocalVarAccepts `
                                -ContentTypes $LocalVarContentTypes `
                                -Body $LocalVarBodyParameter `
                                -HeaderParameters $LocalVarHeaderParameters `
                                -QueryParameters $LocalVarQueryParameters `
                                -FormParameters $LocalVarFormParameters `
                                -CookieParameters $LocalVarCookieParameters `
                                -ReturnType "SharingEnabledUser[]"

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

No description available.

.PARAMETER UpdatableApiUser
No description available.

.OUTPUTS

None
#>
function Update-UserInfo {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${UpdatableApiUser}
    )

    Process {
        'Calling method: Update-UserInfo' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter

        $Configuration = Get-Configuration
        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json-patch+json', 'application/json', 'text/json', 'application/*+json')

        $LocalVarUri = '/users'

        $LocalVarBodyParameter = $UpdatableApiUser | ConvertTo-Json

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientId"]) {
            $LocalVarHeaderParameters['ClientId'] = $Configuration["ApiKey"]["ClientId"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["ClientSecret"]) {
            $LocalVarHeaderParameters['ClientSecret'] = $Configuration["ApiKey"]["ClientSecret"]
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["UserPrincipalName"]) {
            $LocalVarHeaderParameters['UserPrincipalName'] = $Configuration["ApiKey"]["UserPrincipalName"]
        }

        $LocalVarResult = Invoke-ApiClient -Method 'POST' `
                                -Uri $LocalVarUri `
                                -Accepts $LocalVarAccepts `
                                -ContentTypes $LocalVarContentTypes `
                                -Body $LocalVarBodyParameter `
                                -HeaderParameters $LocalVarHeaderParameters `
                                -QueryParameters $LocalVarQueryParameters `
                                -FormParameters $LocalVarFormParameters `
                                -CookieParameters $LocalVarCookieParameters `
                                -ReturnType ""

        return $LocalVarResult["Response"]
    }
}

