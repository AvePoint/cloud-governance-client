#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
.SYNOPSIS

get all requests

.DESCRIPTION

No description available.

.PARAMETER Filter
Use **eq**(equal) or **ne**(not equal) to filter the results (e.g. field1 eq 'value1' and field2 ne 'value2'), supported fields :<br/> id, serviceId, serviceName, serviceType, category, approvalStageName, participants, ticketNumber, summary, requester, detailStatus, progressStatus, modified, assignTo, serviceAdmin, objectUrl, objectID, createdTime, hasSubRequest

.PARAMETER Orderby
Order by one field, supported fields:<br/> id, serviceId, serviceName, serviceType, category, approvalStageName, participants, ticketNumber, summary, requester, detailStatus, progressStatus, modified, assignTo, serviceAdmin, objectUrl, objectID, createdTime, hasSubRequest

.PARAMETER Search
Search for ticketNumber

.PARAMETER Top
 Define the number of records you want to return, max value is 3000, default value is 200

.PARAMETER Skip
 Define the number of records you want to skip, default value is 0

.PARAMETER Nexttoken
 Use the next token to get the next paging result

.PARAMETER ReturnType

Select the return type (optional): text/plain, application/json

.PARAMETER WithHttpInfo

A switch when turned on will return a hash table of Response, StatusCode and Headers instead of just the Response

.OUTPUTS

AllRequestListPageResult
#>
function Get-AllRequests {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Filter},
        [Parameter(Position = 1, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Orderby},
        [Parameter(Position = 2, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Search},
        [Parameter(Position = 3, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [System.Nullable[Int32]]
        ${Top},
        [Parameter(Position = 4, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Skip},
        [Parameter(Position = 5, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${Nexttoken},
        [String]
        [ValidateSet("text/plain", "application/json")]
        $ReturnType,
        [Switch]
        $WithHttpInfo
    )

    Process {
        'Calling method: Get-AllRequests' | Write-Debug
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

        $LocalVarUri = '/admin/directory/requests'

        $LocalVarQueryParameters['filter'] = $Filter

        $LocalVarQueryParameters['orderby'] = $Orderby

        $LocalVarQueryParameters['search'] = $Search

        $LocalVarQueryParameters['top'] = $Top

        $LocalVarQueryParameters['skip'] = $Skip

        $LocalVarQueryParameters['nexttoken'] = $Nexttoken

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
                                -ReturnType "AllRequestListPageResult" `
                                -IsBodyNullable $false

        if ($WithHttpInfo.IsPresent) {
            return $LocalVarResult
        } else {
            return $LocalVarResult["Response"]
        }
    }
}

