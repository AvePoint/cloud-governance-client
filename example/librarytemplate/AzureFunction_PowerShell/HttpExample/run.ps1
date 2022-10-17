
using namespace System.Net

# Input bindings are passed in via param block.
param($Request, $TriggerMetadata)

Write-Host $Request

$requestId=$Request.Body.RequestId
$scriptLocation=$Request.Body.ScriptLocation
$parentWeb=$Request.Body.ParentWebUrl
$listTitle=$Request.Body.ListTitle

# O365 tenant name, for example 'm365x1234.onmicrosoft.com'
$tenant=$env:O365Tenant_NAME

#The client id of azure application client id, this application is used to acquire application permission token
$appClientId=$env:AZURE_APPLICATION_CLIENT_ID

#The thumbprint of the azure application's certificate 
$thumbprint=$env:AZURE_APPLICATION_CERTIFICATE_THUMBPRINT

if(-not  $requestId )
{
	throw "RequestId can not be null"
}
if(-not $scriptLocation)
{
	throw "ScriptLocation can not be null"
}
if(-not $parentWeb)
{
	throw "ParentWebUrl can not be null"
}
if(-not $listTitle)
{
	throw "ListTitle can not be null"
}
if(-not $tenant)
{
    throw "O365Tenant_NAME is not configured in azure function 'Configuration'"
}
if(-not $appClientId)
{
    throw "AZURE_APPLICATION_CLIENT_ID is not configured in azure function 'Configuration'"
}
if(-not $thumbprint)
{
    throw "AZURE_APPLICATION_CERTIFICATE_THUMBPRINT is not configured in azure function 'Configuration'"
}

Write-Host 	"Parameter requestId:$requestId ,scriptLocation:$scriptLocation,parentWeb:$parentWeb,listTitle:$listTitle"

function GetRequestMetadata($requestId){
    $Configuration = Get-Configuration
    # You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
    $Configuration["BaseUrl"] = $env:CLOUD_GOVERNANCE_CLIENT_ENDPOINT

    # Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
    $Configuration["ApiKey"]["clientSecret"] = $env:CLOUD_GOVERNANCE_CLIENT_SECRET

    # Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
    # Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
    # If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
    $Configuration["ApiKey"]["userPrincipalName"] = $env:CLOUD_GOVERNANCE_CLIENT_ACCOUNT

    $requestInfo=Get-DynamicRequest -Id $requestId
    $metadatas=@{}
    if($null -ne $requestInfo.Metadatas){
        foreach($m in $requestInfo.Metadatas){
            $metadatas[$m.Name]=$m.ValueString
        }
    }
    if($null -ne $requestInfo.ActivityGalleries){
        foreach($gallery in $requestInfo.ActivityGalleries){
            if( $null -ne $gallery.GalleryMetadata ){
                foreach($gm in $gallery.GalleryMetadata){
                    $metadatas[$gm.Name]=$gm.ValueString
                }
            }
        }
    }
    $metadatas
}

write-host "try to download file from $scriptLocation"

#A temp folder to save library template file
$file= "C:\\home\\data\\"+$requestId+".ps1"
Invoke-webrequest -uri  $scriptLocation -UseBasicParsing -outfile $file

write-host "download to $file from $scriptLocation complete "

#Acquire request metadata
$metadatas=GetRequestMetadata($requestId)

#invoke library template script
$result=Start-ThreadJob -FilePath $file  -ThrottleLimit 100 -ArgumentList @($listTitle,$parentWeb,$metadatas,$tenant,$appClientId,$thumbprint) | Wait-Job | Receive-Job

Write-Information "Result is $result"

if($result -is [array])
{
    $result = $result[-1]
}
if($result -eq "success")
{
	Push-OutputBinding -Name Response -Value ([HttpResponseContext]@{
        StatusCode = [HttpStatusCode]::OK
        Body        = $result
    })
}else
{
	Push-OutputBinding -Name Response -Value ([HttpResponseContext]@{
        StatusCode = [HttpStatusCode]::InternalServerError
        Body        = $result
    })
}

