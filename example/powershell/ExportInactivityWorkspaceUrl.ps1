$ModuleName="Cloud.Governance.Client"
if( $null -eq  (Get-InstalledModule -Name $ModuleName -MinimumVersion "7.6.0")){
 Install-Module -Name $ModuleName -Force -MinimumVersion "7.6.0"
}

Import-Module -Name $ModuleName

 $Configuration = Get-Configuration
 $Configuration["BaseUrl"] = "{Cloud Governance Modern API Endpoint}"

 # Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
 $Configuration["ApiKey"]["clientSecret"] = "eyJ..."
 # Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
 # Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
 # If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
 $Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"



$stopwatch =  [system.diagnostics.stopwatch]::StartNew()

$Filter = "(taskType eq 'SCNoAccess' or taskType eq 'GroupInactivityThreshold') and status eq 'Running'"
$Nexttoken = ""
$Tasks = New-Object System.Collections.ArrayList
# get all tasks
try {
    do{
        
    $PageResult = Get-AllTasks -Nexttoken $NextToken -Filter $Filter
    if (($null  -ne $PageResult.Value) -and $PageResult.Value.Length -gt 0) 
    {
        $Tasks.AddRange($PageResult.Value)
    }
    $NextToken = $PageResult.nexttoken
  } while ( $null -ne $NextToken)
  
  $path = "$($PSScriptRoot)\Urls.csv"
  $Urls = $Tasks | Select-Object -Property Url
  $Urls | Export-Csv -Path $path -NoTypeInformation -Encoding UTF8
  Write-Host("Finish to get Inactivity workspace urls,file path:$($path),count:$($Urls.Count),duration:$($stopwatch.Elapsed)")


} catch {
    Write-Host ("Exception occured when calling Get-AllTasks: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
}