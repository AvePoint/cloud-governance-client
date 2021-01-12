#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
.SYNOPSIS

get azure ad custom property names

.DESCRIPTION

No description available.

.PARAMETER TenantId
No description available.

.PARAMETER IsSearchUserProperty
No description available.

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

String[]
#>
function Get-AzureAdCustomPropertyNames {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${TenantId},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [System.Nullable[Boolean]]
        ${IsSearchUserProperty},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-AzureAdCustomPropertyNames' | Write-Debug
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

        $LocalVarUri = '/admin/office365/azuread/{tenantId}/property/names/custom'
        if (!$TenantId) {
            throw "Error! The required parameter `TenantId` missing when calling getAzureAdCustomPropertyNames."
        }
        $LocalVarUri = $LocalVarUri.replace('{tenantId}', $TenantId)

        if ($IsSearchUserProperty) {
            $LocalVarQueryParameters['isSearchUserProperty'] = $IsSearchUserProperty
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
                                -ReturnType "String[]" `
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

get tenant ids by url

.DESCRIPTION

No description available.

.PARAMETER Uri
No description available.

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

None
#>
function Get-TenantIdByUrl {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Uri},
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-TenantIdByUrl' | Write-Debug
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
        $LocalVarAccepts = @('application/json')

        $LocalVarUri = '/admin/office365/tenantid'

        if (!$Uri) {
            throw "Error! The required parameter `Uri` missing when calling getTenantIdByUrl."
        }
        $LocalVarQueryParameters['uri'] = $Uri

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
                                -ReturnType "" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

