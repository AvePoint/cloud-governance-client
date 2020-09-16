#
# Cloud Governance Api
# No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
# Version: 1.0
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

get active licences

.DESCRIPTION

No description available.

.OUTPUTS

String[]
#>
function Get-ActiveLicenses {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Calling method: Get-ActiveLicenses' | Write-Debug
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

        $LocalVarUri = '/admin/aos/licenses'

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
                                -ReturnType "String[]"

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

No description available.

.OUTPUTS

String[]
#>
function Get-AdminCenterUrls {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Calling method: Get-AdminCenterUrls' | Write-Debug
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

        $LocalVarUri = '/admin/aos/admincenters'

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
                                -ReturnType "String[]"

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

get archive profiles

.DESCRIPTION

No description available.

.PARAMETER Level
No description available.

.PARAMETER IsManualArchive
No description available.

.OUTPUTS

String[]
#>
function Get-ArchiveProfiles {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Level},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [System.Nullable[Boolean]]
        ${IsManualArchive}
    )

    Process {
        'Calling method: Get-ArchiveProfiles' | Write-Debug
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

        $LocalVarUri = '/admin/aos/cloudmanagement/profiles/archive/{level}'
        if (!$Level) {
            throw "Error! The required parameter `Level` missing when calling getArchiveProfiles."
        }
        $LocalVarUri = $LocalVarUri.replace('{level}', $Level)

        if ($IsManualArchive) {
            $LocalVarQueryParameters['isManualArchive'] = $IsManualArchive
        }

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
                                -ReturnType "String[]"

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

No description available.

.OUTPUTS

StringModel[]
#>
function Get-AzureADProfiles {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Calling method: Get-AzureADProfiles' | Write-Debug
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

        $LocalVarUri = '/admin/aos/profiles/azuread'

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
                                -ReturnType "StringModel[]"

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

get dpm plans

.DESCRIPTION

No description available.

.OUTPUTS

String[]
#>
function Get-DpmPlans {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Calling method: Get-DpmPlans' | Write-Debug
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

        $LocalVarUri = '/admin/aos/cloudmanagement/profiles/dpm'

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
                                -ReturnType "String[]"

        return $LocalVarResult["Response"]
    }
}

<#
.SYNOPSIS

get enforcer profiles

.DESCRIPTION

No description available.

.OUTPUTS

String[]
#>
function Get-EnforcerProfiles {
    [CmdletBinding()]
    Param (
    )

    Process {
        'Calling method: Get-EnforcerProfiles' | Write-Debug
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

        $LocalVarUri = '/admin/aos/cloudmanagement/profiles/enforcer'

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
                                -ReturnType "String[]"

        return $LocalVarResult["Response"]
    }
}
