#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
.SYNOPSIS

delete token cache

.DESCRIPTION

No description available.

.PARAMETER ApiCredential
No description available.

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

None
#>
function Invoke-DeleteTokenCache {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [PSCustomObject]
        ${ApiCredential},
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Invoke-DeleteTokenCache' | Write-Debug
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

        # HTTP header 'Content-Type'
        $LocalVarContentTypes = @('application/json')

        $LocalVarUri = '/admin/auth/token/cache'

        if (!$ApiCredential) {
            throw "Error! The required parameter `ApiCredential` missing when calling deleteTokenCache."
        }

        $LocalVarBodyParameter = $ApiCredential | ConvertTo-Json -Depth 100

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["clientSecret"]) {
            $LocalVarHeaderParameters['clientSecret'] = $Configuration["ApiKey"]["clientSecret"]
            Write-Verbose ("Using API key 'clientSecret' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        if ($Configuration["ApiKey"] -and $Configuration["ApiKey"]["userPrincipalName"]) {
            $LocalVarHeaderParameters['userPrincipalName'] = $Configuration["ApiKey"]["userPrincipalName"]
            Write-Verbose ("Using API key 'userPrincipalName' in the header for authentication in {0}" -f $MyInvocation.MyCommand)
        }

        $LocalVarResult = Invoke-ApiClient -Method 'DELETE' `
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

