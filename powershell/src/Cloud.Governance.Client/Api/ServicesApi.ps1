#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
.SYNOPSIS

get change group setting service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ChangeGroupSettingService
#>
function Get-ChangeGroupSettingService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-ChangeGroupSettingService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/changegroupsetting/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getChangeGroupSettingService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ChangeGroupSettingService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get change list setting service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ChangeListSettingService
#>
function Get-ChangeListSettingService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-ChangeListSettingService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/changelistsetting/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getChangeListSettingService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ChangeListSettingService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get change permission service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ChangePermissionService
#>
function Get-ChangePermissionService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-ChangePermissionService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/changepermission/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getChangePermissionService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ChangePermissionService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get change site contact service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ChangeSiteContactService
#>
function Get-ChangeSiteContactService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-ChangeSiteContactService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/changesitecontact/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getChangeSiteContactService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ChangeSiteContactService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get change site setting service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ChangeSiteSettingService
#>
function Get-ChangeSiteSettingService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-ChangeSiteSettingService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/changesitesetting/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getChangeSiteSettingService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ChangeSiteSettingService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for change web contact service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ChangeWebContactService
#>
function Get-ChangeWebContactService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-ChangeWebContactService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/changewebcontact/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getChangeWebContactService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ChangeWebContactService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get change web setting service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ChangeWebSettingService
#>
function Get-ChangeWebSettingsService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-ChangeWebSettingsService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/changewebsettings/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getChangeWebSettingsService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ChangeWebSettingService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get clone permission service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ClonePermissionService
#>
function Get-ClonePermissionService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-ClonePermissionService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/clonepermission/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getClonePermissionService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ClonePermissionService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get content move profiles from cloud management

.DESCRIPTION

No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ContentMoveProfiles
#>
function Get-ContentMoveProfiles {
    [CmdletBinding()]
    Param (
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-ContentMoveProfiles' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/contentmove/profiles'

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ContentMoveProfiles" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get content move service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ContentMoveService
#>
function Get-ContentMoveService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-ContentMoveService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/contentmove/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getContentMoveService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ContentMoveService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get create group service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

CreateGroupService
#>
function Get-CreateGroupService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-CreateGroupService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/creategroup/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getCreateGroupService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "CreateGroupService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get create group service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

CreateGuestUserService
#>
function Get-CreateGuestUserService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-CreateGuestUserService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/createguestuser/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getCreateGuestUserService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "CreateGuestUserService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get create list service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

CreateListService
#>
function Get-CreateListService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-CreateListService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/createlist/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getCreateListService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "CreateListService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get create site service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

CreateSiteService
#>
function Get-CreateSiteService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-CreateSiteService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/createsite/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getCreateSiteService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "CreateSiteService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get create web service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

CreateWebService
#>
function Get-CreateWebService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-CreateWebService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/createweb/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getCreateWebService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "CreateWebService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get custom service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ServiceForRequest
#>
function Get-CustomService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-CustomService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/custom/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getCustomService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ServiceForRequest" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get grant permission service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

GrantPermissionService
#>
function Get-GrantPermissionService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-GrantPermissionService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/grantpermission/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getGrantPermissionService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "GrantPermissionService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get group lifecycle service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

GroupLifecycleService
#>
function Get-GroupLifecycleService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-GroupLifecycleService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/grouplifecycle/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getGroupLifecycleService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "GroupLifecycleService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get manage permission service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ManagePermissionService
#>
function Get-ManagePermissionService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-ManagePermissionService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/managepermission/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getManagePermissionService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ManagePermissionService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get services that can be used to start a request

.DESCRIPTION

No description available.

.PARAMETER Search
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ServiceListPageResult
#>
function Get-MyServices {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Search},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-MyServices' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/my'

        if ($Search) {
            $LocalVarQueryParameters['search'] = $Search
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ServiceListPageResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get service id by service name

.DESCRIPTION

No description available.

.PARAMETER Name
service name, case insensitive

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

String
#>
function Get-ServiceId {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Name},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-ServiceId' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/id'

        if ($Name) {
            $LocalVarQueryParameters['name'] = $Name
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "String" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get site lifecycle service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

SiteLifecycleService
#>
function Get-SiteLifecycleService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-SiteLifecycleService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/sitelifecycle/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getSiteLifecycleService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "SiteLifecycleService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

get web lifecycle service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER QuestionnaireId
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

WebLifecycleService
#>
function Get-WebLifecycleService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${QuestionnaireId},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-WebLifecycleService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/weblifecycle/{id}'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling getWebLifecycleService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($QuestionnaireId) {
            $LocalVarQueryParameters['questionnaireId'] = $QuestionnaireId
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "WebLifecycleService" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate guest user email

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER Email
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ObjectValidateResult
#>
function Resolve-EmailForCreateGuestUserService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Email},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-EmailForCreateGuestUserService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        $LocalVarUri = '/services/createguestuser/{id}/email/validate'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateEmailForCreateGuestUserService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($Email) {
            $LocalVarQueryParameters['email'] = $Email
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ObjectValidateResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for change group setting service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER ChangeGroupSettingValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ChangeGroupSettingCheckResult
#>
function Resolve-ForChangeGroupSettingService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${ChangeGroupSettingValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForChangeGroupSettingService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/changegroupsetting/{id}/group/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForChangeGroupSettingService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $ChangeGroupSettingValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ChangeGroupSettingCheckResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for change list setting service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER SiteValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ChangeListSettingValidateResult
#>
function Resolve-ForChangeListSettingService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${SiteValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForChangeListSettingService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/changelistsetting/{id}/url/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForChangeListSettingService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $SiteValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ChangeListSettingValidateResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for change permission service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER SiteValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ChangePermissionValidateResult
#>
function Resolve-ForChangePermissionService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${SiteValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForChangePermissionService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/changepermission/{id}/url/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForChangePermissionService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $SiteValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ChangePermissionValidateResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for change site contact service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER SiteValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ChangeSiteContactValidateResult
#>
function Resolve-ForChangeSiteContactService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${SiteValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForChangeSiteContactService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/changesitecontact/{id}/url/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForChangeSiteContactService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $SiteValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ChangeSiteContactValidateResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for change site setting service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER SiteValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ChangeSiteSettingValidateResult
#>
function Resolve-ForChangeSiteSettingService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${SiteValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForChangeSiteSettingService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/changesitesetting/{id}/url/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForChangeSiteSettingService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $SiteValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ChangeSiteSettingValidateResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for change web contact service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER SiteValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ChangeWebContactValidateResult
#>
function Resolve-ForChangeWebContactService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${SiteValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForChangeWebContactService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/changewebcontact/{id}/url/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForChangeWebContactService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $SiteValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ChangeWebContactValidateResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for change web setting service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER SiteValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ChangeWebUrlValidateResult
#>
function Resolve-ForChangeWebSettingService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${SiteValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForChangeWebSettingService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/changewebsettings/{id}/url/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForChangeWebSettingService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $SiteValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ChangeWebUrlValidateResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for clone permission service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER SiteValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ClonePermissionValidateResult
#>
function Resolve-ForClonePermissionService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${SiteValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForClonePermissionService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/clonepermission/{id}/url/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForClonePermissionService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $SiteValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ClonePermissionValidateResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for content move service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER SiteValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ContentMoveUrlValidationResult
#>
function Resolve-ForContentMoveService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${SiteValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForContentMoveService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/contentmove/{id}/url/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForContentMoveService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $SiteValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ContentMoveUrlValidationResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate groups can invite

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER RequestId
No description available.

.PARAMETER ApiUser
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

CreateGuestUserValidationResult[]
#>
function Resolve-ForCreateGuestUserService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${RequestId},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject[]]
        ${ApiUser},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForCreateGuestUserService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/createguestuser/{id}/group/validate'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForCreateGuestUserService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        if ($RequestId) {
            $LocalVarQueryParameters['requestId'] = $RequestId
        }

        $LocalVarBodyParameter = $ApiUser | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "CreateGuestUserValidationResult[]" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for create list service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER ListValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

CreateListUrlValidationResult
#>
function Resolve-ForCreateListService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${ListValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForCreateListService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/createlist/{id}/url/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForCreateListService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $ListValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "CreateListUrlValidationResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for create web service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER CreateWebValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

CreateWebUrlValidationResult
#>
function Resolve-ForCreateWebService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${CreateWebValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForCreateWebService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/createweb/{id}/url/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForCreateWebService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $CreateWebValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "CreateWebUrlValidationResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for grant permission service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER SiteValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

GrantPermissionUrlValidationResult
#>
function Resolve-ForGrantPermissionService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${SiteValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForGrantPermissionService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/grantpermission/{id}/url/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForGrantPermissionService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $SiteValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "GrantPermissionUrlValidationResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for group lifecycle service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER GroupValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

GroupLifecycleValidateResult
#>
function Resolve-ForGroupLifecycleService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${GroupValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForGroupLifecycleService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/grouplifecycle/{id}/group/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForGroupLifecycleService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $GroupValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "GroupLifecycleValidateResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for manage permission service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER SiteValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

ManagePermissionValidateResult
#>
function Resolve-ForManagePermissionService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${SiteValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForManagePermissionService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/managepermission/{id}/url/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForManagePermissionService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $SiteValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "ManagePermissionValidateResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for site lifecycle service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER SiteValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

SiteLifecycleValidateResult
#>
function Resolve-ForSiteLifecycleService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${SiteValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForSiteLifecycleService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/sitelifecycle/{id}/url/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForSiteLifecycleService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $SiteValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "SiteLifecycleValidateResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

<#
.SYNOPSIS

validate permissions, scope for web lifecycle service

.DESCRIPTION

No description available.

.PARAMETER Id
No description available.

.PARAMETER SiteValidationParameter
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

WebLifecycleValidateResult
#>
function Resolve-ForWebLifecycleService {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${Id},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${SiteValidationParameter},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Resolve-ForWebLifecycleService' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $LocalVarAccepts = @()
        $LocalVarContentTypes = @()
        $LocalVarQueryParameters = @{}
        $LocalVarHeaderParameters = @{}
        $LocalVarFormParameters = @{}
        $LocalVarPathParameters = @{}
        $LocalVarCookieParameters = @{}
        $LocalVarBodyParameter = $null

        $Configuration = Get-Configuration
        # HTTP header 'Accept' (if needed)
        $LocalVarAccepts = @('text/plain', 'application/json')

        if ($ReturnType) {
            # use the return type (MIME) provided by the user
            $LocalVarAccepts = @($ReturnType)
        }

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/services/weblifecycle/{id}/url/validation'
        if (!$Id) {
            throw "Error! The required parameter `Id` missing when calling validateForWebLifecycleService."
        }
        $LocalVarUri = $LocalVarUri.replace('{id}', $Id)

        $LocalVarBodyParameter = $SiteValidationParameter | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
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
                                -ReturnType "WebLifecycleValidateResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

